using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KandydatNaStudia[] zad = new KandydatNaStudia[3];
            zad[0] = new KandydatNaStudia("Dziura", 75, 55, 25);
            zad[1] = new KandydatNaStudia("Kwiat", 88, 68, 38);
            zad[2] = new KandydatNaStudia("Monet", 93, 63, 43);
            for (int i = 0; i < zad.Length; i++)
            {
                Console.WriteLine(zad[i].surname + " " + zad[i].Pkt(zad[i].punktyMatematyka, zad[i].punktyInformatyka, zad[i].punktyJezykObcy));
            }
        }
    }

    struct KandydatNaStudia
    {
        public string surname;
        public int punktyMatematyka, punktyInformatyka, punktyJezykObcy;
        public KandydatNaStudia(string nazwisko, int matematyka, int informatyka, int jezykobcy)
        {
            surname = nazwisko;
            punktyMatematyka = matematyka;
            punktyInformatyka = informatyka;
            punktyJezykObcy = jezykobcy;
        }
        public float Pkt(int matematyka, int informatyka, int jezykobcy)
        {
            return 0.6f * matematyka + 0.5f * informatyka + 0.2f * jezykobcy;
        }
    }
}
