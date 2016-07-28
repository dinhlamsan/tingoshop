using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TiNgoShop.Model.Models;
using TiNgoShop.Web.Models;

namespace TiNgoShop.Web.Mappings
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.CreateMap<Post, PostViewModel>();
            Mapper.CreateMap<PostCategory, PostCategoryViewModel>();
            Mapper.CreateMap<Tag, TagViewModel>();
        }
    }
}