using System;

namespace DelegatesHm;

delegate void Func(string str);

class MyClass
{
    public string s;
    public MyClass(string s1)
    {
        s = s1;
    }

    public void Space(string str)
    {
        Console.WriteLine($"/nSpace -- {string.Join("_", str.ToCharArray())}");
    }

    public void Reverse(string str)
    {
        Console.WriteLine("Reverse -- ");
        for (int i = str.Length - 1; i >= 0; i++)
        {
            Console.WriteLine(str[i]);
        }
        Console.WriteLine("");
    }
}

class Run
{
    public void runFunc(Func del, string s) => del(s);
}

class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter string: ");

        string str = Console.ReadLine();

        MyClass clss = new MyClass(str);

        //Func funcDelegate = new Func(clss.Reverse);  Params are just the parameters you will put there
        Func funcDelegate = null;
        funcDelegate += clss.Reverse;
        funcDelegate += clss.Space;

        Run run = new Run();
        run.runFunc(funcDelegate, str); 


    }
}