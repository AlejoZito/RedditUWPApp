using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RedditUWPApp.DataAccess.DTO;
using Windows.UI.Xaml.Media;

namespace RedditUWPApp.ViewModels
{
    public class RedditPostViewModel : ViewModel
    {
        public RedditPostViewModel() { }

        public RedditPostViewModel(RedditApiPostWrapperDTO redditPostDTO)
        {
            MapFromApiResponse(redditPostDTO);
        }

        private void MapFromApiResponse(RedditApiPostWrapperDTO redditPostDTO)
        {
            Title = redditPostDTO.Data.Title;
            Description = redditPostDTO.Data.SelfText;
            Read = false;

            if (IsImage(redditPostDTO.Data.Url))
                ImageUri = redditPostDTO.Data.Url;
            else
                //ToDo: use locally stored img
                ImageUri = "https://external-preview.redd.it/QJRqGgkUjhGSdu3vfpckrvg1UKzZOqX2BbglcLhjS70.png?auto=webp&s=c681ae9c9b5021d81b6c4e3a2830f09eff2368b5";

            CommentNumber = redditPostDTO.Data.Comments;
            User = redditPostDTO.Data.AuthorFullName;
            _CreatedDateTime = DateTime.FromFileTimeUtc(redditPostDTO.Data.Created);
        }

        public string Description { get; set; }
        public string Title { get; set; }
        public string ImageUri { get; set; }
        public string User { get; set; }

        public int CommentNumber { get; set; }

        //ToDo: Should use CONVERTER in xaml
        public string CommentNumberString
        {
            get { return CommentNumber + " Comments"; }
        }

        DateTime _CreatedDateTime;

        public string CreatedDateTimeString
        {
            get
            {
                return (DateTime.Now - _CreatedDateTime).Hours + "hours ago";
            }
        }

        bool _Read;
        public bool Read
        {
            get { return _Read; }
            set
            {
                _Read = value;
                OnPropertyChanged(nameof(Read));
                OnPropertyChanged(nameof(ReadColor));
            }
        }

        //ToDo should set and handle color change on xaml with converter
        public string ReadColor
        {

            get
            {
                if (!Read)
                    return "#ee295b";
                else
                    return "#828585";
            }
            set { } //Required for double binding to work. ToDo: Improve
        }


        public bool IsImage(string url)
        {
            List<string> validImageExtensions = new List<string>() { "jpg", "png", "gif" };

            if (!string.IsNullOrEmpty(url) & url.Length > 3)
                return validImageExtensions.Contains(url.Substring(url.Length - 3));
            else
                return false;
        }

        public void MarkAsRead()
        {
            Read = true;
        }
    }
}
