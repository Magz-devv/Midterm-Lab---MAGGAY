using System;
using System.Collections.Generic;

namespace MidtermLab
{
    struct Operation
    {
        public string Action;
        public string StudentNumber;
        public string StudentName;
    }

    class Problem4_Stack
    {
        static void Main()
        {
            Stack<Operation> operationHistory = new Stack<Operation>();

            
            operationHistory.Push(new Operation { Action = "Added", StudentName = "Juan" });
            operationHistory.Push(new Operation { Action = "Added", StudentName = "Maria" });
            operationHistory.Push(new Operation { Action = "Updated", StudentName = "Juan" });
            operationHistory.Push(new Operation { Action = "Deleted", StudentName = "Pedro" });

            while (true)
            {
                Console.WriteLine("===================================");
                Console.WriteLine("         OPERATION HISTORY");
                Console.WriteLine("===================================");
                Console.WriteLine("1. View Operation History");
                Console.WriteLine("2. View Last Operation");
                Console.WriteLine("3. Remove Last Operation");
                Console.WriteLine("4. Exit");
                Console.Write("\nEnter choice: ");

                string choice = Console.ReadLine();
                Console.WriteLine();

                switch (choice)
                {
                    case "1":
                        if (operationHistory.Count == 0)
                        {
                            Console.WriteLine("No recorded operations found.\n");
                            break;
                        }

                        Console.WriteLine("OPERATION HISTORY\n");
                        Operation[] historyArray = operationHistory.ToArray();
                        for (int i = 0; i < historyArray.Length; i++)
                        {
                            Console.WriteLine($"{i + 1}. {historyArray[i].Action} {historyArray[i].StudentName}");
                        }
                        Console.WriteLine();
                        break;

                    case "2":
                        if (operationHistory.Count == 0)
                        {
                            Console.WriteLine("No recorded operations found.\n");
                            break;
                        }

                        Operation lastOp = operationHistory.Peek();
                        Console.WriteLine($"Last Operation: {lastOp.Action} {lastOp.StudentName}\n");
                        break;

                    case "3":
                        if (operationHistory.Count == 0)
                        {
                            Console.WriteLine("No recorded operations found.\n");
                            break;
                        }

                        operationHistory.Pop();
                        Console.WriteLine("Last operation removed successfully!\n");
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
