using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace RedditUWPApp.DataAccess.DTO
{
    public class RedditApiPostDTO
    {
        /// <summary>
        /// Post ID
        /// </summary>
        public string Name { get; set; }

        public string SubReddit { get; set; }

        public string SelfText { get; set; }

        [JsonProperty("author_fullname")]
        public string AuthorFullName { get; set; }

        /// <summary>
        /// Username
        /// </summary>
        public string Author { get; set; }

        public string Title { get; set; }

        [JsonProperty("num_comments")]
        public int Comments { get; set; }

        /// <summary>
        /// Creation date in ? format
        /// </summary>
        public long Created { get; set; }

        public string Url { get; set; }

        public PreviewDTO Preview { get; set; }
    }

    public class PreviewDTO
    {
        public List<ImageDTO> Images { get; set; }
    }

    public class ImageDTO
    {
        public SourceDTO Source { get; set; }
    }

    public class SourceDTO
    {
        public string Url { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        //ToDo mapping
        //public Resolution Resolutions
    }
}
