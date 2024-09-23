using System;
using System.IO;

class read
{
    public static void Main(string[] args)
    {
        FileStream fs = new FileStream("d://out1.txt", FileMode.OpenOrCreate, FileAccess.Read);
        StreamReader sr = new StreamReader(fs);
        string reading = sr.ReadToEnd();
        sr.Close();
        fs.Close();
        Console.WriteLine(reading);
    }
}