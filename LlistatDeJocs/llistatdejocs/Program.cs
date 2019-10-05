using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace llistatdejocs
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcio = "";
            while (opcio != "Q" && opcio != "q")
            {
                Console.Clear();
                MostrarMenu(ref opcio);
                //si no es cap d'aquestes opcions sortirá un altre cop el menú
                if (opcio == "1" || opcio == "2" || opcio == "3" || opcio == "4" || opcio == "5" || opcio == "6" || opcio == "7" || opcio == "8" || opcio == "S" || opcio != "Q")
                {
                    ExecutarSeleccionat(opcio);
                }
                //si la opció es una 'q' sortirem del programa
                else if (opcio == "Q")
                {
                    Console.WriteLine("\n         ═════════════");
                    Console.WriteLine("          ~~Bye bye~~");
                    Console.WriteLine("         ═════════════");
                }


            }

        }
        private static void MostrarMenu(ref string opcio)
        {
            Console.WriteLine("╔═════════════════════╗");
            Console.WriteLine("║    ════Menú════     ║");
            Console.WriteLine("║                     ║");
            Console.WriteLine("║ 1. Buscaminas       ║");
            Console.WriteLine("║ 2. Tetris           ║");
            Console.WriteLine("║ 3. Ajedrez          ║");
            Console.WriteLine("║ 4. Damas            ║");
            Console.WriteLine("║                     ║");
            Console.WriteLine("║                     ║");
            Console.WriteLine("║    S per Guardar    ║");
            Console.WriteLine("║    Q per Sortir     ║");
            Console.WriteLine("║                     ║");
            Console.WriteLine("╚═════════════════════╝");

            //demanar opció
            Console.Write("--> Opció: ");
            opcio = Console.ReadLine().Replace("q", "Q");
        }

        private static void ExecutarSeleccionat(string opcio)
        {
            switch (opcio)
            {
                case "1":
                    Console.Clear();
                    Buscaminas();
                    EnterPerSortir();
                    break;
                case "2":
                    Console.Clear();
                    EnterPerSortir();
                    break;
                case "3":
                    Console.Clear();
                    Ajedrez();
                    EnterPerSortir();
                    break;
                case "4":
                    Console.Clear();
                    EnterPerSortir();
                    break;
            }
            Console.WriteLine();
        }

        private static void Buscaminas()
        {
            Console.WriteLine("  Estas jugant al millor buscaminas del món!");
            Console.WriteLine("  <!> Estas jugant al buscaminas 3D! <!>");
        }
        private static void Ajedrez()
        {
            Console.WriteLine("  Estas jugant al Ajedrez!");
        }

        private static void EnterPerSortir()
        {
            Console.Write("\n --Pressiona Enter per sortir--");
            Console.ReadLine();
        }
    }
}
