using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var reader = new StreamReader(File.OpenRead("11002.csv"));
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(",");


                for (int i = 0; i < values.Length; i++)
                {
                    Console.Write(values[i] + " ");
                }
                Console.Write("\n");
            }
                
                
        }
    }
}
