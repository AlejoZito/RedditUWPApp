using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RedditUWPApp.DataAccess.DTO;

namespace RedditUWPApp.ViewModels
{
    public class RedditPostViewModel
    {
        private RedditApiPostWrapperDTO redditPostDTO;

        public RedditPostViewModel() { }

        public RedditPostViewModel(RedditApiPostWrapperDTO redditPostDTO)
        {
            MapFromApiResponse(redditPostDTO);
        }

        private void MapFromApiResponse(RedditApiPostWrapperDTO redditPostDTO)
        {
            Title = redditPostDTO.Data.Title;
            Description = redditPostDTO.Data.SelfText;

            if (IsImage(redditPostDTO.Data.Url))
                ImageUri = redditPostDTO.Data.Url;
            else
                ImageUri = "https://docs.microsoft.com/en-us/uwp/api/windows.ui.xaml.controls/images/controls/relativepanelbasic.png";
        }

        public string Description { get; set; }
        public string Title { get; set; }
        public string ImageUri { get; set; }

        public bool IsImage(string url)
        {
            if (!string.IsNullOrEmpty(url) & url.Length > 3)
                return url.Substring(url.Length - 3) == "jpg";
            else
                return false;
        }
    }
}
