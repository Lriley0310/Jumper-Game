﻿// See https://aka.ms/new-console-template for more information
using unit03_jumper;


namespace unit03_jumper
{
    /// <summary>
    /// The program's entry point.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Starts the program using the given arguments.
        /// </summary>
        /// <param name="args">The given arguments.</param>
        static void Main(string[] args)
        {
            Director director = new Director();
            director.StartGame();
        }
    }
}