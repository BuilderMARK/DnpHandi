using System;
using System.Net;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using LoginExample.Models;

namespace ToDo.Data
{
    public class CloudUserService : IUserService
    {
        public async Task<User> ValidateUser(string username, string password)
        {
            
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync($"https://localhost:5001/Users?username={username}&password={password}");
            if (response.StatusCode == HttpStatusCode.OK)
            {
                string userAsJson = await response.Content.ReadAsStringAsync();
                //gRUNDEN TIL DET JEG HAR VALGT AT BRUGE DET HER ER FORDI JEG VÆLGER AT SE BORT FRA, FRA STORE OG SMÅ BOGSTAVER, I FORHOLD TIL MIN uSER, OG MIN SWAGGER FIL. 
                User resultUser = JsonSerializer.Deserialize<User>(userAsJson,new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                    
                });
                return resultUser;
            } 
            throw new Exception("User not found");
        }
    }
}