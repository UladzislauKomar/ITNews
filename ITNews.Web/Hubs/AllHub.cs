using ITNews.Domain.Contracts.Services;
using ITNews.Domain.Contracts.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITNews.Web.Hubs
{
    public class AllHub : Hub
    {
        private readonly ICommentLikeService likeService;
        private readonly IUserService userService;
        private readonly INewsRatingService ratingService;
        private readonly ICommentService commentService;

        public AllHub(ICommentLikeService likeService, IUserService userService, INewsRatingService ratingService, ICommentService commentService)
        {
            this.likeService = likeService;
            this.userService = userService;
            this.ratingService = ratingService;
            this.commentService = commentService;
        }

        [Authorize]
        public async Task Like(string userName, string commentId)
        {
            try
            {
                var userModel = new UserViewModel()
                {
                    UserName = userName
                };
                userModel = userService.GetProfile(userModel);
                var commentModel = new CommentViewModel()
                {
                    CommentId = commentId
                };
                var userLike = likeService.GetLikesByComment(commentModel).FirstOrDefault(x => x.UserId == userModel.Id);

                if (userLike == null)
                {
                    var likeModel = new CommentLikeViewModel
                    {
                        UserId = userModel.Id,
                        CommentId = commentId
                    };
                    likeService.Like(likeModel);
                    await this.Clients.Caller.SendAsync("Like", userName, commentId);
                }
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        [Authorize]
        public async Task Comment(string userName, string newsId, string content, string created)
        {
            try
            {
                var user = new UserViewModel()
                {
                    UserName = userName
                };
                var userModel = userService.GetProfile(user);
                var model = new CommentViewModel
                {
                    UserId = userModel.Id,
                    NewsId = newsId,
                    Content = content,
                    Created = DateTime.Now//DateTime.Parse(created)
                };
                commentService.Comment(model);
                await this.Clients.All.SendAsync("Comment", userName, newsId, content, created);
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        [Authorize]
        public async Task Rate(string userName, string newsId, float rating)
        {
            try
            {
                var userModel = new UserViewModel()
                {
                    UserName = userName
                };
                userModel = userService.GetProfile(userModel);
                var newsModel = new NewsViewModel()
                {
                    NewsId = newsId
                };
                var userRating = ratingService.GetRatingByNews(newsModel).FirstOrDefault(x => x.UserId == userModel.Id);
                if (userRating == null)
                {
                    var ratingModel = new NewsRatingViewModel()
                    {
                        UserId = userModel.Id,
                        NewsId = newsId,
                        Rating = rating
                    };
                    ratingService.Rate(ratingModel);
                    await this.Clients.Caller.SendAsync("Rate", userName, newsId, rating);
                }
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }
    }
}
