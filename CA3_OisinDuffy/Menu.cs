﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA3_OisinDuffy
{


    internal class Menu
    {
        public string[] Options { get; set; }
        public Menu(string[] options)
        {
            Options = options;
        }


        public int GetChoice()
        {
            int choice;
            string input;
            do
            {
                for (int i = 0; i < Options.Length; i++)
                {
                    Console.WriteLine($"{i + 1} for {Options[i]}");
                }
                input = Console.ReadLine();
            }

            while (!(int.TryParse(input, out choice) && choice > 0 && choice <= Options.Length));
            return choice;
        }

    }

}