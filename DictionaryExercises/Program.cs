using System;

namespace DictionaryExercises
{
    class Program
    { 

        static void Main(string[] args)
        {
            //Make a program that does the following:

            //Takes in student names and ID numbers.
            Dictionary<int, string> students = new Dictionary<int, string>();
            string newStudent;
     Console.WriteLine("Enter your students names & ID numbers (or ENTER to finish): ");
do
            {
                Console.WriteLine("Student name: ");
                newStudent = Console.ReadLine();

                if (newStudent != " ")
                {
                    Console.WriteLine("ID: ");
                    int newID = int.Parse(Console.ReadLine());
                    students.Add(newID, newStudent);
                }
            }
            while (newStudent != " ");


            Console.WriteLine("Student name: ");
            newStudent = Console.ReadLine();

            if (newStudent != " ")
            {
                Console.WriteLine("ID: ");
                int newID = int.Parse(Console.ReadLine());
                students.Add(newID, newStudent);
            }
            //Print out roster:
            Console.WriteLine("\nClass roster:");

            foreach(KeyValuePair<int, string> student in students)
            {
                Console.WriteLine(student.Value + "'s ID: " + student.Key);
            }
            Console.WriteLine("Number of students in roster: " + students.Count);
        }
    }
}
