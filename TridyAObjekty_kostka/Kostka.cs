using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TridyAObjekty_kostka
{
    public class Kostka
    {
        public int[] statisticaHodu;
        private static int pocetStranKostky = 6;
        private double prumerHozenychHodnot = 0;
        private int pocetHoduCelkem = 0;
        private int celkoveHozeno = 0;
        Random random; //random by mel byt inicializovan jednou. nejlepe uvnitr konstruktoru
        public Kostka() { //Specialni metoda nazvana konstruktor, umoznuje inicializaci promennych i tech private
            pocetStranKostky = 6;
            statisticaHodu = new int[6];
            random = new Random();
        }
        public Kostka(int argPocetStran)
        {
            pocetStranKostky = argPocetStran;
            statisticaHodu = new int[argPocetStran];
            random = new Random();
        }
        public int HodKostkou()
        {
            //Trida pro generovani nahodnych cisel
            //random = new Random();
            int jedenHod = 0;
            jedenHod = random.Next(1, pocetStranKostky + 1);
            statisticaHodu[jedenHod - 1]++;
            pocetHoduCelkem++;
            celkoveHozeno += jedenHod;
            prumerHozenychHodnot  = (double)celkoveHozeno/pocetHoduCelkem;
            return jedenHod;
        }
        public string InformaceOKostce()
        {
            //return "" + pocetStranKostky;
            return pocetStranKostky.ToString();
        }
        public string PoctyHozenychCiselText()
        {
            string statistInfo = "";
            for (int i = 0; i < statisticaHodu.Length; i++)
            {
                statistInfo += "CISLO " + (i + 1) + " HOZENO " + statisticaHodu[i] + "x" + "\n";
            }
            return statistInfo;

        }
        public double GetPrumerHozenychHodnot()
        {
            return prumerHozenychHodnot;
        }
        

    }
}
