using System;

class Program
{
    static void Main(string[] args)
    {
        string längstaSträng = Längst("äpple", "banan");
        Console.WriteLine("Den längsta strängen är: " + längstaSträng);

        int längstaHeltal = Längst(10, 20);
        Console.WriteLine("Det längsta heltalet är: " + längstaHeltal);
    }

    static string Längst(string sträng1, string sträng2)
    {
        if (sträng1.Length >= sträng2.Length)
        {
            return sträng1;
        }
        else
        {
            return sträng2;
        }
    }

    static int Längst(int tal1, int tal2)
    {
        if (tal1 >= tal2)
        {
            return tal1;
        }
        else
        {
            return tal2;
        }
    }
}