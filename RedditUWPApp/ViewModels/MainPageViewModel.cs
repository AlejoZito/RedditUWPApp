using RedditUWPApp.DataAccess;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedditUWPApp.ViewModels
{
    public class MainPageViewModel : ViewModel
    {
        public MainPageViewModel()
        {
            RedditPosts = new ObservableCollection<RedditPostViewModel>();

            //Test data
            //RedditPosts.Add(new RedditPostViewModel()
            //{
            //    Title = "Title 1",
            //    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
            //    ImageUri = "https://docs.microsoft.com/en-us/uwp/api/windows.ui.xaml.controls/images/controls/relativepanelbasic.png"
            //});
        }

        public async Task GetData()
        {
            //ToDo add Akavache Caching
            //ToDo Pagination based on last item of current list
            var apiClient = new RedditApiClient();
            var redditPostsDTOs = await apiClient.GetRedditPosts(10);

            foreach(var redditPostDTO in redditPostsDTOs)
            {
                RedditPosts.Add(new RedditPostViewModel(redditPostDTO));
            }
        }

        public void SelectPost(RedditPostViewModel selectedItem)
        {
            //Only set property if new item was selected
            if(selectedItem != null)
            {
                if (SelectedPost != selectedItem)
                    SelectedPost = selectedItem;

                SelectedPost.MarkAsRead();
            }
        }

        public ObservableCollection<RedditPostViewModel> RedditPosts { get; set; }

        public void Dismiss(RedditPostViewModel selectedItem)
        {
            if(RedditPosts.Contains(selectedItem))
            RedditPosts.Remove(selectedItem);
        }

        RedditPostViewModel _SelectedPost;
        public RedditPostViewModel SelectedPost
        {
            get { return _SelectedPost; }
            set
            {
                _SelectedPost = value;
                OnPropertyChanged(nameof(SelectedPost));
            }
        }
    }
}
