using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedditUWPApp.DataAccess.DTO
{
    public class RedditApiResponseBaseDTO
    {
        public string Kind { get; set; }
        public RedditApiResponseDataDTO Data { get; set; }
    }

    public class RedditApiResponseDataDTO
    {
        public string After { get; set; }
        public int Dist { get; set; }
        public List<RedditApiPostWrapperDTO> Children { get; set; }
        public string Before { get; set; }
    }

    public class RedditApiPostWrapperDTO
    {
        public string Kind { get; set; }
        public RedditApiPostDTO Data { get; set; }
    }
}
