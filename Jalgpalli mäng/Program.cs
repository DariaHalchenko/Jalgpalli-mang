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
            var Meeskond_1 = new Team("Punane");
            var Meeskond_2 = new Team("Sinine");
            
            // Создание игроков для красной команды
            for (int i = 1; i <= 11; i++)
            {
                Meeskond_1.AddPlayer(new Player($"PunanePlayer{i}", ConsoleColor.Red, 'P'));
            }

            // Создание игроков для синей команды
            for (int i = 1; i <= 11; i++)
            {
                Meeskond_1.AddPlayer(new Player($"PunanePlayer{i}", ConsoleColor.Blue, 'S'));
            }

            var game = new Game(Meeskond_1, Meeskond_2, stadium);
            game.Start();
            
            var stadium_Drawing = new Staadioni_joonis(game);
            var goal_Drawing = new Värava_joonistamine(game);

            stadium_Drawing.Draw();
            goal_Drawing.DrawGoals();
            stadium_Drawing.DrawPlayers();

            Thread.Sleep(50000);
        }
    }
}
