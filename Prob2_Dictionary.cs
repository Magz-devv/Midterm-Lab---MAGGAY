using System;
using System.Collections.Generic;

namespace MidtermLab
{
    struct Student
    {
        public string StudentNumber;
        public string Name;
        public string Program;
        public int YearLevel;
    }

    class Problem2_Dictionary
    {
        static void Main()
        {
            Dictionary<string, Student> studentDictionary = new Dictionary<string, Student>();

            while (true)
            {
                Console.WriteLine("===================================");
                Console.WriteLine("   STUDENT LOOKUP USING DICTIONARY");
                Console.WriteLine("===================================");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Search Student");
                Console.WriteLine("3. Display All Students");
                Console.WriteLine("4. Exit");
                Console.Write("\nEnter choice: ");

                string choice = Console.ReadLine();
                Console.WriteLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter Student Number: ");
                        string studentNumber = Console.ReadLine();

                        if (studentDictionary.ContainsKey(studentNumber))
                        {
                            Console.WriteLine("\nError: Student Number already exists!\n");
                            break;
                        }

                        Student newStudent = new Student();
                        newStudent.StudentNumber = studentNumber;
                        Console.Write("Enter Name: ");
                        newStudent.Name = Console.ReadLine();
                        Console.Write("Enter Program: ");
                        newStudent.Program = Console.ReadLine();
                        Console.Write("Enter Year Level: ");
                        int.TryParse(Console.ReadLine(), out newStudent.YearLevel);

                        studentDictionary.Add(studentNumber, newStudent);
                        Console.WriteLine("\nStudent added successfully!\n");
                        break;

                    case "2":
                        Console.Write("Enter Student Number to search: ");
                        string searchKey = Console.ReadLine();

                        if (studentDictionary.TryGetValue(searchKey, out Student foundStudent))
                        {
                            Console.WriteLine("\nStudent Found!");
                            Console.WriteLine($"Student Number: {foundStudent.StudentNumber}");
                            Console.WriteLine($"Name: {foundStudent.Name}");
                            Console.WriteLine($"Program: {foundStudent.Program}");
                            Console.WriteLine($"Year Level: {foundStudent.YearLevel}\n");
                        }
                        else
                        {
                            Console.WriteLine("\nStudent not found.\n");
                        }
                        break;

                    case "3":
                        if (studentDictionary.Count == 0)
                        {
                            Console.WriteLine("No student records found.\n");
                            break;
                        }

                        Console.WriteLine("===================================");
                        Console.WriteLine("          ALL STUDENTS");
                        Console.WriteLine("===================================");
                        foreach (KeyValuePair<string, Student> kvp in studentDictionary)
                        {
                            Console.WriteLine($"Student Number: {kvp.Value.StudentNumber}");
                            Console.WriteLine($"Name: {kvp.Value.Name}");
                            Console.WriteLine($"Program: {kvp.Value.Program}");
                            Console.WriteLine($"Year Level: {kvp.Value.YearLevel}");
                            Console.WriteLine("-----------------------------------");
                        }
                        Console.WriteLine();
                        break;

                    case "4":
                        Console.WriteLine("Program exited.");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.\n");
                        break;
                }
            }
        }
    }
}
