using BehaviouralDesignPatterns.ChainOfResponsibility;
using BehaviouralDesignPatterns.Command;
using BehaviouralDesignPatterns.Interpreter;
using BehaviouralDesignPatterns.Iterator;
using BehaviouralDesignPatterns.Mediator;
using BehaviouralDesignPatterns.Memento;
using BehaviouralDesignPatterns.Observer;
using BehaviouralDesignPatterns.State;
using BehaviouralDesignPatterns.Strategy;
using BehaviouralDesignPatterns.TemplateMethod;
using BehaviouralDesignPatterns.Visitor;
using System.Text;

namespace BehaviouralDesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                Console.OutputEncoding = Encoding.UTF8;

                Console.WriteLine("==============================================");
                Console.WriteLine("       BEHAVIOURAL DESIGN PATTERNS");
                Console.WriteLine("==============================================");
                Console.WriteLine("1. Chain of Responsibility");
                Console.WriteLine("2. Command");
                Console.WriteLine("3. Interpreter");
                Console.WriteLine("4. Iterator");
                Console.WriteLine("5. Mediator");
                Console.WriteLine("6. Memento");
                Console.WriteLine("7. Observer");
                Console.WriteLine("8. State");
                Console.WriteLine("9. Strategy");
                Console.WriteLine("10. Template Method");
                Console.WriteLine("11. Visitor");
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

                    case "5":
                        MediatorDemo();
                        break;

                    case "6":
                        MementoDemo();
                        break;
                        
                    case "7":
                        ObserverDemo();
                        break;

                    case "8":
                        StateDemo();
                        break;

                    case "9":
                        StrategyDemo();
                        break;

                    case "10":
                        TemplateMethodDemo();
                        break;

                    case "11":
                        VisitorDemo();
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

        static void MediatorDemo()
        {
            Console.WriteLine("==============================================");
            Console.WriteLine("             MEDIATOR PATTERN");
            Console.WriteLine("==============================================");

            IChatMediator mediator = new ChatMediator();

            User john = new User("John", mediator);

            User david = new User("David", mediator);

            User michael = new User("Michael", mediator);

            mediator.RegisterUser(john);
            mediator.RegisterUser(david);
            mediator.RegisterUser(michael);

            john.SendMessage("Hello everyone!");

            Console.WriteLine();

            david.SendMessage("Hello John!");

            Pause();
        }

        static void MementoDemo()
        {
            Console.WriteLine("==============================================");
            Console.WriteLine("             MEMENTO PATTERN");
            Console.WriteLine("==============================================");

            TextEditor editor = new TextEditor();

            editor.Write("Hello");

            Console.WriteLine($"Current Content: {editor.Content}");

            EditorMemento savedState = editor.Save();

            editor.Write(" World");

            Console.WriteLine($"After Modification: {editor.Content}");

            editor.Restore(savedState);

            Console.WriteLine($"After Restore: {editor.Content}");

            Pause();
        }

        static void ObserverDemo()
        {
            Console.WriteLine("==============================================");
            Console.WriteLine("             OBSERVER PATTERN");
            Console.WriteLine("==============================================");

            NotificationService notificationService = new NotificationService();

            IObserver emailSubscriber = new EmailSubscriber();

            IObserver smsSubscriber = new SmsSubscriber();

            notificationService.Subscribe(emailSubscriber);
            notificationService.Subscribe(smsSubscriber);

            notificationService.Notify("Your order #1001 has been shipped.");

            Console.WriteLine();

            Console.WriteLine("Removing SMS subscriber...");

            notificationService.Unsubscribe(smsSubscriber);

            notificationService.Notify("Your order #1002 has been delivered.");

            Pause();
        }

        static void StateDemo()
        {
            Console.WriteLine("==============================================");
            Console.WriteLine("               STATE PATTERN");
            Console.WriteLine("==============================================");

            OrderContext order = new OrderContext();

            Console.WriteLine("Processing order...");

            order.Process();

            Console.WriteLine();

            order.Process();

            Console.WriteLine();

            order.Process();

            Console.WriteLine();

            order.Process();

            Pause();
        }

        static void StrategyDemo()
        {
            Console.WriteLine("==============================================");
            Console.WriteLine("             STRATEGY PATTERN");
            Console.WriteLine("==============================================");

            Console.WriteLine("1. UPI");
            Console.WriteLine("2. Credit Card");
            Console.WriteLine("3. PayPal");

            Console.Write("Select payment method: ");

            string? choice = Console.ReadLine();

            IPaymentStrategy? strategy = choice switch
            {
                "1" => new UpiPayment(),

                "2" => new CreditCardPayment(),

                "3" => new PayPalPayment(),

                _ => null
            };

            if (strategy == null)
            {
                Console.WriteLine("Invalid payment option.");
                Pause();
                return;
            }

            PaymentContext paymentContext = new PaymentContext(strategy);

            paymentContext.ProcessPayment(5000);

            Pause();
        }

        static void TemplateMethodDemo()
        {
            Console.WriteLine("==============================================");
            Console.WriteLine("          TEMPLATE METHOD PATTERN");
            Console.WriteLine("==============================================");

            Console.WriteLine("ONLINE ORDER");
            Console.WriteLine("----------------------------------------------");

            OrderProcessor onlineOrder = new OnlineOrderProcessor();

            onlineOrder.ProcessOrder();

            Console.WriteLine();

            Console.WriteLine("CASH ON DELIVERY ORDER");
            Console.WriteLine("----------------------------------------------");

            OrderProcessor codOrder = new CashOnDeliveryProcessor();

            codOrder.ProcessOrder();

            Pause();
        }

        static void VisitorDemo()
        {
            Console.WriteLine("==============================================");
            Console.WriteLine("              VISITOR PATTERN");
            Console.WriteLine("==============================================");

            List<IEntity> entities = new List<IEntity>
            {
                new Employee("John"),
                new Customer("David")
            };

            IVisitor reportVisitor = new ReportVisitor();

            Console.WriteLine("Generating Reports:");
            Console.WriteLine("----------------------------------------------");

            foreach (IEntity entity in entities)
            {
                entity.Accept(reportVisitor);
            }

            Console.WriteLine();

            IVisitor taxVisitor = new TaxVisitor();

            Console.WriteLine("Calculating Tax:");
            Console.WriteLine("----------------------------------------------");

            foreach (IEntity entity in entities)
            {
                entity.Accept(taxVisitor);
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
