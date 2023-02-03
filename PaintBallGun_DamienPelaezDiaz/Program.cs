using System;

namespace PaintBallGun_DamienPelaezDiaz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenu dans ce jeu de tir... Vous démarrez avec 30 balles");

            string cmd = "";
            string res;

            PaintBallGun game = new PaintBallGun();

            do
            {
                Console.WriteLine(game);
                //Menu des actions
                Console.WriteLine("Espace pour tirer");
                Console.WriteLine("r pour recharger");
                Console.WriteLine("+ pour prendre des munitions");
                Console.WriteLine("q pour quitter");
                Console.WriteLine("am Améliorer le chargeur");
                Console.Write("C> ");
                cmd = Console.ReadLine();
                switch (cmd)
                {
                    case " ":
                        res = game.Tirer();
                        Console.WriteLine(res);
                        break;
                    case "r":
                        res = game.Recharger();
                        Console.WriteLine(res);
                        break;
                    case "+":
                        res = game.PrendreBalles();
                        Console.WriteLine(res);
                        break;
                    case "am":
                        res = game.AmeliorerChargeur();
                        Console.WriteLine(res);
                        break;
                }
            } while (cmd != "q");
        }
    }
}
