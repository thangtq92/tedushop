﻿using AutoMapper;
using TeduShop.Model.Models;
using TeduShop.Web.Models;

namespace TeduShop.Web.Mappings
{
    public class AutoMapperConfiguraion
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<PostCategory, PostCategoryViewModel>();

                cfg.CreateMap<Post, PostViewModel>();

                cfg.CreateMap<PostTag, PostTagViewModel>();

                cfg.CreateMap<Tag, TagViewModel>();
            });
        }
    }
}