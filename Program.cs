using System;
using System.IO;
using CommandLine;

namespace Dirmap {
    public class Program {
        public static void Main(string[] args) {
            Parser.Default.ParseArguments<Options>(args).WithParsed<Options>(o => {
                if(!Directory.Exists(o.Target)) Exit("The specified directory cannot be found.");
                else if(o.Depth <= 0) Exit("Depth value cannot be less nor equal to zero.");
                else {
                    // Safe to do the actual stuff
                    var root = Dirtree.From(o.Target, o.Depth);
                    Console.WriteLine(root.ToString());
                }
            });
        }

        public static void Exit(string errorMessage) {
            ConsoleColor prev = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\nError: ");
            Console.ForegroundColor = prev;
            Console.WriteLine(errorMessage);
            Environment.Exit(-1);
        }
    }
}