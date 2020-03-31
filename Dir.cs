using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GitDiff
{
    class Dir
    {
        public static string[] Files(string currentDirectory)
        {
            List<string> files = new List<string>();

            string[] rawFiles = Directory.GetFiles(currentDirectory);

            foreach (var item in rawFiles)
            {
                files.Add(item);
            }

            return files.ToArray();
        }

        public static string[] Directories(string currentDirectory)
        {
            List<string> files = new List<string>();

            string[] rawDirectories = Directory.GetDirectories(currentDirectory);

            foreach (var item in rawDirectories)
            {
                files.Add(item);
            }

            return files.ToArray();
        }
        public static string[] All(string currentDirectory)
        {
            List<string> files = new List<string>();

            string[] rawFiles = Directory.GetFiles(currentDirectory);

            foreach (var item in rawFiles)
            {
                files.Add(item);
            }

            string[] rawDirectories = Directory.GetDirectories(currentDirectory);

            foreach (var item in rawDirectories)
            {
                files.Add(item);
            }

            return files.ToArray();
        }
    }
}
