using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjAvaliacao
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            int nr = 0; int nma = 100; int nme = 1; int n = 0; int m = 0; int f = 2; int i = 1;
            Random rdn = new Random();
            nr = rdn.Next(1,2);

                Console.Write("Digite um número, e tomara que não seja o mesmo que o sorteado, se não sua alma é minha mwhuahuahuah: ");
                n = int.Parse(Console.ReadLine());



                if (n == nr)
                {
                    Console.Clear();
                    Console.Write("Você perdeu o jogo, mas do mesmo jeito, o jogo é impossível mwhuahuahuahuaha - Juliana 2015");
                    Console.ReadKey();
                    i = i + 1;

                }

                else
                {
                    if (n > nr)
                    {
                        nma = n;
                        m = n;
                        n = 0;
                        do
                        {
                            Console.Write("Digite outro número, de " + nme.ToString() + " até " + nma.ToString() + "  :");
                            n = int.Parse(Console.ReadLine());

                            if (n == nr)
                            {
                                Console.Clear();
                                Console.Write("Você perdeu o jogo, mas do mesmo jeito, o jogo é impossível mwhuahuahuahuaha - Juliana 2015");
                                Console.ReadKey();
                                i = i + 1;
                            }
                            else
                            {
                                if (n < nr && n < nma && n > nme)
                                {
                                    nme = n;
                                    m = n;
                                    n = 0;
                                }

                                else
                                {
                                    if (n > nr && n > nme && n < nma)
                                    {
                                        nma = n;
                                        m = n;
                                        n = 0;
                                    }

                                    else
                                    {
                                        if (n >= nma)
                                        {
                                            Console.Clear();
                                            Console.Write("Você perdeu o jogo, mas do mesmo jeito, o jogo é impossível mwhuahuahuahuaha - Juliana 2015");
                                            Console.ReadKey();
                                            i = i + 1;
                                        }
                                        else
                                        {
                                            if (n <= nme)
                                            {
                                                Console.Clear();
                                                Console.Write("Você perdeu o jogo, mas do mesmo jeito, o jogo é impossível mwhuahuahuahuaha - Juliana 2015");
                                                Console.ReadKey();
                                                i = i + 1;
                                            }
                                        }
                                    }


                                }
                            }

                        }

                        while (f != i);
                    }

                    else
                    {
                       
                            nme = n;
                            m = n;
                            n = 0;
                            do
                            {
                                Console.Write("Digite outro número, de " + nme.ToString() + " até " + nma.ToString() + "  :");
                                n = int.Parse(Console.ReadLine());

                                if (n == nr)
                                {
                                    Console.Clear();
                                    Console.Write("Você perdeu o jogo, mas do mesmo jeito, o jogo é impossível mwhuahuahuahuaha - Juliana 2015");
                                    Console.ReadKey();
                                    i = i + 1;
                                }
                                else
                                {
                                    if (n < nr && n < nma && n > nme)
                                    {
                                        nme = n;
                                        m = n;
                                        n = 0;
                                    }

                                    else
                                    {
                                        if (n > nr && n > nme && n < nma)
                                        {
                                            nma = n;
                                            m = n;
                                            n = 0;
                                        }

                                        else
                                        {
                                            if (n >= nma)
                                            {
                                                Console.Clear();
                                                Console.Write("Você perdeu o jogo, mas do mesmo jeito, o jogo é impossível mwhuahuahuahuaha - Juliana 2015");
                                                Console.ReadKey();
                                                i = i + 1;
                                            }
                                            else
                                            {
                                                if (n <= nme)
                                                {
                                                    Console.Clear();
                                                    Console.Write("Você perdeu o jogo, mas do mesmo jeito, o jogo é impossível mwhuahuahuahuaha - Juliana 2015");
                                                    Console.ReadKey();
                                                    i = i + 1;
                                                }
                                            }
                                        }


                                    }
                                }

                            }

                            while (f != i);
                        

                    }
                }

                    
        }
    }
}
