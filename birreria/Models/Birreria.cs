using System;
namespace birreria.Models
{
    public class Birreria
    {
        public int id { get; set; }
        public string obdb_id { get; set; }
        public string name { get; set; }
        public string brewery_type { get; set; }
        public string street { get; set; }
        public object address_2 { get; set; }
        public object address_3 { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public object county_province { get; set; }
        public string postal_code { get; set; }
        public string country { get; set; }
        public string longitude { get; set; }
        public string latitude { get; set; }
        public string phone { get; set; }
        public string website_url { get; set; }
        public DateTime updated_at { get; set; }
        public DateTime created_at { get; set; }
    }
}
