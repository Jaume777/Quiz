namespace Quiz
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
                        AstrologyQuiz();
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
            Console.WriteLine("3 - Astrology");
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
        private static void AstrologyQuiz()
        {
            throw new NotImplementedException();
        }
        private static void EntertainmentQuiz()
        {
            try
            {
                int resposta;
                int count = 0;

                Console.Clear();
                Console.WriteLine("First question:");
                Console.WriteLine("What is the highest-grossing movie in history?");
                Console.WriteLine("1 - Titanic");
                Console.WriteLine("2 - Avatar");
                Console.WriteLine("3 - Avatar2");
                Console.WriteLine("4 - Barbie");

                resposta = Convert.ToInt32(Console.ReadLine());

                if(resposta == 1) Console.WriteLine("The answer is not correct!!!");
                else if (resposta == 2)
                {
                    Console.WriteLine("The answer is correct!!!");
                    count++;
                }
                else if (resposta == 3) Console.WriteLine("The answer is not correct!!!");
                else if (resposta == 4) Console.WriteLine("The answer is not correct!!!");

                Console.WriteLine("Second question:");
                Console.WriteLine("What is the best-selling game of all time?");
                Console.WriteLine("1 - Minecraft");
                Console.WriteLine("2 - GTAV");
                Console.WriteLine("3 - Tetris");
                Console.WriteLine("4 - Wii Sports");

                resposta = Convert.ToInt32(Console.ReadLine());

                if (resposta == 1)
                {
                    Console.WriteLine("The answer is correct!!!");
                    count++;
                }
                else if (resposta == 2) Console.WriteLine("The answer is not correct!!!");
                else if (resposta == 3) Console.WriteLine("The answer is not correct!!!");
                else if (resposta == 4) Console.WriteLine("The answer is not correct!!!");

                Console.WriteLine("Third question:");
                Console.WriteLine("What fruit is SpongeBob's house?");
                Console.WriteLine("1 - Banana");
                Console.WriteLine("2 - Peach");
                Console.WriteLine("3 - Apple");
                Console.WriteLine("4 - Pineapple");

                resposta = Convert.ToInt32(Console.ReadLine());

                if (resposta == 1) Console.WriteLine("The answer is not correct!!!");
                else if (resposta == 2) Console.WriteLine("The answer is not correct!!!");
                else if (resposta == 3) Console.WriteLine("The answer is not correct!!!");
                else if (resposta == 4)
                {
                    Console.WriteLine("The answer is correct!!!");
                    count++;
                }

                Console.WriteLine("Fourth question:");
                Console.WriteLine("What is the name of Simba'2 father from Lion King?");
                Console.WriteLine("1 - Scar");
                Console.WriteLine("2 - Alex");
                Console.WriteLine("3 - Mufasa");
                Console.WriteLine("4 - Maxim");

                resposta = Convert.ToInt32(Console.ReadLine());

                if (resposta == 1) Console.WriteLine("The answer is not correct!!!");
                else if (resposta == 2) Console.WriteLine("The answer is not correct!!!");
                else if (resposta == 3) 
                {
                    Console.WriteLine("The answer is correct!!!");
                    count++;
                }
                else if (resposta == 4) Console.WriteLine("The answer is not correct!!!");

                Console.WriteLine("Fifth question:");
                Console.WriteLine("What is the name of the villain in Harry Potter?");
                Console.WriteLine("1 - Spong Bob");
                Console.WriteLine("2 - Simba");
                Console.WriteLine("3 - Darth Vader");
                Console.WriteLine("4 - Voldemort");

                resposta = Convert.ToInt32(Console.ReadLine());

                if (resposta == 1) Console.WriteLine("The answer is not correct!!!");
                else if (resposta == 2) Console.WriteLine("The answer is not correct!!!");
                else if (resposta == 3) Console.WriteLine("The answer is not correct!!!");
                else if (resposta == 4)
                {
                    Console.WriteLine("The answer is correct!!!");
                    count++;
                }

                if (count == 0) Console.WriteLine("You haven't made any correct guesses");
                else Console.WriteLine($"You have made {count} correct guesses");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                MsgNextScreen("PRESS A KEY TO GO TO THE Main MENU");
            }
        }
        private static void SportsQuiz()
        {
            try
            {
                int resposta;
                int count = 0;

                Console.Clear();
                Console.WriteLine("First question:");
                Console.WriteLine("Which country has the most FIFA World Cup titles?");
                Console.WriteLine("1 - Brasil");
                Console.WriteLine("2 - Spain");
                Console.WriteLine("3 - UK");
                Console.WriteLine("4 - Germany");

                resposta = Convert.ToInt32(Console.ReadLine());

                if (resposta == 1)
                {
                    Console.WriteLine("The answer is correct!!!");
                    count++;
                }
                else if (resposta == 2) Console.WriteLine("The answer is not correct!!!");
                else if (resposta == 3) Console.WriteLine("The answer is not correct!!!");
                else if (resposta == 4) Console.WriteLine("The answer is not correct!!!");

                Console.WriteLine("Second question:");
                Console.WriteLine("Which country won the last Basketball World Cup?");
                Console.WriteLine("1 - Germany");
                Console.WriteLine("2 - Spain");
                Console.WriteLine("3 - Italy");
                Console.WriteLine("4 - USA");

                resposta = Convert.ToInt32(Console.ReadLine());

                if (resposta == 1)
                {
                    Console.WriteLine("The answer is correct!!!");
                    count++;
                }
                else if (resposta == 2) Console.WriteLine("The answer is not correct!!!");
                else if (resposta == 3) Console.WriteLine("The answer is not correct!!!");
                else if (resposta == 4) Console.WriteLine("The answer is not correct!!!");

                Console.WriteLine("Third question:");
                Console.WriteLine("Which football team won the Spanish La Liga in the 2022-2023 season?");
                Console.WriteLine("1 - F.C.Barcelona");
                Console.WriteLine("2 - Real Madrid");
                Console.WriteLine("3 - Atletico de Madrid");
                Console.WriteLine("4 - Real Sociedad");

                resposta = Convert.ToInt32(Console.ReadLine());

                if (resposta == 1)
                {
                    Console.WriteLine("The answer is correct!!!");
                    count++;
                }
                else if (resposta == 2) Console.WriteLine("The answer is not correct!!!");
                else if (resposta == 3) Console.WriteLine("The answer is not correct!!!");
                else if (resposta == 4) Console.WriteLine("The answer is not correct!!!");

                Console.WriteLine("Fourth question:");
                Console.WriteLine("Who is the tennis player with the most Roland Garros victories?");
                Console.WriteLine("1 - Novak Đoković");
                Console.WriteLine("2 - Roger Federer");
                Console.WriteLine("3 - Rafael Nadal");
                Console.WriteLine("4 - Daniïl Medvédev");

                resposta = Convert.ToInt32(Console.ReadLine());

                if (resposta == 1) Console.WriteLine("The answer is not correct!!!");
                else if (resposta == 2) Console.WriteLine("The answer is not correct!!!");
                else if (resposta == 3)
                {
                    Console.WriteLine("The answer is correct!!!");
                    count++;
                }
                else if (resposta == 4) Console.WriteLine("The answer is not correct!!!");

                Console.WriteLine("Fifth question:");
                Console.WriteLine("Which country has won the most Olympic medals?");
                Console.WriteLine("1 - Germany");
                Console.WriteLine("2 - Russia");
                Console.WriteLine("3 - Xina");
                Console.WriteLine("4 - USA");

                resposta = Convert.ToInt32(Console.ReadLine());

                if (resposta == 1) Console.WriteLine("The answer is not correct!!!");
                else if (resposta == 2) Console.WriteLine("The answer is not correct!!!");
                else if (resposta == 3) Console.WriteLine("The answer is not correct!!!");
                else if (resposta == 4)
                {
                    Console.WriteLine("The answer is correct!!!");
                    count++;
                }

                if (count == 0) Console.WriteLine("You haven't made any correct guesses");
                else Console.WriteLine($"You have made {count} correct guesses");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                MsgNextScreen("PRESS A KEY TO GO TO THE Main MENU");
            }
        }
        private static void ITQuiz()
        {
            try
            {
                int resposta;
                int count = 0;

                Console.Clear();
                Console.WriteLine("First question:");
                Console.WriteLine("What does the acronym HTML stand for?");
                Console.WriteLine("1 - Hyper Text Markup Language");
                Console.WriteLine("2 - High Tech Machine Learning");
                Console.WriteLine("3 - Home Tool Management Logic");
                Console.WriteLine("4 - Human Task Master Locator");

                resposta = Convert.ToInt32(Console.ReadLine());

                if (resposta == 1)
                {
                    Console.WriteLine("The answer is correct!!!");
                    count++;
                }
                else if (resposta == 2) Console.WriteLine("The answer is not correct!!!");
                else if (resposta == 3) Console.WriteLine("The answer is not correct!!!");
                else if (resposta == 4) Console.WriteLine("The answer is not correct!!!");

                Console.WriteLine("Second question:");
                Console.WriteLine("Which protocol is used for sending email?");
                Console.WriteLine("1 - SMTP");
                Console.WriteLine("2 - HTTP");
                Console.WriteLine("3 - FTP");
                Console.WriteLine("4 - TCP");

                resposta = Convert.ToInt32(Console.ReadLine());

                if (resposta == 1)
                {
                    Console.WriteLine("The answer is correct!!!");
                    count++;
                }
                else if (resposta == 2) Console.WriteLine("The answer is not correct!!!");
                else if (resposta == 3) Console.WriteLine("The answer is not correct!!!");
                else if (resposta == 4) Console.WriteLine("The answer is not correct!!!");

                Console.WriteLine("Third question:");
                Console.WriteLine("Which football team won the Spanish La Liga in the 2022-2023 season?");
                Console.WriteLine("1 - Python");
                Console.WriteLine("2 - JavaScript");
                Console.WriteLine("3 - C++");
                Console.WriteLine("4 - C#");

                resposta = Convert.ToInt32(Console.ReadLine());

                if (resposta == 1) Console.WriteLine("The answer is not correct!!!");
                else if (resposta == 2) 
                {
                    Console.WriteLine("The answer is correct!!!");
                    count++;
                }
                else if (resposta == 3) Console.WriteLine("The answer is not correct!!!");
                else if (resposta == 4) Console.WriteLine("The answer is not correct!!!");

                Console.WriteLine("Fourth question:");
                Console.WriteLine("What is a firewall in the context of computer security?");
                Console.WriteLine("1 - Software for editing images");
                Console.WriteLine("2 - A device that protects a communications network");
                Console.WriteLine("3 - An online storage system");
                Console.WriteLine("4 - A type of touchscreen");

                resposta = Convert.ToInt32(Console.ReadLine());

                if (resposta == 1) Console.WriteLine("The answer is not correct!!!");
                else if (resposta == 2)
                {
                    Console.WriteLine("The answer is correct!!!");
                    count++;
                }
                else if (resposta == 3) Console.WriteLine("The answer is not correct!!!");
                else if (resposta == 4) Console.WriteLine("The answer is not correct!!!");

                Console.WriteLine("Fifth question:");
                Console.WriteLine("Which operating system is developed by Apple Inc.?");
                Console.WriteLine("1 - macOS");
                Console.WriteLine("2 - Windows");
                Console.WriteLine("3 - Linux");
                Console.WriteLine("4 - Android");

                resposta = Convert.ToInt32(Console.ReadLine());

                if (resposta == 1)
                {
                    Console.WriteLine("The answer is correct!!!");
                    count++;
                }
                else if (resposta == 2) Console.WriteLine("The answer is not correct!!!");
                else if (resposta == 3) Console.WriteLine("The answer is not correct!!!");
                else if (resposta == 4) Console.WriteLine("The answer is not correct!!!");

                if (count == 0) Console.WriteLine("You haven't made any correct guesses");
                else Console.WriteLine($"You have made {count} correct guesses");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                MsgNextScreen("PRESS A KEY TO GO TO THE Main MENU");
            }
        }
        private static void MathQuiz()
        {
            throw new NotImplementedException();
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