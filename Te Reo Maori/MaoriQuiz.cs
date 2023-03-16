using System.Runtime.CompilerServices;

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
            string About = "Welcome to the Maori Quiz! This quiz consists of multiple choice questions," +
                           " where you will be presented with a question and four possible answers: A, B, C, or D." +
                           " You will need to select the option that you believe is the correct answer to the question." +
                           "\r\n\r\nTo answer a question, simply type the alphabet that belongs to the option that you believe is correct and press enter." +
                           " If you get the answer correct you will see the live score change on top right of the corner." +
                           " Else You will see the right answer next line. You can also see how many question your are left with also on the top right corner." +
                           "\r\n\r\nYou must answer all questions to complete the quiz." +
                           " Once you have answered the final question, click the \"Finish\" button to submit your answers and see your report.\r\n\r\nGood luck, and have fun!" +
                           " \r\n\r\n>>> Press enter to continue <<<";

            Console.WriteLine(About);

            Console.ReadKey();
            Console.Clear();

            //Menu
            Menu();

        }



        static void Menu()
        {
            string name = "", userchange = "";
            int userlevel = 0;
            
            Console.WriteLine("----------\nMaori Quiz\n----------");

            while (name == "")
            {
                Console.WriteLine("\nPlease enter your name : ");
                name = Console.ReadLine();
            } 
            
            //FIX ISSUE if the user enters nothing.
            while (userlevel != 1 && userlevel != 2 && userlevel != 3 && userlevel != 4 )
            {
                Console.WriteLine("\nWhat is your desired Difficulty Level (Choose number) : ");
                Console.WriteLine("1. Easier than easy (base)\n2. Beginner (Easy)\n3. Standard (Medium)\n4. Expert (Hard)\n");
                userlevel = Convert.ToInt32(Console.ReadLine());
                if (userlevel != 1 && userlevel != 2 && userlevel != 3 && userlevel != 4)
                {
                    Console.WriteLine($"\nInvalid input, {userlevel} is not a level.\n");
                }
            }


            Console.WriteLine("\n" + name + " please press Enter to Move on");
            Console.ReadKey();
            Console.Clear();

            switch (userlevel)
            {
                case 1:
                    Base();
                    break;
                case 2:
                    Easy();
                    break;
                case 3:
                    Medium();
                    break;
                case 4:
                    Hard();
                    break;

            }
        }

        static void Base()
        {
            string quizheading = "----------Maori Quiz----------";
            Console.SetCursorPosition((Console.WindowWidth - quizheading.Length) / 2, Console.CursorTop);
            Console.WriteLine(quizheading);

            Console.WriteLine();
        }

        static void Easy()
        {

        }

        static void Medium()
        {

        }

        static void Hard()
        {

        }
        
    }
}