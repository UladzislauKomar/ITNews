using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITNews.Domain.Contracts.Services;
using ITNews.Domain.Contracts.ViewModels;
using ITNews.Domain.Implementation.Services.Parsers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Localization;

namespace ITNews.Web.Controllers
{
    public class NewsController : Controller
    {
        private readonly INewsService newsService;
        private readonly INewsRatingService ratingService;
        private readonly IUserService userService;
        private readonly ISectionService sectionService;
        private readonly ITagService tagService;
        private readonly ICommentService commentService;
        private readonly INewsTagService newsTagService;
        private readonly ICommentLikeService commentLikeService;
        private readonly IServiceProvider serviceProvider;

        private readonly IStringLocalizer<NewsController> localizer;

        public NewsController(INewsService newsService, INewsRatingService ratingService, IUserService userService, ISectionService sectionService, ITagService tagService, ICommentService commentService, INewsTagService newsTagService, ICommentLikeService commentLikeService, IServiceProvider serviceProvider, IStringLocalizer<NewsController> localizer)
        {
            this.newsService = newsService;
            this.ratingService = ratingService;
            this.userService = userService;
            this.sectionService = sectionService;
            this.tagService = tagService;
            this.commentService = commentService;
            this.newsTagService = newsTagService;
            this.commentLikeService = commentLikeService;
            this.serviceProvider = serviceProvider;
            this.localizer = localizer;
        }

        [HttpGet]
        public ActionResult Index(string searchString = "")
        {
            var previewFlag = Request.Cookies["previewFlag"];
            //if (previewFlag != "true")
            //{
            //    return RedirectToAction("Preview", "News");
            //}
            var models = newsService.GetNewsList()
                                    .OrderByDescending(x => x.Created)
                                    .AsEnumerable();
            foreach (var model in models)
            {
                foreach (var item in model.Tags)
                {
                    item.Tag = tagService.GetTags().Single(x => x.TagId == item.TagId);
                }
                model.User.Likes = commentLikeService.GetLikes().Where(x => x.Comment.UserId == model.User.Id);
                model.Ratings = ratingService.GetRatingByNews(model);
            }

            if (searchString != null)
            {
                models = models.Where(x => x.Content.Contains(searchString) ||
                                           x.Title.Contains(searchString) ||
                                           x.Tags.Select(tag => tag.Tag.Name).Contains(searchString) ||
                                           x.Section.Name.Contains(searchString) ||
                                           x.User.UserName.Contains(searchString));
            }

            var tags = tagService.GetTags().Take(30);
            var totalTagCount = tags.Sum(x => x.News.Count());
            var tagToSize = new Dictionary<string, int>();
            foreach (var tag in tags)
            {
                var tagNewsCount = tag.News.Count();
                if(tagNewsCount <= 0)
                {
                    continue;
                }
                double tagPercent = totalTagCount / tagNewsCount;
                int tagSize = 12;
                for (int i = 1; i <= 4; i*=2)
                {
                    if (tagPercent <= i)
                    {
                        tagSize += 6 * (5-i);
                    }
                }
                tagToSize.Add(tag.Name, tagSize);
            }
            ViewData["tagSize"] = tagToSize;

            ViewData["TopOfTheLast7Days"] = localizer["TopOfTheLast7Days"];
            ViewData["TagCloud"] = localizer["TagCloud"];
            ViewData["At"] = localizer["At"];
            ViewData["Delete"] = localizer["Delete"];
            ViewData["Allow"] = localizer["Allow"];
            ViewData["NotAllowed"] = localizer["NotAllowed"];
            ViewData["Edit"] = localizer["Edit"];
            ViewData["Search"] = localizer["Search"];

            if (!User.IsInRole("admin"))
            {
                models = models.Where(x => x.IsAllowed);
            }
            return View(models);
        }

        public ActionResult TopPosts()
        {
            var models = newsService.GetNewsList()
                                    .Where(x => x.IsAllowed)
                                    .OrderByDescending(x => x.Created)
                                    .AsEnumerable();
            foreach (var model in models)
            {
                foreach (var item in model.Tags)
                {
                    item.Tag = tagService.GetTags().Single(x => x.TagId == item.TagId);
                }
                model.Comments = commentService.GetCommentsByNews(model);
                model.User.Likes = commentLikeService.GetLikes().Where(x => x.Comment.UserId == model.User.Id);
                model.Ratings = ratingService.GetRatingByNews(model);
            }
            var topModels = models.Where(x => x.Ratings.Count() > 0)
                .OrderByDescending(x => x.Ratings.Select(rate => rate.Rating).Average()).Take(20);

            ViewData["PostedAt"] = localizer["PostedAt"];
            ViewData["Delete"] = localizer["Delete"];
            ViewData["Edit"] = localizer["Edit"];

            return View(topModels);
        }

        public ActionResult Details(string newsId)
        {
            var newsModel = new NewsViewModel()
            {
                NewsId = newsId
            };
            var model = newsService.GetNewsDetails(newsModel);
            foreach (var item in model.Tags)
            {
                item.Tag = tagService.GetTags().Single(x => x.TagId == item.TagId);
            }
            model.Comments = commentService.GetCommentsByNews(model);
            model.User.Likes = commentLikeService.GetLikes().Where(x => x.Comment.UserId == model.User.Id);
            model.Ratings = ratingService.GetRatingByNews(model);
            foreach (var item in model.Comments)
            {
                item.User = userService.GetProfile(new UserViewModel() { Id = item.UserId });
                item.Likes = commentLikeService.GetLikesByComment(item);
                //item.User.Likes = commentLikeService.GetLikes().Where(x => x.Comment.UserId == model.User.Id);
            }

            ViewData["PostedAt"] = localizer["PostedAt"];
            ViewData["NoComments"] = localizer["NoComments"];
            ViewData["Comments"] = localizer["Comments"];
            ViewData["Delete"] = localizer["Delete"];
            ViewData["Edit"] = localizer["Edit"];

            return View(model);
        }

