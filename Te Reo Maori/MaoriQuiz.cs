﻿using System.Runtime.CompilerServices;

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
              b. If the Answer is wrong then display the answer and tell user to press "Enter" to mover to next question.
              c. If the Answer is right then move to next question and increase the score by 10 points.

            6. Repeat the 5th step for 10 question.
            7. Output the score and give a rewiew on their result. Ask the user whether he or she wants to re-do the quiz
            */

            //Menu
            Menu();
        }
        static void Menu()
        {
            string name, userchange = "";
            int userlevel = 0;
            
            Console.WriteLine("----------\nMaori Quiz\n----------");

            Console.WriteLine("\nHow may I address you? (name)");
            name = Console.ReadLine();
            if (name.Length > 20)
            {
                Console.WriteLine(name + " please enter a nick name that you will want to use : ");
                name = Console.ReadLine();
            }

            while (userlevel != 1 && userlevel != 2 && userlevel != 3 && userlevel != 4)
            {
                Console.WriteLine("\nWhat is your desired Difficulty Level (Choose number) : ");
                Console.WriteLine("1. Easier than easy (base)\n2. Beginner (Easy)\n3. Standard (Medium)\n4. Expert (Hard)\n");
                userlevel = Convert.ToInt32(Console.ReadLine());
            }


            Console.WriteLine("\n" + name + " please press Enter to Move on");
            Console.ReadKey();

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