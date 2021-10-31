using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

using LoginExample.Models;


namespace ToDo.Data
{
    public class CloudAdultService : IAdultService
    {
        private string uri = "https://localhost:5001";

        private readonly HttpClient client;

        public CloudAdultService()
        {

            client = new HttpClient();
        }

        public async Task<IList<Adult>> ReadAllAdults()
        {
            var stringAsync = await client.GetStringAsync(uri + "/Adult");
            IList<Adult> adults = JsonSerializer.Deserialize<IList<Adult>>(stringAsync, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });
            return adults;
        }

        public async Task AddAdult(Adult addAdult)
        {
            string adultAsJson = JsonSerializer.Serialize(addAdult);
            HttpContent content = new StringContent(adultAsJson,
                Encoding.UTF8,
                "application/json");
            await client.PostAsync(uri + "/Adult", content);
        }

        public async Task UpdateAdult(Adult updateAdult)
        {
            string adultAsJson = JsonSerializer.Serialize(updateAdult);
            HttpContent content = new StringContent(adultAsJson,
                Encoding.UTF8,
                "application/json");
            await client.PatchAsync($"{uri}/Adult/{updateAdult.id}", content);
        }

        public async Task DeleteAdult(int deleteAdult)
        {
            await client.DeleteAsync($"{uri}/Adult/{deleteAdult}");
        }
    }
}