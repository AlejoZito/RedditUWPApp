﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedditUWPApp.ViewModels
{
    public class MainPageViewModel
    {
        public MainPageViewModel()
        {
            RedditPosts = new ObservableCollection<RedditPostViewModel>();

            //Test data
            RedditPosts.Add(new RedditPostViewModel()
            {
                Title = "Title 1",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                ImageUri = "https://docs.microsoft.com/en-us/uwp/api/windows.ui.xaml.controls/images/controls/relativepanelbasic.png"
            });
            RedditPosts.Add(new RedditPostViewModel()
            {
                Title = "Title 2",
                Description = "Ut enim ad minim veniam",
                ImageUri = "https://docs.microsoft.com/en-us/uwp/api/windows.ui.xaml.controls/images/controls/relativepanelbasic.png"
            });
            RedditPosts.Add(new RedditPostViewModel()
            {
                Title = "Title 1",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                ImageUri = "https://docs.microsoft.com/en-us/uwp/api/windows.ui.xaml.controls/images/controls/relativepanelbasic.png"
            });
            RedditPosts.Add(new RedditPostViewModel()
            {
                Title = "Title 2",
                Description = "Ut enim ad minim veniam",
                ImageUri = "https://docs.microsoft.com/en-us/uwp/api/windows.ui.xaml.controls/images/controls/relativepanelbasic.png"
            });
            RedditPosts.Add(new RedditPostViewModel()
            {
                Title = "Title 1",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                ImageUri = "https://docs.microsoft.com/en-us/windows/uwp/design/basics/images/xaml-basics/margins.png"
            });
            RedditPosts.Add(new RedditPostViewModel()
            {
                Title = "Title 2",
                Description = "Ut enim ad minim veniam",
                ImageUri = "https://docs.microsoft.com/en-us/windows/uwp/design/basics/images/xaml-basics/margins.png"
            });
            RedditPosts.Add(new RedditPostViewModel()
            {
                Title = "Title 1",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                ImageUri = "https://docs.microsoft.com/en-us/windows/uwp/design/basics/images/xaml-basics/margins.png"
            });
            RedditPosts.Add(new RedditPostViewModel()
            {
                Title = "Title 2",
                Description = "Ut enim ad minim veniam",
                ImageUri = "https://docs.microsoft.com/en-us/uwp/api/windows.ui.xaml.controls/images/controls/relativepanelbasic.png"
            });
            RedditPosts.Add(new RedditPostViewModel()
            {
                Title = "Title 1",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                ImageUri = "https://docs.microsoft.com/en-us/uwp/api/windows.ui.xaml.controls/images/controls/relativepanelbasic.png"
            });
            RedditPosts.Add(new RedditPostViewModel()
            {
                Title = "Title 2",
                Description = "Ut enim ad minim veniam",
                ImageUri = "https://docs.microsoft.com/en-us/uwp/api/windows.ui.xaml.controls/images/controls/relativepanelbasic.png"
            });
            RedditPosts.Add(new RedditPostViewModel()
            {
                Title = "Title 1",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                ImageUri = "https://docs.microsoft.com/en-us/uwp/api/windows.ui.xaml.controls/images/controls/relativepanelbasic.png"
            });
            RedditPosts.Add(new RedditPostViewModel()
            {
                Title = "Title 2",
                Description = "Ut enim ad minim veniam",
                ImageUri = "https://docs.microsoft.com/en-us/uwp/api/windows.ui.xaml.controls/images/controls/relativepanelbasic.png"
            });
            RedditPosts.Add(new RedditPostViewModel()
            {
                Title = "Title 1",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                ImageUri = "https://docs.microsoft.com/en-us/uwp/api/windows.ui.xaml.controls/images/controls/relativepanelbasic.png"
            });
            RedditPosts.Add(new RedditPostViewModel()
            {
                Title = "Title 2",
                Description = "Ut enim ad minim veniam",
                ImageUri = "https://docs.microsoft.com/en-us/uwp/api/windows.ui.xaml.controls/images/controls/relativepanelbasic.png"
            });
            RedditPosts.Add(new RedditPostViewModel()
            {
                Title = "Title 1",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                ImageUri = "https://docs.microsoft.com/en-us/uwp/api/windows.ui.xaml.controls/images/controls/relativepanelbasic.png"
            });
            RedditPosts.Add(new RedditPostViewModel()
            {
                Title = "Title 2",
                Description = "Ut enim ad minim veniam",
                ImageUri = "https://docs.microsoft.com/en-us/uwp/api/windows.ui.xaml.controls/images/controls/relativepanelbasic.png"
            });
        }

        public ObservableCollection<RedditPostViewModel> RedditPosts { get; set; }
    }
}