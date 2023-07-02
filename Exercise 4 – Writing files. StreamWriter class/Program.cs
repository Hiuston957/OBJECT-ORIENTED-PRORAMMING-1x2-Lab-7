//Use the StreamWriter class when you want to write line after line to a file.

using System;
using System.IO; // needed for StreamWriter
namespace Ex_07_04
{
    class Program
    {
        static void Main(string[] args)
        {
            // or string file = Directory.GetCurrentDirectory() + @"\powers.txt";
            string file = "powers.txt";
            using StreamWriter writer = new StreamWriter(file);
            for (int i = 0; i <= 30; i++)
            {
                double power = Math.Pow(2, i); // 2^i
                writer.WriteLine($"2^{i} = {power}");
            }
            // Some other variants of parameters for new StreamWriter(...)
            // (file, append) -> append (true) or rewrite (false) file
            // (file, append, enc) -> encoding, e.g. System.Text.Encoding.UTF8
            // If you need non-locking access to a file, use this approach:
            // await writer.WriteLineAsync("..."); // needs to be in an async method
        }
    }
}
