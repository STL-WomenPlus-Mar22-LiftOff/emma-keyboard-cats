using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Keyboard_Cats.Models
{

    [System.Serializable]
    public class Cat
    {
        [JsonProperty("animals")] 
        private List<CatEntity> animals;

        public List<CatEntity> Animals
        {
            get { return animals; }
            set { animals = value; }
        }


        [System.Serializable]
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

            

            [System.Serializable]
            public class Attributes
            {
                [JsonProperty("spayed_neutered")] public bool _spayed_neutered;
                [JsonProperty("shots_current")] public bool _shots_current;

                public bool Spayed_neutered
                {
                    get { return _spayed_neutered; }
                }

                public bool Shots_current
                {
                    get { return _shots_current; }
                }
            }

            [System.Serializable]
            public class Environment
            {
                [JsonProperty("children")] public bool? _children;
                [JsonProperty("dogs")] public bool? _dogs;
                [JsonProperty("cats")] public bool? _cats;

                public bool? Children
                {
                    get { return _children; }
                }

                public bool? Dogs
                {
                    get { return _dogs; }
                }

                public bool? Cats
                {
                    get { return _cats; }   
                }
            }
            //public List<Photos>? PhotosList
            //{
                //get { return _photosList; }
            //}

            [System.Serializable]
            public class CatEntityPhotos
            {
                [JsonProperty("small")] private string _small;
                [JsonProperty("medium")] private string _medium;
                [JsonProperty("large")] private string _large;
                [JsonProperty("full")] private string _full;

                public string Small
                {
                    get { return _small; }
                }

                public string Medium
                {
                    get { return _medium; }
                }

                public string Large
                {
                    get { return _large; }
                }

                public string Full
                {
                    get { return _full; }
                }
            }
            [System.Serializable]
            public class CatEntityContact
            {
                [JsonProperty("email")] public string _email;
                [JsonProperty("phone")] public string _phone;
                [JsonProperty("address1")] public string _address1;

                public string Email
                {
                    get { return _email; }
                }

                public string Phone
                {
                    get { return _phone; }  
                }

                public string Address1
                {
                    get { return _address1; }
                }
            }
        }
    }
}

        /* [System.Serializable]
         public class Breeds
         {
             [JsonProperty("primary")] public string primary { get; set; }
             [JsonProperty("secondary")] public string secondary { get; set; }
             [JsonProperty("mixed")] public bool mixed { get; set; }
             [JsonProperty("unknown")] public bool unknown { get; set; }
         }

         [System.Serializable]
         public class Colors
         {
             [JsonProperty("primary")] public string primary { get; set; }
             [JsonProperty("secondary")] public string secondary { get; set; }
             [JsonProperty("tertiary")] public object tertiary { get; set; }
         }

         [System.Serializable]
         public class Primary_Photo_Cropped
         {
             [JsonProperty("small")] public string small;
             [JsonProperty("medium")] public string medium;
             [JsonProperty("large")] public string large;
             [JsonProperty("full")] public string full;

             public string Small
             {
                 get { return small; }

             }

             public string Medium
             {
                 get { return medium; }
             }

             public string Large
             {
                 get { return large; }
             }

             public string Full
             {
                 get { return full; }
             }
         }*/
