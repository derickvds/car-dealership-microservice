using Cars.Client.Models;
using IdentityModel.Client;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Cars.Client.ApiServices
{
    public class CarApiService : ICarApiService
    {
        public Task<Car> CreateCar(Car car)
        {
            throw new NotImplementedException();
        }

        public Task DeleteCar(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Car> GetCar(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Car>> GetCars()
        {
            // Get token from Identity Server

            // 1. "retrieve" our api credentials. This must be registered on Identity Server!
            var apiClientCredentials = new ClientCredentialsTokenRequest
            {
                Address = "https://localhost:5005/connect/token",

                ClientId = "carClient",
                ClientSecret = "secret",

                // This is the scope our Protected API requires. 
                Scope = "carAPI"
            };

            // creates a new HttpClient to talk to our IdentityServer (localhost:5005)
            var client = new HttpClient();

            // just checks if we can reach the Discovery document. Not 100% needed but..
            var disco = await client.GetDiscoveryDocumentAsync("https://localhost:5005");
            if (disco.IsError)
            {
                return null; // throw 500 error
            }

            // 2. Authenticates and get an access token from Identity Server
            var tokenResponse = await client.RequestClientCredentialsTokenAsync(apiClientCredentials);
            if (tokenResponse.IsError)
            {
                return null;
            }

            // Another HttpClient for talking now with our Protected API
            var apiClient = new HttpClient();

            // 3. Set the access_token in the request Authorization: Bearer <token>
            client.SetBearerToken(tokenResponse.AccessToken);

            // 4. Send a request to our Protected API
            var response = await client.GetAsync("https://localhost:5001/api/cars");
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();

            List<Car> carList = JsonConvert.DeserializeObject<List<Car>>(content);
            return carList;
        }

        public Task<Car> UpdateCar(Car car)
        {
            throw new NotImplementedException();
        }
    }
}
