using System;

namespace stringMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string degisken = "Dersimiz CSharp Hosgeldiniz!";
            string degisken2 = "Dersimiz";

            Console.WriteLine("Uzunluğu : " + degisken.Length);
            Console.WriteLine(degisken.ToLower());
            Console.WriteLine(degisken.ToUpper());
            Console.WriteLine(String.Concat(degisken, "Merhaba "));

            Console.WriteLine(degisken.CompareTo(degisken2));//0,1,-1
            Console.WriteLine(String.Compare(degisken, degisken2, true));//0,1,-1
            Console.WriteLine(degisken.Contains(degisken2));
            Console.WriteLine(degisken.EndsWith("Hosgeldiniz!"));
            Console.WriteLine(degisken.IndexOf("CSharp"));

            Console.WriteLine(degisken.Insert(0, "Merhaba sa "));
            Console.WriteLine(degisken.LastIndexOf("i"));
            Console.WriteLine(degisken + degisken2.PadLeft(30));
            Console.WriteLine(degisken + degisken2.PadLeft(30), "*");
            Console.WriteLine(degisken + degisken2.PadRight(50, '-') + degisken2);

            Console.WriteLine(degisken.Remove(10));
            Console.WriteLine(degisken.Remove(5,3));

            Console.WriteLine(degisken.Replace("CSharp","C#"));
            Console.WriteLine(degisken.Replace(" ", ""));

            Console.WriteLine(degisken.Split(' ')[0]);

            Console.WriteLine(degisken.Substring(4));
            Console.WriteLine(degisken.Substring(4,6));
        }
    }
}
