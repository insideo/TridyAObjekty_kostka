using System.ComponentModel.Design;

namespace TridyAObjekty_kostka
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Kostka mojeKostka = new Kostka(12);
            for (int i = 0; i < 1000; i++)
            {
                int jedenHod = mojeKostka.HodKostkou();
                Console.WriteLine(jedenHod);
            }
            Console.WriteLine(mojeKostka.PoctyHozenychCiselText());
            Console.WriteLine(mojeKostka.GetPrumerHozenychHodnot());
            //vytvorit kostku jako objekt s urcitym poctem stran

        }

        //int padla1 = 0;
        //int padla2 = 0; 

       


        




        //pocet stran = 6 1-6
        
        //pocet kostek
        
        //Metoda na generovani Hodu

        //Statistika hodu - pocet hozenych cisel, prumer hodu

        //Vytiskni informace o kostce


        


    }
}
