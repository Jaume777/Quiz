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
        /// <summary>
        /// This function implements the Maths Quiz questions for which the user needs to complete to return to the main menu.
        /// </summary>
        private static void MathQuiz()
        {
            
            try
            {
                string answer; //Variable for storing the answers (changes each answer).
                int correctCount = 0; //answers that are correct.

                Console.Clear(); //Clears the console
                Console.WriteLine("Let's learn some Maths!! :D");
                Thread.Sleep(1000); //delays the next message for 1000 milliseconds.
                Console.WriteLine();
                Console.WriteLine("Press 'Y' key to continue...");
                while (Console.ReadKey().Key != ConsoleKey.Y) ; //Keeps looping until the Y key is pressed.
                Console.Clear();

                //Question 1
                Console.WriteLine("Question 1:");
                Console.WriteLine("-----------");
                Console.WriteLine();
                Thread.Sleep(1000);
                Console.WriteLine("What is the square root of 49?");
                Console.WriteLine("a) \t 4"); // \t tabs the text for separation.
                Console.WriteLine("b) \t 9");
                Console.WriteLine("c) \t 7");
                Console.WriteLine("d) \t 12");

                answer = Console.ReadLine();

                if ((answer == "c") || (answer == "7")) //User can choose to input a, b, c, d or the answer itself.
                {
                    Console.WriteLine("Well done!! Your answer is correct :)");
                    correctCount++; //Correct count goes up by 1
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
                Thread.Sleep(1000);
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
                Console.Write("Your final result is");
                for (int i = 0; i < 3 ; i++) //This loop outputs the full stops 3 times (...) and with a delay after each one for a loading effect.
                {
                    Console.CursorVisible = false; //Makes cursor disappear to see the full stops more clearly.
                    Console.Write(".");
                    Thread.Sleep(800);
                }
                Console.CursorVisible = true; //Reveals the cursor.
                if (correctCount >= 3)
                {
                    Console.Write($" {correctCount} out of 5. ");
                    Thread.Sleep(1000);
                    Console.WriteLine("Well done!!");
                    Thread.Sleep(1000);
                }
                else
                {
                    Console.Write($" {correctCount} out of 5 :( ");
                    Thread.Sleep(1000);
                    Console.WriteLine("Better luck next time!");
                    Thread.Sleep(1000);
                }
                Console.WriteLine();
                Console.WriteLine("Press 'Y' key to continue...");
                while (Console.ReadKey().Key != ConsoleKey.Y) ;
                Console.Clear();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                MsgNextScreen("Press any key to return to the main menu...");
            }
        }
        /// <summary>
        /// This function implements the Geography Quiz questions for which the user needs to complete to return to the main menu.
        /// </summary>
        private static void GeoraphyQuiz()
        {
            try
            {
                string answer; //Variable for storing the answers (changes each answer).
                int correctCount = 0; //answers that are correct.

                Console.Clear(); //Clears the console.
                Console.WriteLine("Let's learn a bit of the world!! :D");
                Thread.Sleep(1000); //delays the next message for 1000 milliseconds.
                Console.WriteLine();
                Console.WriteLine("Press 'Y' key to continue...");
                while (Console.ReadKey().Key != ConsoleKey.Y) ; //Keeps looping until the Y key is pressed.
                Console.Clear();

                //Question 1
                Console.WriteLine("Question 1:");
                Console.WriteLine("-----------");
                Console.WriteLine();
                Thread.Sleep(1000);
                Console.WriteLine("What is the capital city of New Zealand?");
                Console.WriteLine("a) \t Aeotearoa"); // \t tabs the text for separation.
                Console.WriteLine("b) \t Auckland");
                Console.WriteLine("c) \t Christchurch");
                Console.WriteLine("d) \t Wellington");

                answer = Console.ReadLine();

                if ((answer == "d") || (answer == "Wellington")) //User can choose to input a, b, c, d or the answer itself.
                {
                    Console.WriteLine("Well done!! Your answer is correct :)");
                    correctCount++; //Correct count goes up by 1
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
                Thread.Sleep(1000);
                Console.WriteLine();
                Console.WriteLine("How many states are there in America?");
                Console.WriteLine("a) \t 50");
                Console.WriteLine("b) \t 49");
                Console.WriteLine("c) \t 48");
                Console.WriteLine("d) \t 47");

                answer = Console.ReadLine();

                if ((answer == "a") || (answer == "50"))
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
                Console.WriteLine("Which countries make up the United Kingdom?");
                Console.WriteLine("a) \t England, Scotland and Wales");
                Console.WriteLine("b) \t England, Scotland, Wales and Ireland");
                Console.WriteLine("c) \t England, Scotland, Wales and Northern Ireland");
                Console.WriteLine("d) \t England, Scotland, Wales and Southern Ireland");

                answer = Console.ReadLine();

                if ((answer == "c") || (answer == "England Scotland, Wales and Northern Ireland"))
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
                Console.WriteLine("Which country is the city Oslo located in?");
                Console.WriteLine("a) \t Sweden");
                Console.WriteLine("b) \t Denmark");
                Console.WriteLine("c) \t Norway");
                Console.WriteLine("d) \t Finland");

                answer = Console.ReadLine();

                if ((answer == "c") || (answer == "Norway"))
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
                Console.WriteLine("How many continents are there in the world?");
                Console.WriteLine("a) \t 5");
                Console.WriteLine("b) \t 7");
                Console.WriteLine("c) \t 8");
                Console.WriteLine("d) \t 4");

                answer = Console.ReadLine();

                if ((answer == "b") || (answer == "7"))
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
                Console.Write("Your final result is");
                for (int i = 0; i < 3; i++) //This loop outputs the full stops 3 times (...) and with a delay after each one for a loading effect.
                {
                    Console.CursorVisible = false; //Makes cursor disappear to see the full stops more clearly.
                    Console.Write(".");
                    Thread.Sleep(800);
                }
                Console.CursorVisible = true; //Reveals the cursor.
                if (correctCount >= 3)
                {
                    Console.Write($" {correctCount} out of 5. ");
                    Thread.Sleep(1000);
                    Console.WriteLine("Well done!!");
                    Thread.Sleep(1000);
                }
                else
                {
                    Console.Write($" {correctCount} out of 5 :( ");
                    Thread.Sleep(1000);
                    Console.WriteLine("Better luck next time!");
                    Thread.Sleep(1000);
                }
                Console.WriteLine();
                Console.WriteLine("Press 'Y' key to continue...");
                while (Console.ReadKey().Key != ConsoleKey.Y) ;
                Console.Clear();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                MsgNextScreen("Press any key to return to the main menu...");
            }
        }
        private static void MusicQuiz()
        {
            throw new NotImplementedException();
        }
    }
}