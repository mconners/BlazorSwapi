using System;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Collections.Generic;
using System.Net.Http.Json;


namespace blazor.Data
{
    public class PeopleService
    {
        private static readonly string URL = @"https://swapi.dev/api/people/";

        public async Task<JsonWrapper> GetPeopleAsync(string url)
        {

            using HttpClient client = new()
            {
                BaseAddress = new Uri(URL)
            };

            if(string.IsNullOrEmpty(url)){
                url = URL;
            }

            // Get the user information.
            var jsonWrapper = await client.GetFromJsonAsync<JsonWrapper>(url);
            //var count = jsonWrapper.Count;
            
            //var people = jsonWrapper.Results;

          
            return jsonWrapper;

        }

     }
}
