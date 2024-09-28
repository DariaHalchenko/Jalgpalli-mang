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
                Meeskond_1.AddPlayer(new Player($"PunanePlayer{i}", ConsoleColor.Yellow, 'K'));
            }

            // Создание игроков для пурпурной команды
            for (int i = 1; i <= 11; i++)
            {
                Meeskond_1.AddPlayer(new Player($"PunanePlayer{i}", ConsoleColor.Magenta, 'L'));
            }

            var game = new Game(Meeskond_1, Meeskond_2, stadium);
            game.Start();

            var stadium_Drawing = new Staadioni_joonis(game);
            var goal_Drawing = new Värava_joonistamine(game);
            var player_Drawing = new Joonistus_mängijad(game);
            var palli_Drawing = new Palli_joonistamine(game);

            stadium_Drawing.Draw();
            goal_Drawing.DrawGoals();
            player_Drawing.Draw();
            palli_Drawing.Draw();
            
            while (true)
            {
                System.Threading.Thread.Sleep(100);
            }   
        }
    }
}
