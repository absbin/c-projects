using System;
using System.IO;
using System.Reflection;

namespace FileSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // string cd_path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            // string cd_path = Path.GetDirectoryName(Environment.CurrentDirectory);
            string cd_path = System.IO.Directory.GetCurrentDirectory();
            // string rootPath = "Folder\\";
            string rootPath = cd_path + @"\Folder\";
            Console.WriteLine(rootPath);
            // string[] dirs = Directory.GetDirectories(rootPath, "*", SearchOption.TopDirectoryOnly);
            string[] dirs = Directory.GetDirectories(rootPath, "*", SearchOption.AllDirectories);
            Console.WriteLine(dirs);
            foreach (var item in dirs)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("===========================================================");
            string[] files = Directory.GetFiles(rootPath, "*", SearchOption.AllDirectories);
            foreach (var file in files)
            {
                Console.WriteLine(file);
                Console.WriteLine(Path.GetFileName(file));
                Console.WriteLine(Path.GetFileNameWithoutExtension(file));
                Console.WriteLine($"{Path.GetFileName(file)}: {Path.GetDirectoryName(file)}");
                var fileinfo = new FileInfo(file);
                Console.WriteLine($"{Path.GetFileName(file)}: {fileinfo.Length} bytes");
                bool dirExist = Directory.Exists(rootPath + "dirC");
                if (dirExist)
                {
                    Console.WriteLine("Directory exists.");
                }
                else
                {
                    Console.WriteLine("Directory doesn't exists!");
                }

            }
        }



    }

}


