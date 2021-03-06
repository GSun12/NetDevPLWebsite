﻿using System;
using System.Linq;
using Gmtl.HandyLib;
using Nancy;
using NetDevPL.Features.Facebook;
using NetDevPLWeb.Features.Shared;

namespace NetDevPLWeb.Features.Facebook
{
    public class FacebookPostsViewModel : BaseViewModel
    {
        public FacebookPostsViewModel(string pageName, HLListPage<FacebookPost> posts, Url url) : base(url)
        {
            Posts = posts;
            Title = pageName;
            Description = String.Join(" ", posts.Take(5).Select(p => p.Content));
        }

        public HLListPage<FacebookPost> Posts { get; set; }

        public int TopCurrentYear { get { return DateTime.Now.Year; } }
        public int LastMonth { get { return DateTime.Now.AddMonths(-1).Month; } }
        public int LastYear { get { return DateTime.Now.AddMonths(-1).Year; } }
    }
}