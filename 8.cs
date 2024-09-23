using System;

class words
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the word : ");
        string word = Console.ReadLine();
        if (word.Length > 3)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.Write(word[i]);
            }
            Console.Write(word);
            for (int i = 0; i < 3; i++)
            {
                Console.Write(word[i]);
            }
        }
        if (word.Length <= 3)
        {
            for (int i = 0; i < word.Length; i++)
            {
                Console.Write(word[i]);
            }
            Console.Write(word);
            for (int i = 0; i < word.Length; i++)
            {
                Console.Write(word[i]);
            }
        }

    }
}