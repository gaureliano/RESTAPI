using RESTAPI.Hypermedia;
using RESTAPI.Hypermedia.Abstract;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace RESTAPI.Data.VO
{

    public class PersonVO  : ISupportHyperMedia
    {
        
        public long Id { get; set; }

        public string FirstName { get; set;  }
        
        public string LastName { get; set; }
        
        public string Address { get; set; }
     
        public string Gender { get; set; }

        public bool Enabled { get; set; }
        public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>();
    }
}
