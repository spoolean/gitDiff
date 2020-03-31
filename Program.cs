using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitDiff
{
    class Program
    {
        static void Main(string[] args)
        {
            bool endProgram = false;

            string currentDirectory = ($"C:\\Users\\{Environment.UserName}");

            while (!endProgram)
            {
                string Input = UI.ReadLine(currentDirectory+">");

                string[] inputArray = Input.Split(' ');

                if (inputArray[0] == "end")
                {
                    endProgram = true;
                }
                else if (inputArray[0] == "diff")
                {
                    try
                    {

                    }
                    catch (Exception)
                    {
                        Console.WriteLine("This command is not supported by the diff utility.");
                        UI.line();
                    }
                }
                else if (inputArray[0] == "dir")
                {
                    UI.line();
                    try
                    {
                        if (inputArray[1] == "/f")
                        {
                            string[] files = Dir.Files(currentDirectory);
                            foreach (var item in files)
                            {
                                Console.WriteLine(item);
                            }
                            UI.line();
                        }
                        else if (inputArray[1] == "/d")
                        {
                            string[] files = Dir.Directories(currentDirectory);
                            foreach (var item in files)
                            {
                                Console.WriteLine(item);
                            }
                            UI.line();
                        }
                        else if (inputArray[1] == "/a")
                        {
                            string[] files = Dir.All(currentDirectory);
                            foreach (var item in files)
                            {
                                Console.WriteLine(item);
                            }
                            UI.line();
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("I know about this error but dont know how to fix it, i really watn this to do /a.");
                        UI.line();
                    }
                    
                }
                else if (inputArray[0] == "cd")
                {
                    try
                    {
                        currentDirectory = FileHandler.Cd(currentDirectory, inputArray[1]);
                        UI.line();
                    }
                    catch (IndexOutOfRangeException)
                    {
                        Console.WriteLine(currentDirectory);
                        UI.line();
                    }
                                                            
                }
                else if (inputArray[0] == "help")
                {
                    try
                    {
                        if (inputArray[1] == "diff")
                        {
                            UI.line();
                            Console.WriteLine("There are several command you can do: ");
                            Console.WriteLine("Type 'different' to confirm whether the two files are different");
                            Console.WriteLine("Type 'line {integer}' to test the differences on that specific line");
                            UI.line();
                        }
                        else if (inputArray[1] == "cd")
                        {
                            UI.line();
                            Console.WriteLine("There are several command you can do: ");
                            Console.WriteLine("Type '..' to go up to the parent directory.");
                            Console.WriteLine("Type anything after cd to move to that directory,");
                            Console.WriteLine("use the dir command for all directories");
                            UI.line();
                        }
                        else if (inputArray[1] == "dir")
                        {
                            UI.line();
                            Console.WriteLine("There are several command you can do: ");
                            Console.WriteLine("Type '/a' for everything in the current directory");
                            Console.WriteLine("Type '/f' for everything that is a file");
                            Console.WriteLine("Type '/d for all subdirectories'");
                            UI.line();
                        }
                    }
                    catch (IndexOutOfRangeException)
                    {
                        UI.line();
                        Console.WriteLine("There are several commands you can do:");
                        Console.WriteLine("Type 'end'       to end the program and close the console.");
                        Console.WriteLine("Type 'help diff' to see the commands relating to the diff command.");
                        Console.WriteLine("Type 'help cd'   to change the directory currently being looked at.");
                        Console.WriteLine("Type 'help dir'  to see help relating to the dir command");
                        UI.line();
                    }
                    
                     
                }
                else
                {
                    Console.WriteLine($"'{inputArray[0]}' is not recognized as an internal or external command, operable program or batch file.");
                    UI.line();
                }
            }
            Environment.Exit(0);
        }
    }
}
