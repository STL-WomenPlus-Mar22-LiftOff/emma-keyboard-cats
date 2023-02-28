
using System;
using Keyboard_Cats.Models;

namespace keyboard_cats.models
{
    public class Adoptionprofile
    {

        public int Id { get; set; }

        public Cat? Cat { get; set; }


        public Adoptionprofile()
        {
        }
        public Adoptionprofile(int id, Cat cat)
        {
            Id = id;
            this.Cat = cat;

        }
    }