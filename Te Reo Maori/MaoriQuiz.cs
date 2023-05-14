using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace Te_Reo_Maori
{
    internal class MaoriQuiz
    {
        static void Main(string[] args)
        {
            string quizHeading = "----------\nMaori Quiz\n----------";

            //Calling the name method to ask the user for name and store it in a variable type string
            string name = Name(quizHeading);

            //Calling the level method to ask the user for level and store it in a variable type int
            int level = Level(quizHeading);

            //Calling the info method to display the instructions
            Info(quizHeading);

            //Starting the Quiz and storing the score in an integer score
            int score = Quiz(name, level);

            //Summary of the Quiz
            Summary(name, score);

            //Ask the user if he wants to re-do the quiz
            QuizRedo(name);
        }
        static string Name(string quizHeading)
        {
            string name = "";

            Console.WriteLine(quizHeading);
            do
            {
                Console.WriteLine("Enter your name : ");
                name = Console.ReadLine();

            } while (name.Equals(""));

            Console.Clear();
            return name;
        }
        static int Level(string quizHeading)
        {
            int level = 0;

            //Heading
            Console.WriteLine(quizHeading);

            //Asking user for difficulty level
            while (level != 1 && level != 2 && level != 3 && level != 4 && level != 5)
            {
                Console.WriteLine("\nWhat is your desired Difficulty Level (Choose a number from the given option) : ");
                Console.WriteLine("1. Base\n2. Easy\n3. Medium\n4. Hard\n5. Exit Quiz");

                //Try and catch if the user input a wrong format.
                try
                {
                    level = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("\nERROR - You did not choose a number.");
                }
                finally
                {
                    if (level != 1 && level != 2 && level != 3 && level != 4)
                    {
                        Console.WriteLine("\nPlease Re-enter your level. (Choose numbers from the given option)\n");
                    }
                    else if (level == 5)
                    {
                        Console.Clear();
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.Clear();
                    }
                }
            }

            return level;
        }
        static void Info(string quizHeading)
        {
            // This will tell the user how the program works
            Console.WriteLine(quizHeading + "\n\n");
            string about = "Welcome to the Maori Quiz! This quiz consists of multiple choice questions, where you will be presented with a question and four possible answers: A, B, C, or D.\r\n\r\nYou will need to select the option that you believe is the correct answer to the question.\r\n\r\nTo answer a question, simply type the alphabet that belongs to the option that you believe is correct and press enter.\r\n\r\nIf you get the answer correct you will see the live score change on top right of the corner. The score will increase by 2 points for each correct answer you give.\r\n\r\nIf you get the answer wrong, you will see the correct answer displayed and the quiz will continue.\r\n\r\nYou can also see how many questions you have left to answer in the top right corner of the console window.\r\n\r\nYou must answer all questions to complete the quiz. Once you have answered the final question, you will be able to see your report.\r\n\r\nGood luck, and have fun!\r\n\r\n>>> Press any key to continue <<<";

            Console.WriteLine(about);
            Console.ReadKey();
            Console.Clear();
        }
        static int Quiz(string name, int level)
        {
            //All variables in the method
            string quizHeading;
            string[] input = new string[5];
            int score = 0, questions_left = 5;
            string[,] QnA = new string[1, 5];

            string[,] base_QnA =
            {
                {
                    "\n\n1. What is the official language of New Zealand?\nA. Japanese\nB. Maori\nC. Spanish\nD. French\n",
                    "\n\n2. What is the meaning of the Maori word \"kia ora\"?\nA. Goodbye\nB. Hello\nC. Thank you\nD. Welcome\n",
                    "\n\n3. What is the name of the Maori New Year celebration?\nA. Matariki\nB. Mardi Gas\nC. Cinco de Mayo\nD. None of the Above\n",
                    "\n\n4. What is the Maori work for \"Love\"\nA. Aroha\nB. Whakapapa\nC. Rongo\nD. Kai\n",
                    "\n\n5. Which of the following means \"Food\" in Maori\nA. Mana\nB. Haka\nC. Kai\nD. None of the Above\n"
                }
                , { "B", "B", "A", "A", "C"}
            };
            string[,] easy_QnA =
            {
                {
                    "\n\n1. How many vowels does the Maori language have? (Please choose alphabet only)\nA. 5\nB. 6\nC. 7\nD. 9\n",
                    "\n\n2. Which of the following words means \"Thank You\" in Maori?\nA. Ka kite\nB. Kia ora\nC. Aroha\nD. Tapu\n",
                    "\n\n3. What is the name of the Maori New Year celebration?\nA. Matariki\nB. Mardi Gas\nC. Cinco de Mayo\nD. None of the Above\n",
                    "\n\n4. What is the Maori words for \"Family\"\nA. Tapu\nB. Whakapapa\nC. Rongo\nD. Whanau\n",
                    "\n\n5. Which of the following means \"Food\" in Maori\nA. Mana\nB. Haka\nC. Kai\nD. None of the Above\n"
                },
                {"B", "A", "A", "D", "C"}
            };
            string[,] medium_QnA =
            {
                {
                    "\n\n1. What is the meaning of \"mana\" in Maori?\nA. Respect\nB. Love\nC. Power\nD. Hate\n",
                    "\n\n2. What is the name of the traditional Maori food cooked in an earth oven?\nA. Haka\nB. Hangi\nC. Kai\nD. Awa\n",
                    "\n\n3. What is the name of the Maori Creation story?\nA. The dreamtime\nB. The Great Flood\nC. The legend of Maui\nD. None of the Above\n",
                    "\n\n4. What is the Maori word for \"Blessing\" or \"prayer\"\nA. Kawa\nB. Karakia\nC. Rongo\nD. Tapu\n",
                    "\n\n5. What is the Maori word for \"Rain\"\nA. Whenua\nB. AWA\nC. Ua\nD. None of the Above\n"
                },
                { "A", "B", "C","B", "C"}
            };
            string[,] hard_QnA =
            {
                {
                    "\n\n1. What is the meaning of the Maori word \"whare\"?\nA. House or Building\nB. Land or Trritory\nC. Ocean or sea\nD. River or Lake\n",
                    "\n\n2. What is the name of the Maori musical instrument made from a conch shell?\nA. Poi\nB. Kete\nC. Putatara\nD. Awa\n",
                    "\n\n3. What is the name of the Maori god of war?\nA. tane Mahuta\nB. Tumatauenga\nC. Tangaroa\nD. None of the Above\n",
                    "\n\n4. What is the meaning of \"whenua\" in Maori?\nA. Land or Earth\nB. Sky or heavens\nC. Water or sea\nD. Cave or Hell\n",
                    "\n\n5. What is the Maori word for \"Rain\"\nA. Whenua\nB. AWA\nC. Ua\nD. None of the Above\n"
                },
                {"A", "C", "B", "A", "C" }
            };
            switch (level)
            {
                case 1:
                    QnA = base_QnA;
                    break;
                case 2:
                    QnA = easy_QnA;
                    break;
                case 3:
                    QnA = medium_QnA;
                    break;
                case 4:
                    QnA = hard_QnA;
                    break;

            }

            //Quiz loop the Questions and the input from the user and chack whether the answer was correct for the Base level
            for (int i = 0; i < 5; i++)
            {
                // Centered Heading for the Quiz, Score and the questions left to answer.
                quizHeading = "----------Maori Quiz----------";
                Console.SetCursorPosition((Console.WindowWidth - quizHeading.Length) / 2, Console.CursorTop);
                Console.WriteLine(quizHeading);
                Console.WriteLine(name + "'s score : " + score);
                Console.WriteLine("Questions left : " + questions_left);

                //Put a while loop for asking the user for input on the question and response on invalid input.
                do
                {
                    Console.WriteLine(QnA[0, i]);
                    input[i] = Console.ReadLine().ToUpper();
                    if (!input[i].Equals("A") && !input[i].Equals("B") && !input[i].Equals("C") && !input[i].Equals("D"))
                    {
                        Console.WriteLine("\nThe answer that you have entered is invalid. Please choose a option from the given question.\n");
                    }
                } while (!input[i].Equals("A") && !input[i].Equals("B") && !input[i].Equals("C") && !input[i].Equals("D"));

                //Checking if the answer was incorrect of correct.
                if (input[i] == QnA[1, i])
                {
                    Console.WriteLine("\nRight answer " + name);
                    score += 2;
                    questions_left--;
                }
                else
                {
                    Console.WriteLine("\nNice try " + name);
                    Console.WriteLine("Answer : " + QnA[1, i]);
                    questions_left--;
                }
                //Progress to the other question after pressing enter.
                Console.WriteLine("\nPress Enter to continue"); Console.ReadKey(); Console.Clear();
            }//end of loop

            return score;
        }

        static void Summary(string name, int score)
        {
            Console.WriteLine("-------------------\nReport\n-------------------");
            Console.WriteLine("Quiz Player Name : " + name + "\nQuiz Player Score : " + score);

            Console.WriteLine("\nThe passing criteria for the quiz is 6 points or above.");
            if (score == 10)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Congratulations you have passed the test with flying colours.", Console.ForegroundColor);
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (score > 5)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Amazing You have passed the test.", Console.ForegroundColor);
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Your points are insufficient to pass the quiz. Better luck next time", Console.ForegroundColor);
                Console.ForegroundColor = ConsoleColor.White;
            }
        }//End of summary

        static void QuizRedo(string name)
        {
            string strRedo;
            char redo = ' ';
            while (redo != 'Y' && redo != 'N')
            {
                Console.WriteLine("Do you want to redo the Maori Quiz (Yes/No) : ");
                try
                {
                    redo = Console.ReadLine().ToUpper()[0];
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Error - You did not enter anything");
                }
                finally
                {
                    if (redo == 'Y')
                    {
                        Console.Clear();
                        Level(name);
                    }
                    else if (redo == 'N')
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\nGoodBye ");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.WriteLine("\nInvalid input, Please consider entering something else");
                    }
                }
            }
        } // End of QuizRedo method
    }
}