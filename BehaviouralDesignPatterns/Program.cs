using BehaviouralDesignPatterns.ChainOfResponsibility;
using BehaviouralDesignPatterns.Command;
using BehaviouralDesignPatterns.Interpreter;
using BehaviouralDesignPatterns.Iterator;

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
                Console.WriteLine("2. Command");
                Console.WriteLine("3. Interpreter");
                Console.WriteLine("4. Iterator");

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

                    case "2":
                        CommandDemo();
                        break;

                    case "3":
                        InterpreterDemo();
                        break;

                    case "4":
                        IteratorDemo();
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

        static void CommandDemo()
        {
            Console.WriteLine("==============================================");
            Console.WriteLine("             COMMAND PATTERN");
            Console.WriteLine("==============================================");

            Light light = new Light();

            ICommand turnOnCommand = new TurnOnCommand(light);
            ICommand turnOffCommand = new TurnOffCommand(light);

            RemoteControl remote = new RemoteControl();

            Console.WriteLine("Executing Turn ON command...");
            remote.SetCommand(turnOnCommand);
            remote.PressButton();

            Console.WriteLine();

            Console.WriteLine("Executing Turn OFF command...");
            remote.SetCommand(turnOffCommand);
            remote.PressButton();

            Console.WriteLine();

            Console.WriteLine("Executing Undo...");
            remote.PressUndo();

            Pause();
        }

        static void InterpreterDemo()
        {
            Console.WriteLine("==============================================");
            Console.WriteLine("           INTERPRETER PATTERN");
            Console.WriteLine("==============================================");

            IExpression adminExpression = new TerminalExpression("Admin");

            IExpression managerExpression = new TerminalExpression("Manager");

            IExpression andExpression = new AndExpression(adminExpression, managerExpression);

            string context = "Admin Manager";

            Console.WriteLine($"Context: {context}");
            Console.WriteLine("Expression: Admin AND Manager AND Director");

            Console.WriteLine($"Result: {andExpression.Interpret(context)}");

            Console.WriteLine();

            IExpression orExpression = new OrExpression(adminExpression, managerExpression);

            context = "Admin1";

            Console.WriteLine($"Context: {context}");
            Console.WriteLine("Expression: Admin OR Manager");

            Console.WriteLine($"Result: {orExpression.Interpret(context)}");

            Pause();
        }

        static void IteratorDemo()
        {
            Console.WriteLine("==============================================");
            Console.WriteLine("             ITERATOR PATTERN");
            Console.WriteLine("==============================================");

            EmployeeCollection employees = new EmployeeCollection();

            Console.WriteLine("Employees:");

            foreach (string employee in employees)
            {
                Console.WriteLine($"- {employee}");
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
