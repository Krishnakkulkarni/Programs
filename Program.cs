//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
//     Company @ 2018 </copyright>
// <creator name = "Krishna Kulkarni" />
//-----------------------------------------------------------------------
namespace DesignPattern
{
    using System;

/// <summary>
/// Entry point of the program
/// </summary>
public class Program
{
    /// <summary>
    /// Defines the entry point of the application.
    /// </summary>
    /// <param name="args">The arguments.</param>
    public static void Main(string[] args)
    {
        try
        {
            int choice;
            string ans;
            Console.WriteLine("***** Object Oriented Programs *****");
            /* iteration for showing the details of the program.*/
            do
            {
                Console.WriteLine("1. Singleton Link");
                Console.WriteLine("2. Factory Pattern");
                Console.WriteLine("3. Prototype design pattern");
                Console.WriteLine("4. Adapter design pattern");
                Console.WriteLine("5. Facade design pattern");
                Console.WriteLine("6. Proxy design pattern");
                Console.WriteLine("7. Observer design pattern");
                Console.WriteLine("8. Visitor pattern");
                Console.WriteLine("9. Mediator Design Pattern");
                Console.WriteLine("10. Annotation");
                Console.WriteLine("Enter your choice : ");
                choice = Convert.ToInt32(Console.ReadLine());
                /*iteration for matching the perticular choice*/
                switch (choice)
                {
                    case 0:
                        Environment.Exit(0);
                        break;
                    case 1:
                            CreationalDesignPattern.SingletonLink.SingletonClass.SingletonMain();
                        break;
                    case 2:
                        CreationalDesignPattern.FactoryPattern.FactoryDemo.FactoryMain();
                        break;
                    case 3:
                            CreationalDesignPattern.Prototype.PrototypeClass.Prototype();
                        break;
                    case 4:
                        StructuralDesignPattern.Adapter.AdapterClass.Adapter();
                        break;
                    case 5:
                        StructuralDesignPattern.Facade.FacadeClass.Facade();
                        break;
                    case 6:
                        StructuralDesignPattern.Proxy.ProxyClass.Proxy();
                        break;
                    case 7:
                        BehavioralDesignPattern.Observer.MainObserver.Observer();
                        break;
                    case 8:
                        BehavioralDesignPattern.VisitorPattern.MainVisitor.Visitor();
                        break;
                    case 9:
                        BehavioralDesignPattern.Mediator.MainMediator.Mediator();
                        break;
                    case 10:
                         Annotation.AnnotationDemo.MainAnnotation();
                        break;
                        default:
                        Console.WriteLine("Please enter valid choice");
                        break;
                }

                Console.WriteLine("\nDo you want to Continue ?(Y/no) ");
                ans = Console.ReadLine();
            }
            while (choice != 0 && ans != "no");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
}