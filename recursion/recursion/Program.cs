using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace recursion
{
    class MainClass
    {
        static void emptySpace(int level)
        {
            for (int i = 0; i < level * 2; i++)
                Console.Write(" ");
        }

        static void Ex4(string path, int level)
        {
            if (level > 2)
                return;
            try
            {
                DirectoryInfo directory = new DirectoryInfo(path);
                FileInfo[] files = directory.GetFiles();
                DirectoryInfo[] directories = directory.GetDirectories();

                foreach (FileInfo file in files)
                {
                    emptySpace(level);
                    Console.WriteLine(file.Name);
                }
                foreach (DirectoryInfo dInfo in directories)
                {
                    emptySpace(level);
                    Console.WriteLine(dInfo.Name);
                    Ex4(dInfo.FullName, level + 1);
                }
            }
            catch (Exception e)
            {

            }
        }

    }
}