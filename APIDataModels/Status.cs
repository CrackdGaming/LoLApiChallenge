using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIDataModels
{
    public class Shard
    {
        public string hostname { get; set; }
        public List<string> locales { get; set; }
        public string name { get; set; }
        public string region_tag { get; set; }
        public string slug { get; set; }
    }

    public class ShardStatus
    {
        public string hostname { get; set; }
        public List<string> locales { get; set; }
        public string name { get; set; }
        public string region_tag { get; set; }
        public List<Service> services { get; set; }
        public string slug { get; set; }
    }

    public class Service
    {
        public List<Incident> incidents { get; set; }
        public string name { get; set; }
        public string slug { get; set; }
        public string status { get; set; }
    }

    public class Incident
    {
        public bool active { get; set; }
        public string created_at { get; set; }
        public long id { get; set; }
        public List<Message> updates { get; set; }
    }

    public class Message
    {
        public string author { get; set; }
        public string content { get; set; }
        public string created_at { get; set; }
        public long id { get; set; }
        public string severity { get; set; }
        public List<Translation> translations { get; set; }
        public string updated_at { get; set; }
    }

    public class Translation
    {
        public string content { get; set; }
        public string locale { get; set; }
        public string updated_at { get; set; }
    }
}
