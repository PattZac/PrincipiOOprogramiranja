using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipiOOprogramiranja
{
    class GeometrijskoTijelo
    {
        double volumen, oplosje;
        static int brojacTijela = 0;

        public double Volumen { get => volumen; set => volumen = value; }
        public double Oplosje { get => oplosje; set => oplosje = value; }
        public static int BrojacTijela { get => brojacTijela; set => brojacTijela = value; }

        public override string ToString()
        {
            BrojacTijela++;
            return "- Volumen: "+Volumen+" km3, Oplosje: "+Oplosje+" km2 i Brojac Tijela: "+BrojacTijela+".";
        }
    }
    class Kugla : GeometrijskoTijelo
    {
        
    }
    class Kvadar : GeometrijskoTijelo
    {

    }
    class Kocka : GeometrijskoTijelo
    {

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Kugla x = new Kugla();
            Kvadar y = new Kvadar();
            Kocka z = new Kocka();
            x.Volumen = 523.6;
            y.Volumen = 250;
            z.Volumen = 125;
            x.Oplosje = 314.16;
            y.Oplosje = 25;
            z.Oplosje = 250;
            Console.WriteLine("Kugla "+x.ToString());
            Console.WriteLine("\r\nKvadar " + y.ToString());
            Console.WriteLine("\r\nKocka " + z.ToString());
            Console.ReadKey();
        }
    }
}
