namespace Quiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo keyboard;
            do
            {
                Console.Clear();
                ShowOptions();
                keyboard = Console.ReadKey();
                Console.Clear();
                switch (keyboard.Key)
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
                        MsgNextScreen("Error. Press any key to return to the main menu...");
                        break;
                }
            } while (keyboard.Key != ConsoleKey.D0 && keyboard.Key != ConsoleKey.NumPad0);
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
            try //I use exception handling to prevent the program from crashing if the user enters incorrect data
            {
                int anwser; //I use this variable to determine whether the answer is correct or not
                int count = 0; //I use a variable to count how many correct answers the user has made

                Console.Clear();
                Console.WriteLine("First question:");
                Console.WriteLine("What is the highest-grossing movie in history?");
                Console.WriteLine("1 - Titanic");
                Console.WriteLine("2 - Avatar");
                Console.WriteLine("3 - Avatar2");
                Console.WriteLine("4 - Barbie");

                anwser = Convert.ToInt32(Console.ReadLine());

                if(anwser == 1) Console.WriteLine("The answer is not correct!!!");
                else if (anwser == 2) 
                {
                    Console.WriteLine("The answer is correct!!!"); //If the answer is this, the following message will be displayed,
                                                                   //and the counter for correct answers will increment by 1
                    count++;
                }
                else if (anwser == 3) Console.WriteLine("The answer is not correct!!!");
                else if (anwser == 4) Console.WriteLine("The answer is not correct!!!");

                Console.WriteLine("Second question:");
                Console.WriteLine("What is the best-selling game of all time?");
                Console.WriteLine("1 - Minecraft");
                Console.WriteLine("2 - GTAV");
                Console.WriteLine("3 - Tetris");
                Console.WriteLine("4 - Wii Sports");

                anwser = Convert.ToInt32(Console.ReadLine());

                if (anwser == 1)
                {
                    Console.WriteLine("The answer is correct!!!"); //If the answer is this, the following message will be displayed,
                                                                   //and the counter for correct answers will increment by 1
                    count++;
                }
                else if (anwser == 2) Console.WriteLine("The answer is not correct!!!");
                else if (anwser == 3) Console.WriteLine("The answer is not correct!!!");
                else if (anwser == 4) Console.WriteLine("The answer is not correct!!!");

                Console.WriteLine("Third question:");
                Console.WriteLine("What fruit is SpongeBob's house?");
                Console.WriteLine("1 - Banana");
                Console.WriteLine("2 - Peach");
                Console.WriteLine("3 - Apple");
                Console.WriteLine("4 - Pineapple");

                anwser = Convert.ToInt32(Console.ReadLine());

                if (anwser == 1) Console.WriteLine("The answer is not correct!!!");
                else if (anwser == 2) Console.WriteLine("The answer is not correct!!!");
                else if (anwser == 3) Console.WriteLine("The answer is not correct!!!");
                else if (anwser == 4)
                {
                    Console.WriteLine("The answer is correct!!!"); //If the answer is this, the following message will be displayed,
                                                                   //and the counter for correct answers will increment by 1
                    count++;
                }

                Console.WriteLine("Fourth question:");
                Console.WriteLine("What is the name of Simba'2 father from Lion King?");
                Console.WriteLine("1 - Scar");
                Console.WriteLine("2 - Alex");
                Console.WriteLine("3 - Mufasa");
                Console.WriteLine("4 - Maxim");

                anwser = Convert.ToInt32(Console.ReadLine());

                if (anwser == 1) Console.WriteLine("The answer is not correct!!!");
                else if (anwser == 2) Console.WriteLine("The answer is not correct!!!");
                else if (anwser == 3) 
                {
                    Console.WriteLine("The answer is correct!!!"); //If the answer is this, the following message will be displayed,
                                                                   //and the counter for correct answers will increment by 1
                    count++;
                }
                else if (anwser == 4) Console.WriteLine("The answer is not correct!!!");

                Console.WriteLine("Fifth question:");
                Console.WriteLine("What is the name of the villain in Harry Potter?");
                Console.WriteLine("1 - Spong Bob");
                Console.WriteLine("2 - Simba");
                Console.WriteLine("3 - Darth Vader");
                Console.WriteLine("4 - Voldemort");

                anwser = Convert.ToInt32(Console.ReadLine());

                if (anwser == 1) Console.WriteLine("The answer is not correct!!!");
                else if (anwser == 2) Console.WriteLine("The answer is not correct!!!");
                else if (anwser == 3) Console.WriteLine("The answer is not correct!!!");
                else if (anwser == 4)
                {
                    Console.WriteLine("The answer is correct!!!"); //If the answer is this, the following message will be displayed,
                                                                   //and the counter for correct answers will increment by 1
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
            try //I use exception handling to prevent the program from crashing if the user enters incorrect data
            {
                int answer; //I use this variable to determine whether the answer is correct or not
                int count = 0; //I use a variable to count how many correct answers the user has made

                Console.Clear();
                Console.WriteLine("First question:");
                Console.WriteLine("Which country has the most FIFA World Cup titles?");
                Console.WriteLine("1 - Brasil");
                Console.WriteLine("2 - Spain");
                Console.WriteLine("3 - UK");
                Console.WriteLine("4 - Germany");

                answer = Convert.ToInt32(Console.ReadLine());

                if (answer == 1)
                {
                    Console.WriteLine("The answer is correct!!!"); //If the answer is this, the following message will be displayed,
                                                                   //and the counter for correct answers will increment by 1
                    count++;
                }
                else if (answer == 2) Console.WriteLine("The answer is not correct!!!");
                else if (answer == 3) Console.WriteLine("The answer is not correct!!!");
                else if (answer == 4) Console.WriteLine("The answer is not correct!!!");

                Console.WriteLine("Second question:");
                Console.WriteLine("Which country won the last Basketball World Cup?");
                Console.WriteLine("1 - Germany");
                Console.WriteLine("2 - Spain");
                Console.WriteLine("3 - Italy");
                Console.WriteLine("4 - USA");

                answer = Convert.ToInt32(Console.ReadLine());

                if (answer == 1)
                {
                    Console.WriteLine("The answer is correct!!!"); //If the answer is this, the following message will be displayed,
                                                                   //and the counter for correct answers will increment by 1
                    count++;
                }
                else if (answer == 2) Console.WriteLine("The answer is not correct!!!");
                else if (answer == 3) Console.WriteLine("The answer is not correct!!!");
                else if (answer == 4) Console.WriteLine("The answer is not correct!!!");

                Console.WriteLine("Third question:");
                Console.WriteLine("Which football team won the Spanish La Liga in the 2022-2023 season?");
                Console.WriteLine("1 - F.C.Barcelona");
                Console.WriteLine("2 - Real Madrid");
                Console.WriteLine("3 - Atletico de Madrid");
                Console.WriteLine("4 - Real Sociedad");

                answer = Convert.ToInt32(Console.ReadLine());

                if (answer == 1)
                {
                    Console.WriteLine("The answer is correct!!!"); //If the answer is this, the following message will be displayed,
                                                                   //and the counter for correct answers will increment by 1
                    count++;
                }
                else if (answer == 2) Console.WriteLine("The answer is not correct!!!");
                else if (answer == 3) Console.WriteLine("The answer is not correct!!!");
                else if (answer == 4) Console.WriteLine("The answer is not correct!!!");

                Console.WriteLine("Fourth question:");
                Console.WriteLine("Who is the tennis player with the most Roland Garros victories?");
                Console.WriteLine("1 - Novak Đoković");
                Console.WriteLine("2 - Roger Federer");
                Console.WriteLine("3 - Rafael Nadal");
                Console.WriteLine("4 - Daniïl Medvédev");

                answer = Convert.ToInt32(Console.ReadLine());

                if (answer == 1) Console.WriteLine("The answer is not correct!!!");
                else if (answer == 2) Console.WriteLine("The answer is not correct!!!");
                else if (answer == 3)
                {
                    Console.WriteLine("The answer is correct!!!"); //If the answer is this, the following message will be displayed,
                                                                   //and the counter for correct answers will increment by 1
                    count++;
                }
                else if (answer == 4) Console.WriteLine("The answer is not correct!!!");

                Console.WriteLine("Fifth question:");
                Console.WriteLine("Which country has won the most Olympic medals?");
                Console.WriteLine("1 - Germany");
                Console.WriteLine("2 - Russia");
                Console.WriteLine("3 - Xina");
                Console.WriteLine("4 - USA");

                answer = Convert.ToInt32(Console.ReadLine());

                if (answer == 1) Console.WriteLine("The answer is not correct!!!");
                else if (answer == 2) Console.WriteLine("The answer is not correct!!!");
                else if (answer == 3) Console.WriteLine("The answer is not correct!!!");
                else if (answer == 4)
                {
                    Console.WriteLine("The answer is correct!!!"); //If the answer is this, the following message will be displayed,
                                                                   //and the counter for correct answers will increment by 1
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
            try //I use exception handling to prevent the program from crashing if the user enters incorrect data
            {
                int anwser; //I use this variable to determine whether the answer is correct or not
                int count = 0; //I use a variable to count how many correct answers the user has made

                Console.Clear();
                Console.WriteLine("First question:");
                Console.WriteLine("What does the acronym HTML stand for?");
                Console.WriteLine("1 - Hyper Text Markup Language");
                Console.WriteLine("2 - High Tech Machine Learning");
                Console.WriteLine("3 - Home Tool Management Logic");
                Console.WriteLine("4 - Human Task Master Locator");

                anwser = Convert.ToInt32(Console.ReadLine());

                if (anwser == 1)
                {
                    Console.WriteLine("The answer is correct!!!"); //If the answer is this, the following message will be displayed,
                                                                   //and the counter for correct answers will increment by 1
                    count++;
                }
                else if (anwser == 2) Console.WriteLine("The answer is not correct!!!");
                else if (anwser == 3) Console.WriteLine("The answer is not correct!!!");
                else if (anwser == 4) Console.WriteLine("The answer is not correct!!!");

                Console.WriteLine("Second question:");
                Console.WriteLine("Which protocol is used for sending email?");
                Console.WriteLine("1 - SMTP");
                Console.WriteLine("2 - HTTP");
                Console.WriteLine("3 - FTP");
                Console.WriteLine("4 - TCP");

                anwser = Convert.ToInt32(Console.ReadLine());

                if (anwser == 1)
                {
                    Console.WriteLine("The answer is correct!!!"); //If the answer is this, the following message will be displayed,
                                                                   //and the counter for correct answers will increment by 1
                    count++;
                }
                else if (anwser == 2) Console.WriteLine("The answer is not correct!!!");
                else if (anwser == 3) Console.WriteLine("The answer is not correct!!!");
                else if (anwser == 4) Console.WriteLine("The answer is not correct!!!");

                Console.WriteLine("Third question:");
                Console.WriteLine("What is the most used programming language in the world?");
                Console.WriteLine("1 - Python");
                Console.WriteLine("2 - JavaScript");
                Console.WriteLine("3 - C++");
                Console.WriteLine("4 - C#");

                anwser = Convert.ToInt32(Console.ReadLine());

                if (anwser == 1) Console.WriteLine("The answer is not correct!!!");
                else if (anwser == 2) 
                {
                    Console.WriteLine("The answer is correct!!!"); //If the answer is this, the following message will be displayed,
                                                                   //and the counter for correct answers will increment by 1
                    count++;
                }
                else if (anwser == 3) Console.WriteLine("The answer is not correct!!!");
                else if (anwser == 4) Console.WriteLine("The answer is not correct!!!");

                Console.WriteLine("Fourth question:");
                Console.WriteLine("What is a firewall in the context of computer security?");
                Console.WriteLine("1 - Software for editing images");
                Console.WriteLine("2 - A device that protects a communications network");
                Console.WriteLine("3 - An online storage system");
                Console.WriteLine("4 - A type of touchscreen");

                anwser = Convert.ToInt32(Console.ReadLine());

                if (anwser == 1) Console.WriteLine("The answer is not correct!!!");
                else if (anwser == 2)
                {
                    Console.WriteLine("The answer is correct!!!"); //If the answer is this, the following message will be displayed,
                                                                   //and the counter for correct answers will increment by 1
                    count++;
                }
                else if (anwser == 3) Console.WriteLine("The answer is not correct!!!");
                else if (anwser == 4) Console.WriteLine("The answer is not correct!!!");

                Console.WriteLine("Fifth question:");
                Console.WriteLine("Which operating system is developed by Apple Inc.?");
                Console.WriteLine("1 - macOS");
                Console.WriteLine("2 - Windows");
                Console.WriteLine("3 - Linux");
                Console.WriteLine("4 - Android");

                anwser = Convert.ToInt32(Console.ReadLine());

                if (anwser == 1)
                {
                    Console.WriteLine("The answer is correct!!!"); //If the answer is this, the following message will be displayed,
                                                                   //and the counter for correct answers will increment by 1
                    count++;
                }
                else if (anwser == 2) Console.WriteLine("The answer is not correct!!!");
                else if (anwser == 3) Console.WriteLine("The answer is not correct!!!");
                else if (anwser == 4) Console.WriteLine("The answer is not correct!!!");

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
        /// <summary>
        /// This function implements the Maths Quiz questions for which the user needs to complete to return to the main menu.
        /// </summary>
        private static void MathQuiz()
        {          
            try //Code of the maths quiz is executed in this block
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
                for (int i = 0; i < 4 ; i++) //This loop outputs the full stops 4 times (....) and with a delay after each one for a loading effect.
                {
                    Console.CursorVisible = false; //Makes cursor disappear to see the full stops more clearly.
                    Thread.Sleep(800);
                    Console.Write(".");
                }                
                if (correctCount >= 3)
                {
                    Thread.Sleep(800);
                    Console.WriteLine($" {correctCount} out of 5.");
                    Thread.Sleep(1000);
                    Console.WriteLine();
                    Console.WriteLine("Well done!!");
                    Thread.Sleep(1000);
                }
                else
                {
                    Thread.Sleep(800);
                    Console.WriteLine($" {correctCount} out of 5 :(");
                    Thread.Sleep(1000);
                    Console.WriteLine();
                    Console.WriteLine("Better luck next time!");
                    Thread.Sleep(1000);
                }
                Console.WriteLine();
                Console.WriteLine("Press 'Y' key to continue...");
                Console.CursorVisible = true; //Reveals the cursor.
                while (Console.ReadKey().Key != ConsoleKey.Y) ;
                Console.Clear();
            }
            catch (Exception e) //If an exception occurs during execution of the try block, details of the exception are displayed to the user
            {
                Console.WriteLine(e.Message);
            }
            finally //This block is executed regardless of if whether an exception has occured, it then prompts the user to press a key to return to the main menu.
            {
                MsgNextScreen("Press any key to return to the main menu...");
            }
        }
        /// <summary>
        /// This function implements the Geography Quiz questions for which the user needs to complete to return to the main menu.
        /// </summary>
        private static void GeoraphyQuiz()
        {
            try //Code of the Geography quiz is executed in this block
            {
                string answer; //Variable for storing the answers (changes each answer).
                int correctCount = 0; //answers that are correct.

                Console.Clear(); //Clears the console.
                Console.WriteLine("Let's learn a bit about the world!! :D");
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
                for (int i = 0; i < 4; i++) //This loop outputs the full stops 4 times (....) and with a delay after each one for a loading effect.
                {
                    Console.CursorVisible = false; //Makes cursor disappear to see the full stops more clearly.
                    Thread.Sleep(800);
                    Console.Write(".");
                }
                if (correctCount >= 3)
                {
                    Thread.Sleep(800);
                    Console.WriteLine($" {correctCount} out of 5.");
                    Thread.Sleep(1000);
                    Console.WriteLine();
                    Console.WriteLine("Well done!!");
                    Thread.Sleep(1000);
                }
                else
                {
                    Thread.Sleep(800);
                    Console.WriteLine($" {correctCount} out of 5 :(");
                    Thread.Sleep(1000);
                    Console.WriteLine();
                    Console.WriteLine("Better luck next time!");
                    Thread.Sleep(1000);
                }
                Console.WriteLine();
                Console.WriteLine("Press 'Y' key to continue...");
                Console.CursorVisible = true; //Reveals the cursor.
                while (Console.ReadKey().Key != ConsoleKey.Y) ;
                Console.Clear();
            }
            catch (Exception e) //If an exception occurs during execution of the try block, details of the exception are displayed to the user
            {
                Console.WriteLine(e.Message);
            }
            finally //This block is executed regardless of if whether an exception has occured, it then prompts the user to press a key to return to the main menu.
            {
                MsgNextScreen("Press any key to return to the main menu...");
            }
        }
        /// <summary>
        /// This function implements the Music Quiz questions for which the user needs to complete to return to the main menu.
        /// </summary>
        private static void MusicQuiz()
        {
            try //Code of the music quiz is executed in this block
            {
                string answer; //Variable for storing the answers (changes each answer).
                int correctCount = 0; //answers that are correct.

                Console.Clear(); //Clears the console.
                Console.WriteLine("Let's test your music knowledge!! :D");
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
                Console.WriteLine("Who is the top selling solo artist of all time?");
                Console.WriteLine("a) \t Taylor Swift"); // \t tabs the text for separation.
                Console.WriteLine("b) \t Elvis Presley");
                Console.WriteLine("c) \t Madonna");
                Console.WriteLine("d) \t Michael Jackson");

                answer = Console.ReadLine();

                if ((answer == "d") || (answer == "Michael Jackson")) //User can choose to input a, b, c, d or the answer itself.
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
                Console.WriteLine("Which year did Queen debut their first studio album?");
                Console.WriteLine("a) \t 1975");
                Console.WriteLine("b) \t 1974");
                Console.WriteLine("c) \t 1973");
                Console.WriteLine("d) \t 1972");

                answer = Console.ReadLine();

                if ((answer == "c") || (answer == "1973"))
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
                Console.WriteLine("What was the name of Tom Petty's band?");
                Console.WriteLine("a) \t Tom Petty and the Jawbreakers");
                Console.WriteLine("b) \t Tom Petty and the Heartbreakers");
                Console.WriteLine("c) \t Tom Petty and the Rockbreakers");
                Console.WriteLine("d) \t Tom Petty and the Soulbreakers");

                answer = Console.ReadLine();

                if ((answer == "b") || (answer == "Tom Petty and the Heartbreakers"))
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
                Console.WriteLine("Which of these bands is from Australia?");
                Console.WriteLine("a) \t U2");
                Console.WriteLine("b) \t The Police");
                Console.WriteLine("c) \t AC/DC");
                Console.WriteLine("d) \t Pink Floyd");

                answer = Console.ReadLine();

                if ((answer == "c") || (answer == "AC/DC"))
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
                Console.WriteLine("What is the most streamed song on Spotify?");
                Console.WriteLine("a) \t Blinding Lights - The Weeknd");
                Console.WriteLine("b) \t Africa - TOTO");
                Console.WriteLine("c) \t Shape of you - Ed Sheeran");
                Console.WriteLine("d) \t Billie Jean - Michael Jackson");

                answer = Console.ReadLine();

                if ((answer == "a") || (answer == "Blinding Lights - The Weeknd") || (answer == "Blinding Lights") || (answer == "The Weeknd")) //Extra strings incase the user inputs just the artist or the song.
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
                for (int i = 0; i < 4; i++) //This loop outputs the full stops 4 times (....) and with a delay after each one for a loading effect.
                {
                    Console.CursorVisible = false; //Makes cursor disappear to see the full stops more clearly.
                    Thread.Sleep(800);
                    Console.Write(".");
                }
                if (correctCount >= 3)
                {
                    Thread.Sleep(800);
                    Console.WriteLine($" {correctCount} out of 5.");
                    Thread.Sleep(1000);
                    Console.WriteLine();
                    Console.WriteLine("Well done!!");
                    Thread.Sleep(1000);
                }
                else
                {
                    Thread.Sleep(800);
                    Console.WriteLine($" {correctCount} out of 5 :(");
                    Thread.Sleep(1000);
                    Console.WriteLine();
                    Console.WriteLine("Better luck next time!");
                    Thread.Sleep(1000);
                }
                Console.WriteLine();
                Console.WriteLine("Press 'Y' key to continue...");
                Console.CursorVisible = true; //Reveals the cursor.
                while (Console.ReadKey().Key != ConsoleKey.Y) ;
                Console.Clear();
            }
            catch (Exception e) //If an exception occurs during execution of the try block, details of the exception are displayed to the user
            {
                Console.WriteLine(e.Message);
            }
            finally //This block is executed regardless of if whether an exception has occured, it then prompts the user to press a key to return to the main menu.
            {
                MsgNextScreen("Press any key to return to the main menu...");
            }
        }
    }
}