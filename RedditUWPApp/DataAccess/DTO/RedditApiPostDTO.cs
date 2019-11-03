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

        /// <summary>
        /// ImageUrl if finished in "jpeg"?
        /// </summary>
        public string Url { get; set; }
    }
}
