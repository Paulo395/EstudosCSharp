using Entities;

namespace Entities
{
    internal class Student : User
    {
        public Student(int id, string name) : base(id, name)
        {
        }

        public override string ToString()
        {
            return "Id: " + Id + "\n" +
                   "Name: " + Name;
        }
    }
}
