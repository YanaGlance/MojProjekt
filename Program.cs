using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tickets2
{
    class Program
    {
        public enum Operation { show, dates, quit };

        static void ToDo(Operation operation)
        {
            switch (operation)
            {
                case Operation.show:
                    Console.WriteLine("Your tickets: ");
                    break;

                case Operation.dates:
                    Console.WriteLine("Avaliable dates");
                    Date date1 = new Date(2016, 6, 29);
                    date1.Display();
                    DateTime date2 = new DateTime(2016, 7, 30, 12, 15, "flight is delayed");
                    date2.Display();
                    DateTime date3 = new DateTime(2016, 7, 30, 13, 15, "flight is delayed");
                    date3.Display();
                    DateTime date4 = new DateTime(2016, 7, 30, 13, 25, "flight is delayed");
                    date4.Display();
                    Date date5 = new Date(2016, 7, 1);
                    date5.Display();
                    Date date6 = new Date(2016, 7, 2);
                    date6.Display();
                    Date date7 = new Date(2016, 7, 3);
                    date7.Display();
                    Date date8 = new Date(2016, 7, 4);
                    date8.Display();
                    break;

                case Operation.quit:
                    Console.WriteLine("Bye-bye");
                    break;
            }
        }

        static void Main(string[] args)
        {
            Boolean quit = false;
            TicketServiceImpl service = new TicketServiceImpl();

            do
            {
                Console.WriteLine("1. Looking for tickets");
                Console.WriteLine("2. Available dates");
                Console.WriteLine("3. Exit");

                int choice;

                try
                {
                    choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            {
                                Console.WriteLine("Please, enter the departure city");
                                String city1 = Console.ReadLine();
                                Console.WriteLine("Please, enter the destination city");
                                String city2 = Console.ReadLine();
                                Console.WriteLine("Please, enter the year");
                                int year = int.Parse(Console.ReadLine());
                                Console.WriteLine("Please, enter the month");
                                int month = int.Parse(Console.ReadLine());
                                Console.WriteLine("Please, enter the day");
                                int day = int.Parse(Console.ReadLine());
                                Console.WriteLine("Please, enter the hour");
                                int hour = int.Parse(Console.ReadLine());
                                Console.WriteLine("Please, enter the minute");
                                int minute = int.Parse(Console.ReadLine());
                                Console.WriteLine("Is it delay possible? yes/no");
                                string delay = Console.ReadLine();

                                List<TicketInfo> list1 = service.getTicketInfo(city1, city2, new DateTime(year, month, day, hour, minute, delay));

                                Operation operation = Operation.show;
                                ToDo(operation);

                                foreach (var ticket in list1)
                                    Console.WriteLine(ticket);
                                break;
                            }

                        case 2:
                            {
                                Operation operation = Operation.dates;
                                ToDo(operation);
                                break;
                            }

                        case 3:
                            {
                                quit = true;
                                Operation operation = Operation.quit;
                                ToDo(operation);
                                break;
                            }

                        default:
                            {
                                if (choice < 1 | choice > 3)
                                    Console.WriteLine("Incorrect number");
                            }
                            break;
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine("It's not a number");
                }
                Console.ReadKey();
            } while (!quit);
        }
    }
}
