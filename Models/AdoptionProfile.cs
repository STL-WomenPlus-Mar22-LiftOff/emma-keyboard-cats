namespace Keyboard_Cats.Models
{
    public class AdoptionProfile 
    {
        public Cat Cat { get; set; }    
        public string Name { get; set; }
        public string Description { get; set; }
        public int Age { get; set; }
   
        //etc etc? 
    }

    
}
//should this be in here ?

    /*public int Id { get; }
    static private int nextId = 1;

    public Cat(string name, string description, int age)
    {
        Name = name;
        Description = description;
        Age = age;
        Id = nextId;
        nextId++;
    }

    public override string ToString()
    {
        return Name;
    }

    public override bool Equals(object obj)
    {
        return obj is Cat @cat &&
               Id == @cat.Id;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Id);
    }*/
