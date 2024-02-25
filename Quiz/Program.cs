namespace Quiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Here we create the menu to show the different topics to choose.
            // And we also declare all the possible options.
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

        // This function is called at the begining to actually show all the topics.
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
            // This variable will be used to check the user's answers.
            int answer;

            // We ask the question and then save the answwer as a number.
            Console.WriteLine("Question 1 - Which year did the World War 2 end? \n 1 - 1939 \n 2 - 1955 \n 3 - 1945 \n 4 - 1950");
            answer = Convert.ToInt32(Console.ReadLine());
            
            // If the answer is correct we will show a message on the screen about it.
            if  (answer == 3)
            {
                Console.WriteLine("Correct!");
            }

            // And also if it's incorrect we will say it.
            else
            {
                Console.WriteLine("Wrong Answer");
            }

            // Then the user must press enter so the next question appears. 
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();

            // Before the next question appears we will clear the screen so it's more organised.
            Console.Clear();

            // And for every topic's question is the same.
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

            // Once every topic's question is finished it will require the user to press a key to go to the main menu and select another topic or exit the program.
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

            Console.WriteLine("Question 1 - What is the name of the galaxy we live in? \n 1 - Black Eye \n 2 - Cigar \n 3 - Milky Way \n 4 - Andromeda");
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

            Console.WriteLine("Question 3 - Which one is closest to the sun? \n 1 - Mercury \n 2 - Mars \n 3 - Pluto \n 4 - Earth");
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