        // GET: News/Create
        [HttpGet]
        [Authorize(Roles = "admin, writer")]
        public ActionResult Create()
        {
            ViewData["PostTitle"] = localizer["PostTitle"];
            ViewData["ImageLink"] = localizer["ImageLink"];
            ViewData["Content"] = localizer["Content"];
            ViewData["Section"] = localizer["Section"];
            ViewData["Tags"] = localizer["Tags"];
            ViewData["Create"] = localizer["Create"];
            ViewData["CreatePost"] = localizer["CreatePost"];

            if (userService.GetCurrentUserAsync(HttpContext).Result.EmailConfirmed)
            {
                ViewData["Sections"] = sectionService.GetSections().Select(x => x.Name);
                return View();
            }
            
            return RedirectToAction("AccessDenied", "User");
        }

        // POST: News/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(NewsViewModel model)
        {
            try
            {
                // TODO: Add insert logic here
                model.UserId = userService.GetCurrentUserAsync(HttpContext).Result.Id;
                model.Created = DateTime.Now;
                model.Section = sectionService.GetSections()
                    .SingleOrDefault(x => x.Name == model.Section.Name);
                if(model.Section == null)
                {
                    throw new Exception("Section name is empty");
                }
                var tags = Request.Form["Tags"].First().Split(',');
                
                if (ModelState.IsValid)
                {
                    model = newsService.Post(model);
                }
                
                newsTagService.SetTags(model.NewsId, tags);

                return RedirectToAction(nameof(Index));
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        // GET: News/Edit/5
        [HttpGet]
        public ActionResult Edit(string newsId)
        {
            var newsModel = new NewsViewModel
            {
                NewsId = newsId
            };
            var model = newsService.GetNewsDetails(newsModel);
            ViewData["model"] = model;

            ViewData["Edit"] = localizer["Edit"];
            ViewData["PostTitle"] = localizer["PostTitle"];
            ViewData["Save"] = localizer["Save"];
            ViewData["Content"] = localizer["Content"];

            return View(model);
        }

        // POST: News/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(NewsViewModel model, string newsId)
        {
            try
            {
                // TODO: Add update logic here
                if (ModelState.IsValid && model.NewsId != string.Empty)
                {
                    newsService.Edit(model);
                }

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: News/Delete/5
        public ActionResult Delete(string newsId)
        {
            var newsModel = new NewsViewModel
            {
                NewsId = newsId
            };
            var model = newsService.GetNewsDetails(newsModel);

            ViewData["Delete"] = localizer["Delete"];
            ViewData["YouSure"] = localizer["YouSure"];
            ViewData["Back"] = localizer["Back"];

            ViewData["model"] = model;
            return View(model);
        }

        // POST: News/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(NewsViewModel model)
        {
            try
            {
                // TODO: Add delete logic here
                newsService.Delete(model);
                return RedirectToAction(nameof(Index));
            }
            catch(Exception exception)
            {
                throw exception;
            }
        }

        [HttpGet]
        public ActionResult Preview()
        {
            var models = newsService.GetNewsList()
                                    .Where(x => x.IsAllowed)
                                    .OrderByDescending(x => x.Created)
                                    .AsEnumerable();
            foreach (var model in models)
            {
                foreach (var item in model.Tags)
                {
                    item.Tag = tagService.GetTags().Single(x => x.TagId == item.TagId);
                }
                model.Comments = commentService.GetCommentsByNews(model);
                model.User.Likes = commentLikeService.GetLikes().Where(x => x.Comment.UserId == model.User.Id);
                model.Ratings = ratingService.GetRatingByNews(model);
            }
            var topModels = models.Where(x => x.Ratings.Count() > 0)
                                  .OrderByDescending(x => x.Ratings.Select(rate => rate.Rating)
                                                                   .Average())
                                  .Take(5)
                                  .ToList();
            Response.Cookies.Append("previewFlag", "true", new CookieOptions() { Path = "/", Expires = DateTimeOffset.MaxValue});
            if (topModels.Count < 5)
            {
                return RedirectToAction("Index", "News");
            }
            return View(topModels);
        }

        [Authorize(Roles = "admin")]
        [HttpGet]
        public ActionResult Allow(string newsId)
        {
            try
            { 
                var newsModel = new NewsViewModel()
                {
                    NewsId = newsId
                };
                var model = newsService.GetNewsDetails(newsModel);
                model.IsAllowed = true;
                newsService.Edit(model);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        [Authorize(Roles = "admin")]
        [HttpGet]
        public ActionResult ParseNews()
        {
            try
            {
                var tutByParseService = serviceProvider.GetServices<INewsParserService>().First(x => x.GetType() == typeof(TutByNewsParserService));
                var tutByModels = tutByParseService.ParseNews();
                var onlinerParseService = serviceProvider.GetServices<INewsParserService>().First(x => x.GetType() == typeof(OnlinerNewsParserService));
                var onlinerModels = onlinerParseService.ParseNews();
                //var budnyParseService = serviceProvider.GetServices<INewsParserService>().First(x => x.GetType() == typeof(BudnyNewsParserService));
                //var budnyModels = budnyParseService.ParseNews();
                var models = tutByModels.Concat(onlinerModels);
                foreach (var model in models)
                {
                    newsService.Post(model);
                }
                return RedirectToAction(nameof(Index));
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        [HttpGet]
        public ActionResult About()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Help()
        {
            return View();
        }
    }
}