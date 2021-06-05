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
        private readonly IHttpClientFactory _httpClientFactory;

        public CarApiService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory ?? throw new ArgumentNullException(nameof(httpClientFactory));
        }

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
            var httpClient = _httpClientFactory.CreateClient("CarAPIClient");

            var request = new HttpRequestMessage(
                HttpMethod.Get,
                "/api/cars/");

            var response = await httpClient.SendAsync(
                request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false);

            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            var carList = JsonConvert.DeserializeObject<List<Car>>(content);
            return carList;
        }

        public Task<Car> UpdateCar(Car car)
        {
            throw new NotImplementedException();
        }
    }
}
