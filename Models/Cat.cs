using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Keyboard_Cats.Models
{

    [Serializable]
    public class Cat
    {
        [JsonProperty("animals")] 
        private List<CatEntity> animals;

        public List<CatEntity> Animals
        {
            get { return animals; }
            set { animals = value; }
        }


        [Serializable]
        public class CatEntity
        {
            [Key]
            [JsonProperty("id")] 
            public int Id { get; set; }
            
            [JsonProperty("name")] 
            public string Name { get; set; }
            
            [JsonProperty("description")] 
            public string Description { get; set; }
            
            [JsonProperty("photos")] 
            public List<CatEntityPhotos> Photos { get; set; }    
            
            [JsonProperty("contact")] 
            public CatEntityContact Contact { get; set; }


            [Serializable]
            public class Attributes
            {
                [JsonProperty("spayed_neutered")]
                public bool Spayed_neutered { get; set; }

                [JsonProperty("shots_current")]
                public bool Shots_current { get; set; }
                
            }

            [Serializable]
            public class Environment
            {
                [JsonProperty("children")]
                public bool? Children { get; set; }

                [JsonProperty("dogs")]
                public bool? Dogs { get; set; }

                [JsonProperty("cats")]
                public bool? Cats { get; set; }
                
            }
            //public List<Photos>? PhotosList
            //{
                //get { return _photosList; }
            //}

            [Serializable]
            public class CatEntityPhotos
            {
                [Key]
                public int PhotosId { get; set; }

                [JsonProperty("small")]
                public string Small { get; set; }   

                [JsonProperty("medium")]
                public string Medium { get; set; }  

                [JsonProperty("large")]
                public string Large { get; set; }

                [JsonProperty("full")] 
                public string Full { get; set; }
            }


            [Serializable]
            public class CatEntityContact
            {
                [Key] 
                public int ContactId { get; set; }

                [JsonProperty("email")]
                public string Email { get; set; }   

                [JsonProperty("phone")]
                public string Phone { get; set; }

                [JsonProperty("address1")] 
                public string Address1 { get; set; }
            }
        }
    }
}