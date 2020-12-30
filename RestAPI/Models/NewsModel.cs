using System;
using System.Collections.Generic;
using System.Text;

namespace RestAPI.Models
{
    public class NewsModel
    {
        public string Status { get; set; }
        public int TotalResults { get; set; }
        public Article[] Articles { get; set; }
    }

    public class Article
    {
        public Source? Source { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public string UrlToImage { get; set; }
        public DateTime PublishedAt { get; set; }
        public string Content { get; set; }
    }

    public class Source
    {
        public object Id { get; set; }
        public string Name { get; set; }
    }

    public class DataBindingModel {
        public string Author { get; set; }
        public string Title { get; set; }
    }


    public class AllPropertiesModel
    {
       
        public string Author { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public string Content { get; set; }
        public DateTime PublishedAt { get; set; }
    }

    public class SearchModel
    {
        public string KeyWord { get; set; }
        public string Country { get; set; }
        public string Language { get; set; }
        public string Category { get; set; }
       
    }
}
