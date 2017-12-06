using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculation;

namespace ConsoleAppCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            float fPrviBroj;
            float fDrugiBroj;
            float fRezultat = 0;
            int nOdabir;
            Console.WriteLine("Unesite prvi broj: ");
            fPrviBroj = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Unesite drugi broj: ");
            fDrugiBroj = Convert.ToSingle(Console.ReadLine());
            //aa
            Console.WriteLine("Odaberite jednu od opcija: ");
            Console.WriteLine("1-Zbrajanje");
            Console.WriteLine("2-Množenje");
            Console.WriteLine("3-Oduzimanje");
            Console.WriteLine("4-Dijeljenje");

            nOdabir = Convert.ToInt16(Console.ReadLine());
            Calculator Calculator = new Calculator();
            switch (nOdabir)
            {
                case 1:
                    //fRezultat = fPrviBroj + fDrugiBroj;
                      fRezultat = Calculator.Add(fPrviBroj, fDrugiBroj);
                    break;
                case 2:
                   // fRezultat = fPrviBroj * fDrugiBroj;
                      fRezultat = Calculator.Multiply(fPrviBroj, fDrugiBroj);
                    break;
                case 3:
                    //fRezultat = fPrviBroj - fDrugiBroj;
                      fRezultat = Calculator.Substract(fPrviBroj, fDrugiBroj);
                    break;
                case 4:
                    //fRezultat = fPrviBroj / fDrugiBroj;
                      fRezultat = Calculator.Divide(fPrviBroj, fDrugiBroj);
                    break;
                default:
                    Console.WriteLine("Niste odabrali niti jednu od ponudenih opcija.");
                    break;
            }
            Console.WriteLine("Rezultat odabrane operacije je: " + fRezultat);
            Console.ReadKey();


        }
    }
}
