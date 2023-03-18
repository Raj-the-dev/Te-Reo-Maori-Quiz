using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace Te_Reo_Maori
{
    internal class MaoriQuiz
    {
        static void Main(string[] args)
        {
            /* What is Maori(language) ?
           Maori is an Austronesian language primarily spoken in the North Island in New Zealand.
          Maori is not only the native language of New Zealand, but also the native people of New Zealand. Prior to European settlement in the 1800's,
          Maori was the only language spoken in NZ.

          This project helps people learn Maori which is one of the most beautiful and well done language that everyone should know about.

          By Giriraj Singh Rathore */

            /*
            1. User enters into the Program.
            2. input name. If the input is bigger than 20 than ask user to enter nick name.
            3. choose difficulty level. on that condition if the user does not input the right input then tell user to input the right difficulty.
            4. Clear console and move to the quiz with the selected difficulty.
            5. Answer quiz.

              a. If the Answer is invalid then repeat the instructions and tell user to input the answer again
              b. If the Answer is wrong then display the answer. And update the question left to answer.Then tell user to press "Enter" to mover to next question.
              c. If the Answer is right then move to next question and increase the score by 10 points.

            6. Repeat the 5th step for 5 question.
            7. Output the score and give their result. 
            8. Ask the user whether he or she wants to re-do the quiz
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
                           " If you get the answer correct you will see the live score change on top right of the corner." +
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

            base_questions[3] = "\n\n4.What is the Maori work for \"Love\"" +
                                "\nA. Aroha\nB. Whakapapa\nC. Rongo\nD. Kai\n";

            base_questions[4] = "\n\nWhich of the following means \" Food\" in Maori" +
                                "\nA. Mana\nB. Haka\nC. Kai\nD. None of the Above\n";

            //Answer for the questions
            base_answers[0] = "B";
            base_answers[1] = "B";
            base_answers[2] = "A";
            base_answers[3] = "A";
            base_answers[4] = "C";

            //quiz for the Base level
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
                    Console.WriteLine("Right answer " + name);
                    score += 2;
                    questions_left--;
                }
                else
                {
                    Console.WriteLine("Nice try " + name);
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
            easy_questions[0] = "\n\n1. What is the official language of New Zealand?" +
                                "\nA. Japanese\nB. Maori\nC. Spanish\nD. French\n";

            easy_questions[1] = "\n\n2. What is the meaning of the Maori word \"kia ora\"?" +
                                "\nA. Goodbye\nB. Hello\nC. Thank you\nD. Welcome\n";

            easy_questions[2] = "\n\n3. What is the name of the Maori New Year celebration?" +
                                "\nA. Matariki\nB. Mardi Gas\nC. Cinco de Mayo\nD. None of the Above\n";

            easy_questions[3] = "\n\n4.What is the Maori work for \"Love\"" +
                                "\nA. Aroha\nB. Whakapapa\nC. Rongo\nD. Kai\n";

            easy_questions[4] = "\n\nWhich of the following means \" Food\" in Maori" +
                                "\nA. Mana\nB. Haka\nC. Kai\nD. None of the Above\n";

            //Answers for the question 
            easy_answers[0] = "B";
            easy_answers[1] = "B";
            easy_answers[2] = "A";
            easy_answers[3] = "A";
            easy_answers[4] = "C";

            //Easy quiz
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
                    Console.WriteLine("Right answer " + name);
                    score += 2;
                    questions_left--;
                }
                else
                {
                    Console.WriteLine("Nice try " + name);
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
            medium_questions[0] = "\n\n1. What is the official language of New Zealand?" +
                                "\nA. Japanese\nB. Maori\nC. Spanish\nD. French\n";

            medium_questions[1] = "\n\n2. What is the meaning of the Maori word \"kia ora\"?" +
                                "\nA. Goodbye\nB. Hello\nC. Thank you\nD. Welcome\n";

            medium_questions[2] = "\n\n3. What is the name of the Maori New Year celebration?" +
                                "\nA. Matariki\nB. Mardi Gas\nC. Cinco de Mayo\nD. None of the Above\n";

            medium_questions[3] = "\n\n4.What is the Maori work for \"Love\"" +
                                "\nA. Aroha\nB. Whakapapa\nC. Rongo\nD. Kai\n";

            medium_questions[4] = "\n\nWhich of the following means \" Food\" in Maori" +
                                "\nA. Mana\nB. Haka\nC. Kai\nD. None of the Above\n";

            //Answers for the medium level
            medium_answers[0] = "B";
            medium_answers[1] = "B";
            medium_answers[2] = "A";
            medium_answers[3] = "A";
            medium_answers[4] = "C";


            //Medium quiz
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
                    Console.WriteLine("Right answer " + name);
                    score += 2;
                    questions_left--;
                }
                else
                {
                    Console.WriteLine("Nice try " + name);
                    questions_left--;
                }
                Console.WriteLine("\nPress Enter to continue");
                Console.ReadKey();
                Console.Clear();

            }//end of loop


        }//End of medium method
        static void Hard(string name)
        {

        }
        static void Results()
        {

        }
    }
}