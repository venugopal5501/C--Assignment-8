using System;

class student
{
    public int regno;
    public string name;
    public void data()
    {
        Console.WriteLine("Enter Student RollNo : ");
        regno = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Student name : ");
        name = Console.ReadLine();
    }
}
class Marks : student
{
    public double sum = 0;
    public double average;
    public int count = 0;
    public int counts = 0;
    public void mark()
    {
        int a = 5;
        for (int i = 1; i <=a; i++)
        {
            Console.WriteLine("Enter Mark "+i);
            double add = Convert.ToInt32(Console.ReadLine());
            if(add>100 || add<0){
                Console.WriteLine("Please enter valid mark (1-100) : ");
                i--;
            }
            pass(add);
            fail(add);
            sum = sum + add;
        }
        average = sum / 5;
    }

    public int pass(double n)
    {
        if (n >= 50)
        {
            count++;
        }
        return count;
    }
    public int fail(double n)
    {
        if (n < 50)
        {
            counts++;
        }
        return counts;
    }
}

class Grade : Marks
{
    public void grade()
    {
        Console.WriteLine("Student Regno : " + regno);
        Console.WriteLine("Student Name : " + name);
        Console.WriteLine("Total : " + sum);
        Console.WriteLine("Average : " + average);
        if (average >= 80)
        {
            Console.WriteLine("Distinction");
        }
        else if (average >= 70 && average <= 79)
        {
            Console.WriteLine("Grade A");
        }
        else if (average >= 60 && average <= 69)
        {
            Console.WriteLine("Grade B");
        }
        else if (average >= 50 && average <= 59)
        {
            Console.WriteLine("Grade C");
        }
        else
        {
            Console.WriteLine("Grade F");
        }
        Console.WriteLine("Number of passed subjects : " + count);
        Console.WriteLine("Number of failed subjects : " + counts);
    
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Grade g = new Grade();
        g.data();
        g.mark();
        g.grade();

    }
}