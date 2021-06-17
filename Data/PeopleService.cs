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

        public async Task<People[]> GetPeopleAsync(int page)
        {

            using HttpClient client = new()
            {
                BaseAddress = new Uri(URL)
            };

            // Get the user information.
            var jsonWrapper = await client.GetFromJsonAsync<JsonWrapper>(URL+"?&page="+page);
            
            var people = jsonWrapper.Results;

          
            return people.ToArray();

        }

     }
}
