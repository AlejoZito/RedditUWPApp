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
        const int MAX_LIST_VALUE = 10;

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
            var apiClient = new RedditApiClient();

            string lastPost = "";
            if (RedditPosts != null && RedditPosts.Count > 0)
                lastPost = RedditPosts.Last().Name;

            //Get reddit posts starting from last post name (name=id)
            var redditPostsDTOs = await apiClient.GetRedditPosts(MAX_LIST_VALUE, lastPost);

            foreach(var redditPostDTO in redditPostsDTOs)
            {
                //Add items to UI list until MAX value is reached. To fetch new items, dismiss posts from UI.
                if(RedditPosts.Count < MAX_LIST_VALUE)
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

        public async Task Dismiss(RedditPostViewModel selectedItem)
        {
            if(RedditPosts.Contains(selectedItem))
                RedditPosts.Remove(selectedItem);

            //On Dismiss fetch new posts
            //NOTE: If item dismissed is the last item, the same post will come from the API everytime.
            await GetData();
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
