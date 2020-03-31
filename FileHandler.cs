using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GitDiff
{
    class FileHandler
    {
        public static string[] choice(string text)
        {
            string[] array = File.ReadAllLines(text);
            return array;
        }
      
        public static string Cd(string CurrentPath, string NewExtension)
        {
            string newPath = CurrentPath;
            
            if (NewExtension.Contains("\\"))
            {
                string[] extensionArray = NewExtension.Split('\\');

                foreach (string item in extensionArray)
                {
                    if (item == "..")
                    {
                        Console.WriteLine(item);
                        try
                        {
                            newPath = newPath.Remove(CurrentPath.LastIndexOf("\\"));
                        }
                        catch (Exception)
                        {
                            newPath = newPath.Remove(CurrentPath.IndexOf("\\"));
                        }
                        
                    }
                    else
                    {
                        newPath += item + "\\";
                    }
                }
                if (System.IO.Directory.Exists(newPath)) { return newPath; }
            }
            else if (NewExtension == "..")
            {
                newPath = CurrentPath.Remove(CurrentPath.LastIndexOf("\\"));

                if (System.IO.Directory.Exists(newPath)) { return newPath; }
            }
            else if (System.IO.Directory.Exists(newPath + "\\" + NewExtension)) { return newPath + "\\" + NewExtension; }
            return CurrentPath;
        }
    }
}
