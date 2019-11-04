using Newtonsoft.Json;
using RedditUWPApp.DataAccess.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RedditUWPApp.DataAccess
{
    public class RedditApiClient : HttpClient
    {
        //ToDo replace
        const string GetRedditPostsUrl = "https://www.reddit.com/top.json?raw_json=1";

        public async Task<List<RedditApiPostWrapperDTO>> GetRedditPosts(int? limit = 0, string after = "")
        {
            string queryString = GetRedditPostsUrl;

            if (limit.HasValue && limit > 0)
                queryString += "&limit=" + limit;

            if (!string.IsNullOrEmpty(after))
                queryString += "&after=" + after;

            var response = await this.GetAsync(queryString);

            if (response.IsSuccessStatusCode)
            {
                try
                {
                    RedditApiResponseBaseDTO apiResponse = await response.Content.ReadAsAsync<RedditApiResponseBaseDTO>();

                    RedditApiResponseBaseDTO apiResponse2 =
                        JsonConvert.DeserializeObject<RedditApiResponseBaseDTO>(await response.Content.ReadAsStringAsync());

                    return apiResponse2.Data.Children;

                }
                catch (Exception ex)
                {

                }
            }
            return new List<RedditApiPostWrapperDTO>();
        }
    }
}
