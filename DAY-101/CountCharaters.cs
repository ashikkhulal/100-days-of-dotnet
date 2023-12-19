using System;

namespace ConsoleApp
{
    public class CountCharaters
    {
        private int CountCharacters()
        {
            int count = 0;
            string filePath = @"C:\Users\ashik\Desktop\Repos\ConsoleApp\ConsoleApp\data.txt";
            using (StreamReader streamReader = new StreamReader(filePath))
            {
                string content = streamReader.ReadToEnd();
                count = content.Length;
                Thread.Sleep(2000);
            }

            return count;
        }

        public async void ReadCharacters()
        {
            Task<int> task = new Task<int>(CountCharacters);
            task.Start();

            Console.WriteLine("Processing file... please wait");
            Thread.Sleep(3000);
            int count = await task;

            Console.WriteLine("Total: " + count.ToString() + " characters found.");
        }
    }
}
