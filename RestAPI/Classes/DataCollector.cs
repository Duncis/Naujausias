using Newtonsoft.Json;
using RestAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RestAPI.Classes
{
    public class DataCollector
    {
        private readonly string  apiKey = "6d04798196304152a5ec79b72e7ae524";
        private readonly string  basicUrl = "http://newsapi.org/v2/top-headlines";
      

        public async Task<Tuple<List<AllPropertiesModel>,int>> GetAllProperties(SearchModel model)
        {

            using (var _client = new HttpClient())
            {
                

                
                var result = await _client.GetAsync(urlCreator(model));
                string resultContent = await result.Content.ReadAsStringAsync();
                var response = JsonConvert.DeserializeObject<NewsModel>(resultContent);
                if (response.Status == "ok" && response.TotalResults > 0)
                {
                    var list = response.Articles.ToList();
                    if(list.Any())
                    {


                        var properties = new List<AllPropertiesModel>();
/*                        foreach (var x in list) 
                        {
                            properties.Add(new AllPropertiesModel() { 
                            Author=x.Author,
                            Title = x.Title != null && x.Title.Length > 10 ? x.Title.Substring(0, 10) : "N/A",
                            });
                        } */
                        var propertiesList = list.Select(x => new AllPropertiesModel
                        {
                            Author = x.Author,
                            Title = x.Title != null && x.Title.Length > 10 ? x.Title.Substring(0,10) : "N/A",
                            Content = x.Content != null && x.Content.Length > 15 ? x.Content.Substring(0, 15) : "N/A",
                            Description = x.Description != null && x.Description.Length > 15 ? x.Description.Substring(0, 15) : "N/A",
                            Url = x.Url,
                            PublishedAt = x.PublishedAt
                            
                        }).ToList();
                        
                        return Tuple.Create(propertiesList, response.TotalResults);
                    }
                   
                }
                return Tuple.Create(new List<AllPropertiesModel>(),0);
            }
        }
        private string urlCreator(SearchModel model)
        {
            StringBuilder url = new StringBuilder(basicUrl);

            if (model.KeyWord != null)
            {
                url.Append("?q=" + model.KeyWord);
            }

            if (model.Country != null)
            {
                url.Append("?country=" + model.Country);
            }


            if (model.Language != null)
            {
                url.Append("?language=" + model.Language);
            }

            if (model.Category != null)
            {
                url.Append("?category=" + model.Category);
            }

            url.Append("&apiKey=" + apiKey);
            return url.ToString();
        }
    }
}
