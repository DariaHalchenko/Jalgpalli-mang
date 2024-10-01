using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalgpalli_mäng
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            //размеры ворот
            var stadiumWidth = 90; // Ширина стадиона
            var stadiumHeight = 30; // Высота стадиона

            var stadium = new Stadium(stadiumWidth, stadiumHeight);
            var Meeskond_1 = new Team("Kollane");
            var Meeskond_2 = new Team("Lilla");
            
            // Создание игроков для желтой команды
            for (int i = 1; i <= 11; i++)
            {
                Meeskond_1.AddPlayer(new Player($"KollanePlayer {i}"));
            }

            // Создание игроков для пурпурной команды
            for (int i = 1; i <= 11; i++)
            {
                Meeskond_2.AddPlayer(new Player($"LillaPlayer {i}"));
            }

            var game = new Game(Meeskond_1, Meeskond_2, stadium);
            game.Start();

            var stadiumDrawing = new Staadioni_joonis(game);
            var goalDrawing = new Värava_joonistamine(game);
            var playerDrawing = new Joonistus_mängijad(game);
            var ballDrawing = new Palli_joonistamine(game);

            while (true)
            {
                playerDrawing.Clear();
                ballDrawing.Clear();
                game.Move();

                stadiumDrawing.Draw();
                goalDrawing.DrawGoals();
                playerDrawing.Draw();
                ballDrawing.Draw();

                Thread.Sleep(300);
            }   
        }
    }
}
