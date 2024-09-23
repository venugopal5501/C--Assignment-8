using System;
delegate string spa(string n);
class space
{
    public static string spaces(string n)
    {
        int count = 0;
        foreach (char c in n)
        {
            if (c == ' ')
            {
                count++;
            }
        }
        Console.Write(count);
        return n;
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the Word or sentence : ");
        string sentence = Console.ReadLine();
        spa s = new spa(spaces);
        string sc;
        sc = s(sentence);

    }
}