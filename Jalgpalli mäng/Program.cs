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
            var stadiumWidth = 90; //Staadioni laius (Ширина стадиона)
            var stadiumHeight = 30; //Staadioni kõrgus (Высота стадиона)
            //Loome staadioni (Создаем стадион)
            var stadium = new Stadium(stadiumWidth, stadiumHeight);
            //Loome kaks meeskonda (Создаем две команды)
            var Meeskond_1 = new Team("Kollane");
            var Meeskond_2 = new Team("Lilla");
            
            //Loome kollasele meeskonnale mängijad (Создаем игроков для желтой команды)
            for (int i = 1; i <= 11; i++)
            {
                Meeskond_1.AddPlayer(new Player($"KollanePlayer {i}"));
            }

            //Loome mängijad lillale meeskonnale (Создаем игроков для фиолетовой команды)
            for (int i = 1; i <= 11; i++)
            {
                Meeskond_2.AddPlayer(new Player($"LillaPlayer {i}"));
            }

            var game = new Game(Meeskond_1, Meeskond_2, stadium);
            game.Start();
            //Loome staadioni, värava, mängijate ja palli joonistamise objektid
            //Создаем объекты для отрисовки стадиона, ворот, игроков и мяча
            var stadiumDrawing = new Staadioni_joonis(game);
            var goalDrawing = new Värava_joonistamine(game);
            var playerDrawing = new Joonistus_mängijad(game);
            var ballDrawing = new Palli_joonistamine(game);

            while (true)
            {
                playerDrawing.Clear();
                ballDrawing.Clear();
                game.Move();

                //staadioni, värava, mängijate ja palli joonestamine 
                //отрисовка стадиона, ворот, игроков и мяча
                stadiumDrawing.Draw();
                goalDrawing.DrawGoals();
                playerDrawing.Draw();
                ballDrawing.Draw();

                Thread.Sleep(300);
            }   
        }
    }
}
