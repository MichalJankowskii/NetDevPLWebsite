﻿using System;
using System.Collections.Generic;
using System.Linq;
using Nancy;
using NetDevPL.Features.Blogs;
using NetDevPLWeb.Features.Shared;

namespace NetDevPLWeb.Features.Blogs
{
    public class BlogsViewModel : BaseViewModel
    {
        public BlogsViewModel(BlogDataSnapshot snapshot, Url url) : base(url)
        {
            BlogsList = snapshot.Blogs ?? Enumerable.Empty<Blog>();
            LastUpdate = snapshot.SnapshotDate;
        }

        public IEnumerable<Blog> BlogsList { get; private set; }
        public DateTime LastUpdate { get; set; }
    }
}