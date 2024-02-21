﻿namespace Quiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo tecla;
            do
            {
                Console.Clear();
                ShowOptions();
                tecla = Console.ReadKey();
                Console.Clear();
                switch (tecla.Key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        HistoryQuiz();
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        FoodQuiz();
                        break;
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        AstronomyQuiz();
                        break;
                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        EntertainmentQuiz();
                        break;
                    case ConsoleKey.D5:
                    case ConsoleKey.NumPad5:
                        SportsQuiz();
                        break;
                    case ConsoleKey.D6:
                    case ConsoleKey.NumPad6:
                        ITQuiz();
                        break;
                    case ConsoleKey.D7:
                    case ConsoleKey.NumPad7:
                        MathQuiz();
                        break;
                    case ConsoleKey.D8:
                    case ConsoleKey.NumPad8:
                        GeoraphyQuiz();
                        break;
                    case ConsoleKey.D9:
                    case ConsoleKey.NumPad9:
                        MusicQuiz();
                        break;
                    case ConsoleKey.D0:
                    case ConsoleKey.NumPad0:
                        MsgNextScreen("PRESS ANY KEY 2 EXIT");
                        break;
                    default:
                        MsgNextScreen("Error. Prem una tecla per tornar al menú...");
                        break;
                }
            } while (tecla.Key != ConsoleKey.D0 && tecla.Key != ConsoleKey.NumPad0);
        }

        public static void ShowOptions()
        {
            Console.Clear();
            Console.WriteLine("1 - History");
            Console.WriteLine("2 - Food");
            Console.WriteLine("3 - Astronomy");
            Console.WriteLine("4 - Entertainment");
            Console.WriteLine("5 - Sports");
            Console.WriteLine("6 - IT");
            Console.WriteLine("7 - Math");
            Console.WriteLine("8 - Georaphy");
            Console.WriteLine("9 - Music");
            Console.WriteLine("0 - EXIT");
        }
        public static void MsgNextScreen(string msg)
        {
            Console.WriteLine(msg);
            Console.ReadKey();
        }
        private static void HistoryQuiz()
        {
            throw new NotImplementedException();
        }
        private static void FoodQuiz()
        {
            throw new NotImplementedException();
        }
        private static void AstronomyQuiz()
        {
            throw new NotImplementedException();
        }
        private static void EntertainmentQuiz()
        {
            throw new NotImplementedException();
        }
        private static void SportsQuiz()
        {
            throw new NotImplementedException();
        }
        private static void ITQuiz()
        {
            throw new NotImplementedException();
        }
        private static void MathQuiz()
        {
            
            try
            {
                string answer;
                int correctCount = 0;

                Console.Clear();
                Console.WriteLine("Let's learn some Maths!! :D");
                Thread.Sleep(1000);
                Console.WriteLine();
                Console.WriteLine("Press 'Y' key to continue...");
                while (Console.ReadKey().Key != ConsoleKey.Y) ;
                Console.Clear();

                //Question 1
                Console.WriteLine("Question 1:");
                Console.WriteLine("-----------");
                Console.WriteLine();
                Thread.Sleep(1000);
                Console.WriteLine("What is the square root of 49?");
                Console.WriteLine("a) \t 4");
                Console.WriteLine("b) \t 9");
                Console.WriteLine("c) \t 7");
                Console.WriteLine("d) \t 12");

                answer = Console.ReadLine();

                if ((answer == "c") || (answer == "7"))
                {
                    Console.WriteLine("Well done!! Your answer is correct :)");
                    correctCount++;
                }
                else Console.WriteLine("Your answer is incorrect");

                Thread.Sleep(1000);
                Console.WriteLine();
                Console.WriteLine("Press 'Y' key to continue...");
                while (Console.ReadKey().Key != ConsoleKey.Y) ;
                Console.Clear();

                //Question 2
                Console.WriteLine("Question 2:");
                Console.WriteLine("-----------");
                Thread.Sleep(1200);
                Console.WriteLine();
                Console.WriteLine("What is 12 squared?");
                Console.WriteLine("a) \t 100");
                Console.WriteLine("b) \t 1200");
                Console.WriteLine("c) \t 512");
                Console.WriteLine("d) \t 144");

                answer = Console.ReadLine();

                if ((answer == "d") || (answer == "144"))
                {
                    Console.WriteLine("Well done!! Your answer is correct :)");
                    correctCount++;
                }
                else Console.WriteLine("Your answer is incorrect");

                Thread.Sleep(1000);
                Console.WriteLine();
                Console.WriteLine("Press 'Y' key to continue...");
                while (Console.ReadKey().Key != ConsoleKey.Y) ;
                Console.Clear();

                //Question 3
                Console.WriteLine("Question 3:");
                Console.WriteLine("-----------");
                Thread.Sleep(1000);
                Console.WriteLine();
                Console.WriteLine("What is 500 divided by 4?");
                Console.WriteLine("a) \t 150");
                Console.WriteLine("b) \t 120");
                Console.WriteLine("c) \t 140");
                Console.WriteLine("d) \t 125");

                answer = Console.ReadLine();

                if ((answer == "d") || (answer == "125"))
                {
                    Console.WriteLine("Well done!! Your answer is correct :)");
                    correctCount++;
                }
                else Console.WriteLine("Your answer is incorrect");

                Thread.Sleep(1000);
                Console.WriteLine();
                Console.WriteLine("Press 'Y' key to continue...");
                while (Console.ReadKey().Key != ConsoleKey.Y) ;
                Console.Clear();

                //Question 4
                Console.WriteLine("Question 4:");
                Console.WriteLine("-----------");
                Thread.Sleep(1000);
                Console.WriteLine();
                Console.WriteLine("What is 64 x 12?");
                Console.WriteLine("a) \t 1044");
                Console.WriteLine("b) \t 515");
                Console.WriteLine("c) \t 672");
                Console.WriteLine("d) \t 763");

                answer = Console.ReadLine();

                if ((answer == "c") || (answer == "672"))
                {
                    Console.WriteLine("Well done!! Your answer is correct :)");
                    correctCount++;
                }
                else Console.WriteLine("Your answer is incorrect");

                Thread.Sleep(1000);
                Console.WriteLine();
                Console.WriteLine("Press 'Y' key to continue...");
                while (Console.ReadKey().Key != ConsoleKey.Y) ;
                Console.Clear();

                //Question 5
                Console.WriteLine("Question 5:");
                Console.WriteLine("-----------");
                Thread.Sleep(1000);
                Console.WriteLine();
                Console.WriteLine("If a rectangle has a length of 7 meters and a width of 3 meters, what is its area?");
                Console.WriteLine("a) \t 21");
                Console.WriteLine("b) \t 30");
                Console.WriteLine("c) \t 51");
                Console.WriteLine("d) \t 10");

                answer = Console.ReadLine();

                if ((answer == "a") || (answer == "21"))
                {
                    Console.WriteLine("Well done!! Your answer is correct :)");
                    correctCount++;
                }
                else Console.WriteLine("Your answer is incorrect");

                Thread.Sleep(1000);
                Console.WriteLine();
                Console.WriteLine("Press 'Y' key to continue...");
                while (Console.ReadKey().Key != ConsoleKey.Y) ;
                Console.Clear();

                //Result
                Console.Write("Your final result is... ");
                Thread.Sleep(1000);
                if (correctCount >= 3)
                {
                    Console.Write($"{correctCount} out of 5. ");
                    Thread.Sleep(1000);
                    Console.WriteLine("Well done!!");
                    Thread.Sleep(1000);
                }
                else
                {
                    Console.Write($"{correctCount} out of 5 :( ");
                    Thread.Sleep(1000);
                    Console.WriteLine("Better luck next time!");
                    Thread.Sleep(1000);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                MsgNextScreen("Press any key to return to the main menu...");
            }

            
            //Console.WriteLine();
            //Console.WriteLine("Press any key to return to the main menu...");
            //Console.ReadKey();
        }
        private static void GeoraphyQuiz()
        {
            throw new NotImplementedException();
        }
        private static void MusicQuiz()
        {
            throw new NotImplementedException();
        }
    }
}