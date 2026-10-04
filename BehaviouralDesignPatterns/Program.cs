
using BehaviouralDesignPatterns.ChainOfResponsibility;

namespace BehaviouralDesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                Console.WriteLine("==============================================");
                Console.WriteLine("       BEHAVIOURAL DESIGN PATTERNS");
                Console.WriteLine("==============================================");
                Console.WriteLine("1. Chain of Responsibility");

                Console.WriteLine("0. Exit");
                Console.WriteLine("==============================================");

                Console.Write("Enter your choice: ");
                string? choice = Console.ReadLine();

                Console.WriteLine();

                switch (choice)
                {
                    case "1":
                        ChainOfResponsibilityDemo();
                        break;

                    case "0":
                        Console.WriteLine("Application closed.");
                        return;

                    default:
                        Console.WriteLine("Invalid choice.");
                        Pause();
                        break;
                }
            }
        }

        static void ChainOfResponsibilityDemo()
        {
            Console.WriteLine("==============================================");
            Console.WriteLine("       CHAIN OF RESPONSIBILITY PATTERN");
            Console.WriteLine("==============================================");

            ILeaveHandler teamLead = new TeamLeadHandler();
            ILeaveHandler manager = new ManagerHandler();
            ILeaveHandler director = new DirectorHandler();

            teamLead.SetNext(manager);
            manager.SetNext(director);

            Console.Write("Enter number of leave days: ");

            if (int.TryParse(Console.ReadLine(), out int days))
            {
                teamLead.HandleLeaveRequest(days);
            }
            else
            {
                Console.WriteLine("Invalid number.");
            }

            Pause();
        }

        // Helper method to pause the console and wait for user input
        static void Pause()
        {
            Console.WriteLine();
            Console.WriteLine("Press ENTER to continue...");
            Console.ReadLine();
        }
    }
}
