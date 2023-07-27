using System;
using Entities;
using Services;

namespace RegistroAlunos // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher = new Teacher(1, "Alex");

            Student student1 = new Student(1, "Rogerinho");
            Student student2 = new Student(2, "Michael Jackson");
            Student student3 = new Student(3, "Zé Gotinha");
            Student student4 = new Student(4, "Ronei do Pneu");
            Student student5 = new Student(5, "Castanhari");

            Course cursoA = new Course("Gastronomia", teacher);
            Course cursoB = new Course("Enfermangem", teacher);
            Course cursoC = new Course("Odontologia", teacher);

            CourseService courseService = new CourseService();
            courseService.AddStudent(cursoA, student1);

            courseService.ListStudent(cursoA);
            //courseService.ListStudent(cursoB);
            //courseService.ListStudent(cursoC);

            //Console.WriteLine(student1);
        }
    }
}