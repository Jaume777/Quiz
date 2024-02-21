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

        // Beginning of Miquel's Code.
        private static void HistoryQuiz()
        {
            int answer;

            Console.WriteLine("Question 1 - Which year did the World War 2 end? \n 1 - 1939 \n 2 - 1955 \n 3 - 1945 \n 4 - 1950");
            answer = Convert.ToInt32(Console.ReadLine());
            if  (answer == 3)
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine("Wrong Answer");
            }
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Question 2 - Which one of these is the U.S. National day? \n 1 - 21st of December \n 2 - 4th of July \n 3 - 6th of September \n 4 - 1st of January");
            answer = Convert.ToInt32(Console.ReadLine());
            if (answer == 2)
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine("Wrong Answer");
            }
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Question 3 - Who invented the light bulb? \n 1 - Thomas Edison \n 2 - Albert Einstein \n 3 - Nikola Tesla \n 4 - Benjamin Franklin");
            answer = Convert.ToInt32(Console.ReadLine());
            if (answer == 1)
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine("Wrong Answer");
            }
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Question 4 - In which country was the first atomic bomb used? \n 1 - Spain \n 2 - Japan \n 3 - China \n 4 - North Korea");
            answer = Convert.ToInt32(Console.ReadLine());
            if (answer == 2)
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine("Wrong Answer");
            }
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Question 5 - According to the legend who founded Rome? \n 1 - Cleopatra \n 2 - Julius Caesar \n 3 - Cristiano Ronaldo \n 4 - Romulus and Remus");
            answer = Convert.ToInt32(Console.ReadLine());
            if (answer == 4)
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine("Wrong Answer");
            }
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();

            Console.Clear();

            MsgNextScreen("Press a key to go to the main menu");
        }
        private static void FoodQuiz()
        {
            int answer;

            Console.WriteLine("Question 1 - In which country were French Fries originated? \n 1 - Belgium \n 2 - USA \n 3 - France \n 4 - Spain");
            answer = Convert.ToInt32(Console.ReadLine());
            if (answer == 1)
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine("Wrong Answer");
            }
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Question 2 - Choose the only Spanish dish from the following answers: \n 1 - Hamburguer \n 2 - Paella \n 3 - Fish and Chips \n 4 - Ramen");
            answer = Convert.ToInt32(Console.ReadLine());
            if (answer == 2)
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine("Wrong Answer");
            }
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Question 3 - A famous Spanish chef is ... \n 1 - Ana Roš \n 2 - Björn Frantzen \n 3 - Alex Atala \n 4 - Karlos Arguiñano");
            answer = Convert.ToInt32(Console.ReadLine());
            if (answer == 4)
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine("Wrong Answer");
            }
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Question 4 - Which one of these is considered to have the best food? \n 1 - Italy \n 2 - Japan \n 3 - Spain \n 4 - Greece");
            answer = Convert.ToInt32(Console.ReadLine());
            if (answer == 1)
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine("Wrong Answer");
            }
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Question 5 - Who is considered to be the best chef on the whole world? \n 1 - Gordon Ramsay \n 2 - Alberto Chicote \n 3 - Alain Ducasse \n 4 - Daviz Muñoz");
            answer = Convert.ToInt32(Console.ReadLine());
            if (answer == 4)
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine("Wrong Answer");
            }
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();

            Console.Clear();

            MsgNextScreen("Press a key to go to the main menu");
        }
        private static void AstronomyQuiz()
        {
            int answer;

            Console.WriteLine("Question 1 - What is the name of the gallaxy we live in? \n 1 - Black Eye \n 2 - Cigar \n 3 - Milky Way \n 4 - Andromeda");
            answer = Convert.ToInt32(Console.ReadLine());

            if (answer == 3)
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine("Wrong Answer");
            }
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Question 2 - How many planets form the solar system? \n 1 - 5 \n 2 - 8 \n 3 - 9 \n 4 - 12");
            answer = Convert.ToInt32(Console.ReadLine());
            if (answer == 2)
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine("Wrong Answer");
            }
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Question 3 - Which one is closest to he sun? \n 1 - Mercury \n 2 - Mars \n 3 - Pluto \n 4 - Earth");
            answer = Convert.ToInt32(Console.ReadLine());
            if (answer == 1)
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine("Wrong Answer");
            }
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Question 4 - What's an asteroid? \n 1 - Dark matter mass \n 2 - A planet \n 3 - A type of star \n 4 - A rocky object");
            answer = Convert.ToInt32(Console.ReadLine());
            if (answer == 4)
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine("Wrong Answer");
            }
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Question 5 - What's a supernova? \n 1 - A type of weather \n 2 - A star explosion \n 3 - A planet \n 4 - A planet explosion");
            answer = Convert.ToInt32(Console.ReadLine());
            if (answer == 2)
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine("Wrong Answer");
            }
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();

            Console.Clear();

            MsgNextScreen("Press a key to go to the main menu");
        }

        //End of Miquel's Code
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
                Console.WriteLine("What is the most used programming language in the world?");
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