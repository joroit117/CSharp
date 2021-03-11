using System;

namespace PasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            string combination = "";

            for(int i = 1; i < n; i++)
                for(int j = 1; j < n; j++)
                {
                    int a = i;
                    int b = j;
                    for(int m = 0; m < l; m++)
                        for(int k = 0; k < l; k++)
                        {
                            char c = Convert.ToChar(97 + m);
                            char d = Convert.ToChar(97 + k);
                            for (int s = a + 1; s <= n; s++)
                            {
                                if(s > a && s > b)
                                {
                                    int e = s;
                                    combination += a.ToString();
                                    combination += b.ToString();
                                    combination += c.ToString();
                                    combination += d.ToString();
                                    combination += e.ToString();
                                    Console.Write(combination + " ");
                                    combination = "";
                                }
                            }
                        }
                }
            }
    }
}
