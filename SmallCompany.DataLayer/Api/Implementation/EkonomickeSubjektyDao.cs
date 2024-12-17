﻿using SmallCompany.Models.Api.ApiRequestModel;
using SmallCompany.Models.Api.ApiResponseModel;
using System.Text;
using System.Text.Json;

namespace SmallCompany.DataLayer.Api.Implementation
{
    public class EkonomickeSubjektyDao : IEkonomickeSubjektyDao
    {
        private const string apiUrlKomplexFiltr = "https://ares.gov.cz/ekonomicke-subjekty-v-be/rest/ekonomicke-subjekty/vyhledat";
        private const string apiUrlOneSubject = "https://ares.gov.cz/ekonomicke-subjekty-v-be/rest/ekonomicke-subjekty";

        public async Task<EkonomickySubjekt> GetOneSubjectAsync(string ico)
        {
            HttpClient client = new HttpClient();

            JsonSerializerOptions deserialiezerOptions = new JsonSerializerOptions()
            {
                PropertyNameCaseInsensitive = true,
            };

            string requestUrl = $"{apiUrlOneSubject}/{ico}";

            HttpResponseMessage response = await client.GetAsync(requestUrl);
            response.EnsureSuccessStatusCode();

            string responseBody = await response.Content.ReadAsStringAsync();

            EkonomickySubjekt? subject = new EkonomickySubjekt();
            subject = JsonSerializer.Deserialize<EkonomickySubjekt>(responseBody, deserialiezerOptions);

            return subject;

        }


        public async Task<EkonomickeSubjektySeznam> GetListOfSubjects(EkonomickeSubjektyKomplexFiltr komplexFiltr)
        {
            HttpClient client = new HttpClient();

            JsonSerializerOptions serializerOptions = new JsonSerializerOptions()
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            };
            JsonSerializerOptions deserializierOptions = new JsonSerializerOptions()
            {
                PropertyNameCaseInsensitive = true,
            };

            string jsonContent = JsonSerializer.Serialize(komplexFiltr, serializerOptions);
            StringContent content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await client.PostAsync(apiUrlKomplexFiltr, content);
            response.EnsureSuccessStatusCode();

            string responseBody = await response.Content.ReadAsStringAsync();

            EkonomickeSubjektySeznam? ekonomickeSubjektySeznam = new EkonomickeSubjektySeznam();
            ekonomickeSubjektySeznam = JsonSerializer.Deserialize<EkonomickeSubjektySeznam>(responseBody, deserializierOptions);

            return ekonomickeSubjektySeznam;

        }
    }
}
