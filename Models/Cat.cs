namespace Keyboard_Cats.Models
{
    public class Cat
    {
        private int Id { get; set; }
        private int OrganizationId { get; set; }
        public string URL { get; set; } 
        public string Breed { get; set; }
        public string Color { get; set; }
        public int Age { get; set; }    
        public string Gender { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Photos { get; set; }
        private string Status { get; set; }
        public bool Fixed { get; set; }
        public bool Shots { get; set; }
        public bool KidsOK { get; set; }  
        public bool DogsOK { get; set; }
        public bool CatsOK { get; set; }    
        public Contact Contact { get; set; }
        public int Distance { get; set; }   
        public string Links { get; set; }
        
    }
    public class Contact
    {
        public string Email { get; set; }
        public int Phone { get; set; }
        public string Address { get; set; }

    }
}
