using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using ITNews.Data.Contracts.Entities;
using ITNews.Domain.Contracts.ViewModels;

namespace ITNews.Infrastructure
{
    public class ITNewsWebProfile: Profile
    {
        public ITNewsWebProfile()
        {
            CreateMap<CommentEntity, CommentViewModel>();
            CreateMap<CommentViewModel, CommentEntity>();

            CreateMap<CommentLikeEntity, CommentLikeViewModel>();
            CreateMap<CommentLikeViewModel, CommentLikeEntity>();

            CreateMap<NewsEntity, NewsViewModel>();
            CreateMap<NewsViewModel, NewsEntity>();

            CreateMap<NewsTagEntity, NewsTagViewModel>();
            CreateMap<NewsTagViewModel, NewsTagEntity>();

            CreateMap<NewsRatingEntity, NewsRatingViewModel>();
            CreateMap<NewsRatingViewModel, NewsRatingEntity>();

            CreateMap<SectionEntity, SectionViewModel>();
            CreateMap<SectionViewModel, SectionEntity>();

            CreateMap<TagEntity, TagViewModel>();
            CreateMap<TagViewModel, TagEntity>();

            CreateMap<UserEntity, UserViewModel>()
                .ForMember(d => d.Id, m => m.MapFrom(s => s.Id))
                .ForMember(d => d.Email, m => m.MapFrom(s => s.Email))
                .ForMember(d => d.EmailConfirmed, m => m.MapFrom(s => s.EmailConfirmed))
                .ForMember(d => d.UserName, m => m.MapFrom(s => s.UserName))
                .ForMember(d => d.FirstName, m => m.MapFrom(s => s.FirstName))
                .ForMember(d => d.LastName, m => m.MapFrom(s => s.LastName))
                .ForMember(d => d.Description, m => m.MapFrom(s => s.Description))
                .ForMember(d => d.Birthdate, m => m.MapFrom(s => s.Birthdate))
                .ForMember(d => d.PasswordHash, m => m.MapFrom(s => s.PasswordHash))
                .ForMember(d => d.News, m => m.MapFrom(s => s.News))
                .ForMember(d => d.Comments, m => m.MapFrom(s => s.Comments))
                .ForMember(d => d.Ratings, m => m.MapFrom(s => s.Ratings))
                .ForMember(d => d.Likes, m => m.MapFrom(s => s.Likes))
                .ForMember(d => d.SecurityStamp, m => m.MapFrom(s => s.SecurityStamp))
                .ForMember(d => d.LockoutEnd, m => m.MapFrom(s => s.LockoutEnd))
                .ForAllOtherMembers(m => m.Ignore());

            CreateMap<UserViewModel, UserEntity>()
                .ForMember(d => d.Id, m => m.MapFrom(s => s.Id))
                .ForMember(d => d.Email, m => m.MapFrom(s => s.Email))
                .ForMember(d => d.EmailConfirmed, m => m.MapFrom(s => s.EmailConfirmed))
                .ForMember(d => d.UserName, m => m.MapFrom(s => s.UserName))
                .ForMember(d => d.FirstName, m => m.MapFrom(s => s.FirstName))
                .ForMember(d => d.LastName, m => m.MapFrom(s => s.LastName))
                .ForMember(d => d.Description, m => m.MapFrom(s => s.Description))
                .ForMember(d => d.Birthdate, m => m.MapFrom(s => s.Birthdate))
                //.ForMember(d => d.PasswordHash, m => m.MapFrom(s => s.PasswordHash))
                //.ForMember(d => d.News, m => m.MapFrom(s => s.News))
                //.ForMember(d => d.Comments, m => m.MapFrom(s => s.Comments))
                //.ForMember(d => d.Ratings, m => m.MapFrom(s => s.Ratings))
                //.ForMember(d => d.Likes, m => m.MapFrom(s => s.Likes))
                //.ForMember(d => d.SecurityStamp, m => m.MapFrom(s => s.SecurityStamp))
                .ForMember(d => d.LockoutEnd, m => m.MapFrom(s => s.LockoutEnd))
                .ForAllOtherMembers(m => m.Ignore());
        }
    }
}
