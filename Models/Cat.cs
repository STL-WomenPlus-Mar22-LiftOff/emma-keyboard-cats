using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Keyboard_Cats.Models
{

    [System.Serializable]
    public class Cat
    {

        [JsonProperty("animals")] private List<Animals> _animalsList;

        public List<Animals> AnimalsList
        {
            get { return _animalsList; }
        }


        [System.Serializable]
        public class Animals
        {
            [JsonProperty("id")] private int _id;
            [JsonProperty("name")] private string _name;
            [JsonProperty("description")] private string _description;
            [JsonProperty("photos")] private List<Photos> _photosList;
            [JsonProperty("contact")] private Contact _contact;


            public int Id
            {
                get { return _id; }
            }

            public string? Name
            {
                get { return _name; }
            }

            public string? Description
            {
                get { return _description; }
            }

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
            public List<Photos>? PhotosList
            {
                get { return _photosList; }
            }

            [System.Serializable]
            public class Photos
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
            public class Contact
            {
                [JsonProperty("email")] public string _email;
                [JsonProperty("phone")] public string _phone;
                [JsonProperty("address")] public string _address;

                public string Email
                {
                    get { return _email; }
                }

                public string Phone
                {
                    get { return _phone; }  
                }

                public string Address
                {
                    get { return _address; }
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
