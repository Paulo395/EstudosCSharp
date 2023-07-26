using Entities;

namespace Entities
{
    internal class Teacher : User
    {
        public Teacher(int id, string name) : base(id, name)
        {
        }

        public override string ToString()
        {
            return "Id: " + Id + "\n" +
                   "Name: " + Name + "\n";
        }
    }
}
