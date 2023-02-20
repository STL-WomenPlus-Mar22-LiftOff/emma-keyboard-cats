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
         public class Attributes
         {
             [JsonProperty("spayed_neutered")] public bool spayed_neutered { get; set; }
             [JsonProperty("house_trained")] public bool house_trained { get; set; }
             [JsonProperty("declawed")] public bool declawed { get; set; }
             [JsonProperty("special_needs")] public bool special_needs { get; set; }
             [JsonProperty("shots_current")] public bool shots_current { get; set; }
         }

         [System.Serializable]
         public class Environment
         {
             [JsonProperty("children")] public bool? children { get; set; }
             [JsonProperty("dogs")] public bool? dogs { get; set; }
             [JsonProperty("cats")] public bool? cats { get; set; }
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
         }

         







        /*

        private int Id { get; set; }
        private int organization_id { get; set; }
        public string url { get; set; } 
        public string breeds { get; set; }
        public string color { get; set; }
        public int age { get; set; }    
        public string gender { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string photos { get; set; }
        private string status { get; set; }
        public bool spayed_neutered { get; set; }
        public bool shot_current { get; set; }
        public bool children { get; set; }  
        public bool dogs { get; set; }
        public bool cats { get; set; }    
        public Contact contact { get; set; }
        public int distance { get; set; }   
        public string _links { get; set; }
        
    }
    public class Contact
    {
        public string email { get; set; }
        public int phone { get; set; }
        public string address { get; set; }

    }*/
    

