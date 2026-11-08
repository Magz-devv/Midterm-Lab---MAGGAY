using System;
using System.Collections.Generic;

struct StudentRequest
{
    public string StudentNumber;
    public string StudentName;
    public string RequestType;
}

class Program
{
    static void Main()
    {
        Queue<StudentRequest> requestQueue =
            new Queue<StudentRequest>();

        int choice;

        do
        {
            Console.WriteLine("\n====================================");
            Console.WriteLine("       STUDENT REQUEST QUEUE");
            Console.WriteLine("====================================");
            Console.WriteLine("1. Add Request");
            Console.WriteLine("2. View Pending Requests");
            Console.WriteLine("3. Process Request");
            Console.WriteLine("4. Exit");
            Console.Write("Enter choice: ");

            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input!");
                continue;
            }

            switch (choice)
            {
                case 1:
                    StudentRequest request = new StudentRequest();

                    Console.Write("\nEnter Student Number: ");
                    request.StudentNumber = Console.ReadLine();

                    Console.Write("Enter Student Name: ");
                    request.StudentName = Console.ReadLine();

                    Console.Write("Enter Request Type: ");
                    request.RequestType = Console.ReadLine();

                    requestQueue.Enqueue(request);

                    Console.WriteLine("\nRequest added successfully!");
                    break;

                case 2:
                    if (requestQueue.Count == 0)
                    {
                        Console.WriteLine("\nNo pending requests.");
                    }
                    else
                    {
                        Console.WriteLine("\nREQUEST QUEUE");

                        int number = 1;

                        foreach (StudentRequest r in requestQueue)
                        {
                            Console.WriteLine(
                                number + ". " +
                                r.StudentName + " - " +
                                r.RequestType);

                            number++;
                        }
                    }
                    break;

                case 3:
                    if (requestQueue.Count == 0)
                    {
                        Console.WriteLine("\nNo pending requests to process.");
                    }
                    else
                    {
                        StudentRequest processed = requestQueue.Dequeue();

                        Console.WriteLine("\nProcessing Request: " +
                            processed.StudentName + " - " +
                            processed.RequestType);

                        Console.WriteLine("Request processed successfully!");
                    }
                    break;

                case 4:
                    Console.WriteLine("\nExiting program...");
                    break;

                default:
                    Console.WriteLine("\nInvalid choice! Try again.");
                    break;
            }

        } while (choice != 4);
    }
}
