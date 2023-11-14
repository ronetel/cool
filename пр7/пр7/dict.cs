using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace пр7
{
    internal class dict
    {
        public static string Dick()
        {
            Console.Clear();

            Console.WriteLine("Выберите диск:");
            DriveInfo[] drives = DriveInfo.GetDrives();

            foreach (DriveInfo drive in drives)
            {
                Console.Write($"  {drive.Name}");

                double totalSpaceGB = drive.TotalSize / (1024.0 * 1024.0 * 1024.0);
                double freeSpaceGB = drive.TotalFreeSpace / (1024.0 * 1024.0 * 1024.0);

                Console.Write($"  Общее место: {totalSpaceGB:F2} ГБ");
                Console.WriteLine($" Свободное место: {freeSpaceGB:F2} ГБ");
            }
            return drives[menu.show(1, drives.Length - 1)].Name;
        }

        public static void pops(string path)
        {
            Console.Clear();
            Console.SetCursorPosition(90, 0);
            Console.WriteLine("Папки");
            Console.WriteLine("--------------------------------------------------------------------------------------------");
            Console.WriteLine("\tНазвание: \t\t\t\t\t Дата созданя:");
            string[] a = Directory.GetDirectories(path);
            string[] b = Directory.GetFiles(path);
            int i = 3;
            foreach (var d in a )
            {
                try
                {


                    string directoryName = Path.GetFileName(d);
                    DirectoryInfo dirInfo = new DirectoryInfo(d);
                    Console.WriteLine($"  {directoryName}");
                    Console.SetCursorPosition(120, i);
                    Console.WriteLine($"  {dirInfo.CreationTime}");
                    i++;
                } catch
                {
                    continue;
                }
            }
            
            foreach (var file in b)
            {
                try
                {
                    string fileName = Path.GetFileName(file);
                    DateTime creationTime = File.GetCreationTime(file);
                    Console.WriteLine($"  {fileName}");
                    Console.SetCursorPosition(120, i);
                    Console.WriteLine($"  {creationTime}");
                    i++;
                }
                catch
                {
                    continue;
                }
            }
            int pos = menu.show(3, a.Length + b.Length );
            if (pos <= a.Length)
                pops(a[pos ]);
            else
                Process.Start(new ProcessStartInfo { FileName = b[pos - a.Length], UseShellExecute = true });
            
        }
    }
}

