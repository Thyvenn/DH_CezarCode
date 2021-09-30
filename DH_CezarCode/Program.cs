using System;

namespace DH_CezarCode
{
    class Program
    {
        static char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm','n','o', 'p', 'r', 's', 't', 'u', 'v', 'w','x', 'y','z'};

        public static string ciper(string ciper_input, int drift)
        {
            string ciper_out = string.Empty;
            string builder = string.Empty;
            foreach (char xchar in ciper_input)
            {
                for (int i = 0; i < alphabet.Length; i++)
                {
                    if (alphabet[i] == xchar)
                    {
                        if (alphabet.Length <= (i + drift))
                        {
                            int reszta = (i + drift) - alphabet.Length;
                            builder += alphabet[reszta];
                        }
                        else
                        {
                        builder += alphabet[i + drift];

                        }
                    }
                }
            }
            ciper_out = builder;
            return ciper_out;
        }

        public static string deciper(string deciper_input, int drift)
        {
            string deciper_out = string.Empty;
            string builder = string.Empty;
            foreach (char xchar in deciper_input)
            {
                for (int i = 0; i < alphabet.Length; i++)
                {
                    if (alphabet[i] == xchar)
                    {
                        if (alphabet.Length > (i - drift))
                        {
                            int reszta = alphabet.Length - (i - drift);
                            builder += alphabet[reszta];
                        }
                        else
                        {
                            builder += alphabet[i - drift];

                        }
                    }
                }
            }
            deciper_out = builder;
            return deciper_out;
        }


        static void Main(string[] args)
        {
            string inputStr;
            int inputDrift;
            string outputStr;
            Console.WriteLine("Kod Cezara\n ______________ \n");
            Console.WriteLine("Podaj tekst do zaszyfrowania:\n");
            inputStr = Console.ReadLine();
            Console.WriteLine("Podaj przesunięcie:\n");
            inputDrift = Int32.Parse(Console.ReadLine());
            outputStr =  deciper(inputStr.ToLower(), inputDrift);
            Console.WriteLine(outputStr);


        }
    }
}
