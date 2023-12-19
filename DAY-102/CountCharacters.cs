using System;

namespace ConsoleApp
{
    public class CountCharacters
    {
        private int CountChars()
        {
            int count = 0;
            string filePath = @"C:\Users\ashik\Desktop\Repos\ConsoleApp\ConsoleApp\data.txt";
            using (StreamReader streamReader = new StreamReader(filePath))
            {
                string content = streamReader.ReadToEnd();
                count = content.Length;
                Thread.Sleep(5000);
            }

            return count;
        }

        public async void ReadCharacters()
        {
            int count = 0;
            Thread thread = new Thread(() => 
            { 
                count = CountChars();
                Console.WriteLine("Total: " + count.ToString() + " characters found.");
            });
            thread.Start();

            Console.WriteLine("Processing file... please wait");
        }
    }
}
