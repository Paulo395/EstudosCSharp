namespace Entities
{
    internal class Product
    {
        public string Name { get; set; }
        public double Value { get; set; }
 
        public Product(string name, double value)
        {
            Name = name;
            Value = value;
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || !(obj is Product))
            {
                return false;
            }

            Product other = obj as Product; //DownCasting de obj

            return Name.Equals(other.Name) && Value.Equals(other.Value);
        }
        public override int GetHashCode()
        {
            return Name.GetHashCode() + Value.GetHashCode(); //Camada de proteção para impedir colisão
        }
        public override string ToString()
        {
            return "Name: " + Name + "\n" +
                   "Value " + Value;
        }
    }
}
