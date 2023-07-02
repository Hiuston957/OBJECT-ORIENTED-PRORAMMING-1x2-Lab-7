/* Use the StreamReader class when you want to read line after line from a file.
StreamWriter has also a ReadToEnd method that reads all lines, however in such a case,
it may be simpler to use the File class.
Links:
• https://stackoverflow.com/a/3448307
*/
using System;
using System.IO; // needed for StreamReader
namespace Ex_07_02
{
    class Program
    {
        static void Main(string[] args)
        {
            string nextLine;
            string file = "song.txt"; // if it is in the same folder as program.exe
                                      // or use absolue path, e.g. @"C:\Users\..."
                                      // Use the StreamWriter class when you want to read line after line
                                      // "using" to correctly dispose the object afterwards
            using StreamReader reader1 = new StreamReader(file);
            for (int i = 1; ; i++)
            {
                nextLine = reader1.ReadLine();
                if (nextLine is not null)
                    Console.WriteLine(i + " " + nextLine);
                else
                    break;
            }
            Console.WriteLine();
            // The same, shorter - if you don't need index i
            using StreamReader reader2 = new StreamReader(file);
            while ((nextLine = reader2.ReadLine()) is not null)
                Console.WriteLine(nextLine + ", yo");
            // If you need non-locking access to a file, use this approach:
            // using FileStream stream = new FileStream(
            // file, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            // using StreamReader reader = new StreamReader(stream);
            // reader.ReadLine();
        }
    }
}
