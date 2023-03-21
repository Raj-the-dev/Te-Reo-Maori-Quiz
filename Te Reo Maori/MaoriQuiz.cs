using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace Te_Reo_Maori
{
    internal class MaoriQuiz
    {
        static void Main(string[] args)
        {
            /*
             * What is Maori(language) ?
             * Maori is an Austronesian language primarily spoken in the North Island in New Zealand.
             * Maori is not only the native language of New Zealand, but also the native people of New Zealand. Prior to European settlement in the 1800's,
             * Maori was the only language spoken in NZ.

             * This project helps people learn Maori which is one of the most beautiful and well done language that everyone should know about.

             * By Giriraj Singh Rathore
             */



            //Algorithem
            /*
            1. The user initiates the program.

            2.The user provides their name, and if no name is entered, they are prompted to enter their name again.

            3. The user selects a difficulty level, and if an invalid or empty input is entered, they will be prompted to enter the level again until a valid input is provided.

            4. The console is cleared and the quiz begins with the selected difficulty level.

            5. The user is presented with a question and prompted to choose an option from A, B, C, and D.

              a. If the answer entered is invalid, the user will be instructed to enter a valid answer.
              b. If the answer entered is incorrect, the correct answer will be displayed, the number of questions left to answer will be updated, and the user will be prompted to press "Enter" to move on to the next question.
              c. If the answer entered is correct, the user will move on to the next question, and their score will be increased by 10 points.

            6. The 5th step will be repeated for 5 questions.

            7. The user's score will be output, and their quiz result will be provided.

            8. The user will be prompted whether they would like to redo the quiz. 
            */

            //About The Maori Quiz
            Info();


        }
        static void Info()
        {
            Console.WriteLine("----------\nMaori Quiz\n----------\n\n");
            string about = "Welcome to the Maori Quiz! This quiz consists of multiple choice questions," +
                           " where you will be presented with a question and four possible answers: A, B, C, or D." +
                           " You will need to select the option that you believe is the correct answer to the question." +
                           "\r\n\r\nTo answer a question, simply type the alphabet that belongs to the option that you believe is correct and press enter." +
                           " If you get the answer correct you will see the live score change on top right of the corner.The score will increase in 2 so for each right question you will get 2 points." +
                           " Else You will see the right answer next line. You can also see how many question your are left with also on the top right corner." +
                           "\r\n\r\nYou must answer all questions to complete the quiz." +
                           " Once you have answered the final question, you will be able to see your report.\r\n\r\nGood luck, and have fun!" +
                           " \r\n\r\n>>> Press enter to continue <<<";

            Console.WriteLine(about);

            Console.ReadKey();
            Console.Clear();

            //Menu
            Menu();

        }



        static void Menu()
        {
            string name = "", strUserLevel;
            int userLevel = 0;

            Console.WriteLine("----------\nMaori Quiz\n----------");

            //Asking user for name
            while (name == "")
            {
                Console.WriteLine("\nPlease enter your name : ");
                name = Console.ReadLine();
            }

            //Asking user for difficulty level
            while (userLevel != 1 && userLevel != 2 && userLevel != 3 && userLevel != 4 && userLevel != null)
            {
                Console.WriteLine("\nWhat is your desired Difficulty Level (Choose number only) : ");
                Console.WriteLine("1. Easier than easy (base)\n2. Beginner (Easy)\n3. Standard (Medium)\n4. Expert (Hard)\n");
                strUserLevel = Console.ReadLine();
                if (strUserLevel.Length != 0)
                {
                    userLevel = int.Parse(strUserLevel);
                }
                

                if (userLevel != 1 && userLevel != 2 && userLevel != 3 && userLevel != 4)
                {
                    Console.WriteLine($"\nInvalid input, {userLevel} is not a level.\n");
                }
            }


            Console.WriteLine("\n" + name + " please press Enter to Move on");
            Console.ReadKey();
            Console.Clear();
            
            //using the switch to change the method
            switch (userLevel)
            {
                case 1:
                    Base(name);
                    break;
                case 2:
                    Easy(name);
                    break;
                case 3:
                    Medium(name);
                    break;
                case 4:
                    Hard(name);
                    break;
            }
        } //End of Main Method
        
        static void Base(string name)
        {
            //All variables in the method
            string quizHeading;
            string[] base_questions = new string[5];
            string[] base_answers = new string[5];
            string[] base_input = new string[5];
            int score = 0, questions_left = base_questions.Length;

            //All 5 questions
            base_questions[0] = "\n\n1. What is the official language of New Zealand?" +
                                "\nA. Japanese\nB. Maori\nC. Spanish\nD. French\n";

            base_questions[1] = "\n\n2. What is the meaning of the Maori word \"kia ora\"?" +
                                "\nA. Goodbye\nB. Hello\nC. Thank you\nD. Welcome\n";

            base_questions[2] = "\n\n3. What is the name of the Maori New Year celebration?" +
                                "\nA. Matariki\nB. Mardi Gas\nC. Cinco de Mayo\nD. None of the Above\n";

            base_questions[3] = "\n\n4. What is the Maori work for \"Love\"" +
                                "\nA. Aroha\nB. Whakapapa\nC. Rongo\nD. Kai\n";

            base_questions[4] = "\n\n5. Which of the following means \"Food\" in Maori" +
                                "\nA. Mana\nB. Haka\nC. Kai\nD. None of the Above\n";

            //Answer for the questions
            base_answers[0] = "B";
            base_answers[1] = "B";
            base_answers[2] = "A";
            base_answers[3] = "A";
            base_answers[4] = "C";

            //quiz loop for the Base level
            for (int i = 0; i < base_questions.Length; i++)
            {
                quizHeading = "----------Maori Quiz----------";
                Console.SetCursorPosition((Console.WindowWidth - quizHeading.Length) / 2, Console.CursorTop);
                Console.WriteLine(quizHeading);
                Console.WriteLine(name + "'s score : " + score);
                Console.WriteLine("Questions left : " + questions_left);

                while (base_input[i] != "A" && base_input[i] != "B" && base_input[i] != "C" && base_input[i] != "D")
                {
                    Console.WriteLine(base_questions[i]);
                    base_input[i] = Console.ReadLine().ToUpper();
                    if (base_input[i] != "A" && base_input[i] != "B" && base_input[i] != "C" && base_input[i] != "D")
                    {
                        Console.WriteLine("\nThe answer that you have entered is invalid. Please choose a option from the given question.\n");
                    }
                }


                if (base_input[i] == base_answers[i])
                {
                    Console.WriteLine("\nRight answer " + name);
                    score += 2;
                    questions_left--;
                }
                else
                {
                    Console.WriteLine("\nNice try " + name);
                    Console.WriteLine("Answer : " +base_answers[i]);
                    questions_left--;
                }
                Console.WriteLine("\nPress Enter to continue");
                Console.ReadKey();
                Console.Clear();
            }//end of loop


        } //End of Base Method

        static void Easy(string name)
        {
            //All variable in Easy level
            string quizHeading;
            string[] easy_questions = new string[5];
            string[] easy_answers = new string[5];
            string[] easy_input = new string[5];
            int score = 0, questions_left = easy_questions.Length;

            //Question for easy level
            easy_questions[0] = "\n\n1. How many vowels does the Maori language have? (Please choose alphabet only)" +
                                "\nA. 5\nB. 6\nC. 7\nD. 9\n";

            easy_questions[1] = "\n\n2. Which of the following words means \"Thank You\" in Maori?" +
                                "\nA. Ka kite\nB. Kia ora\nC. Aroha\nD. Tapu\n";

            easy_questions[2] = "\n\n3. What is the name of the Maori New Year celebration?" +
                                "\nA. Matariki\nB. Mardi Gas\nC. Cinco de Mayo\nD. None of the Above\n";

            easy_questions[3] = "\n\n4. What is the Maori words for \"Family\"" +
                                "\nA. Tapu\nB. Whakapapa\nC. Rongo\nD. Whanau\n";

            easy_questions[4] = "\n\n5. Which of the following means \"Food\" in Maori" +
                                "\nA. Mana\nB. Haka\nC. Kai\nD. None of the Above\n";

            //Answers for the question 
            easy_answers[0] = "B";
            easy_answers[1] = "A";
            easy_answers[2] = "A";
            easy_answers[3] = "D";
            easy_answers[4] = "C";

            //Easy quiz loop 
            for (int i = 0; i < easy_questions.Length; i++)
            {
                quizHeading = "----------Maori Quiz----------";
                Console.SetCursorPosition((Console.WindowWidth - quizHeading.Length) / 2, Console.CursorTop);
                Console.WriteLine(quizHeading);
                Console.WriteLine(name + "'s score : " + score);
                Console.WriteLine("Questions left : " + questions_left);

                while (easy_input[i] != "A" && easy_input[i] != "B" && easy_input[i] != "C" && easy_input[i] != "D")
                {
                    Console.WriteLine(easy_questions[i]);
                    easy_input[i] = Console.ReadLine().ToUpper();
                    if (easy_input[i] != "A" && easy_input[i] != "B" && easy_input[i] != "C" && easy_input[i] != "D")
                    {
                        Console.WriteLine("\nThe answer that you have entered is invalid. Please choose a option from the given question.\n");
                    }
                }


                if (easy_input[i] == easy_answers[i])
                {
                    Console.WriteLine("\nRight answer " + name);
                    score += 2;
                    questions_left--;
                }
                else
                {
                    Console.WriteLine("\nNice try " + name);
                    Console.WriteLine("Answer : " + easy_answers[i]);
                    questions_left--;
                }
                Console.WriteLine("\nPress Enter to continue");
                Console.ReadKey();
                Console.Clear();

            }//end of loop


        }//End of Easy Method
        static void Medium(string name)
        {
            //All variables the medium level
            string quizHeading;
            string[] medium_questions = new string[5];
            string[] medium_answers = new string[5];
            string[] medium_input = new string[5];
            int score = 0, questions_left = medium_questions.Length;

            //Questions for Medium level
            medium_questions[0] = "\n\n1. What is the meaning of \"mana\" in Maori?" +
                                "\nA. Respect\nB. Love\nC. Power\nD. Hate\n";

            medium_questions[1] = "\n\n2. What is the name of the traditional Maori food cooked in an earth oven?" +
                                "\nA. Haka\nB. Hangi\nC. Kai\nD. Awa\n";

            medium_questions[2] = "\n\n3. What is the name of the Maori Creation story?" +
                                "\nA. The dreamtime\nB. The Great Flood\nC. The legend of Maui\nD. None of the Above\n";

            medium_questions[3] = "\n\n4. What is the Maori word for \"Blessing\" or \"prayer\"" +
                                "\nA. Kawa\nB. Karakia\nC. Rongo\nD. Tapu\n";

            medium_questions[4] = "\n\n5. What is the Maori word for \"Rain\"" +
                                "\nA. Whenua\nB. AWA\nC. Ua\nD. None of the Above\n";

            //Answers for the medium level
            medium_answers[0] = "A";
            medium_answers[1] = "B";
            medium_answers[2] = "C";
            medium_answers[3] = "B";
            medium_answers[4] = "C";


            //Medium quiz loop
            for (int i = 0; i < medium_questions.Length; i++)
            {
                quizHeading = "----------Maori Quiz----------";
                Console.SetCursorPosition((Console.WindowWidth - quizHeading.Length) / 2, Console.CursorTop);
                Console.WriteLine(quizHeading);
                Console.WriteLine(name + "'s score : " + score);
                Console.WriteLine("Questions left : " + questions_left);

                while (medium_input[i] != "A" && medium_input[i] != "B" && medium_input[i] != "C" && medium_input[i] != "D")
                {
                    Console.WriteLine(medium_questions[i]);
                    medium_input[i] = Console.ReadLine().ToUpper();
                    if (medium_input[i] != "A" && medium_input[i] != "B" && medium_input[i] != "C" && medium_input[i] != "D")
                    {
                        Console.WriteLine("\nThe answer that you have entered is invalid. Please choose a option from the given question.\n");
                    }
                }


                if (medium_input[i] == medium_answers[i])
                {
                    Console.WriteLine("\nRight answer " + name);
                    score += 2;
                    questions_left--;
                }
                else
                {
                    Console.WriteLine("\nNice try " + name);
                    Console.WriteLine("Answer : " + medium_answers[i]);
                    questions_left--;
                }
                Console.WriteLine("\nPress Enter to continue");
                Console.ReadKey();
                Console.Clear();

            }//end of loop

            Report(name, score, medium_questions, medium_answers, medium_input);

        }//End of medium method
        static void Hard(string name)
        {
            //All variables the Hard level
            string quizHeading;
            string[] hard_questions = new string[5];
            string[] hard_answers = new string[5];
            string[] hard_input = new string[5];
            int score = 0, questions_left = hard_questions.Length;

            //Questions for Hard level
            hard_questions[0] = "\n\n1. What is the meaning of the Maori word \"whare\"?" +
                                "\nA. House or Building\nB. Land or Trritory\nC. Ocean or sea\nD. River or Lake\n";

            hard_questions[1] = "\n\n2. What is the name of the Maori musical instrument made from a conch shell?" +
                                "\nA. Poi\nB. Kete\nC. Putatara\nD. Awa\n";

            hard_questions[2] = "\n\n3. What is the name of the Maori god of war?" +
                                "\nA. tane Mahuta\nB. Tumatauenga\nC. Tangaroa\nD. None of the Above\n";

            hard_questions[3] = "\n\n4. What is the meaning of \"whenua\" in Maori?" +
                                "\nA. Land or Earth\nB. Sky or heavens\nC. Water or sea\nD. Cave or Hell\n";

            hard_questions[4] = "\n\n5. What is the Maori word for \"Rain\"" +
                                "\nA. Whenua\nB. AWA\nC. Ua\nD. None of the Above\n";

            //Answers for the Hard level
            hard_answers[0] = "A";
            hard_answers[1] = "C";
            hard_answers[2] = "B";
            hard_answers[3] = "A";
            hard_answers[4] = "C";


            //Hard quiz loop
            for (int i = 0; i < hard_questions.Length; i++)
            {
                quizHeading = "----------Maori Quiz----------";
                Console.SetCursorPosition((Console.WindowWidth - quizHeading.Length) / 2, Console.CursorTop);
                Console.WriteLine(quizHeading);
                Console.WriteLine(name + "'s score : " + score);
                Console.WriteLine("Questions left : " + questions_left);

                while (hard_input[i] != "A" && hard_input[i] != "B" && hard_input[i] != "C" && hard_input[i] != "D")
                {
                    Console.WriteLine(hard_questions[i]);
                    hard_input[i] = Console.ReadLine().ToUpper();
                    if (hard_input[i] != "A" && hard_input[i] != "B" && hard_input[i] != "C" && hard_input[i] != "D")
                    {
                        Console.WriteLine("\nThe answer that you have entered is invalid. Please choose a option from the given question.\n");
                    }
                }


                if (hard_input[i] == hard_answers[i])
                {
                    Console.WriteLine("\nRight answer " + name);
                    score += 2;
                    questions_left--;
                }
                else
                {
                    Console.WriteLine("\nNice try " + name);
                    Console.WriteLine("Answer : " + hard_answers[i]);
                    questions_left--;
                }
                Console.WriteLine("\nPress Enter to continue");
                Console.ReadKey();
                Console.Clear();

            }//end of loop

            Report(name,score, hard_questions, hard_answers, hard_input);

        }//End of Hard level
        static void Report(string name,int score,string[] questions, string[] answer, string[] input)
        {
            string skip = "";
            Console.WriteLine("-------------------\nSummary\n-------------------");
            for (int i = 0; i < questions.Length;)
            {
                Console.WriteLine(questions[i]);
                if (answer[i] == input[i])
                {
                    Console.WriteLine("\nCorrect");
                }
                else
                {
                    Console.WriteLine("\nIncorrect\t Answer : " + answer[i]);
                }

                Console.WriteLine("---------------------------------------------");

                Console.WriteLine("Press Enter to move on to Report");
                Console.ReadLine();
                Console.Clear();
            }
        }//End of Report
    }
}