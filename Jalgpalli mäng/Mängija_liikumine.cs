using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalgpalli_mäng
{
    // Класс для управления движением игроков и мяча
    public class Mängija_liikumine
    {
        private Game _game;
        public Mängija_liikumine(Game game)
        {
            _game = game;
        }
        public void Start_Game()
        {
            while (true)
            {
                //Обновляем позиции игроков и мяча
                _game.Move();
                Console.Clear();

                var stadium_Drawing = new Staadioni_joonis(_game);
                var goal_Drawing = new Värava_joonistamine(_game);
                var player_Drawing = new Joonistus_mängijad(_game);
                var palli_Drawing = new Palli_joonistamine(_game);

                stadium_Drawing.Draw();
                goal_Drawing.DrawGoals();
                player_Drawing.Draw();
                palli_Drawing.Draw();

                Thread.Sleep(300);
            }
        }

    }
}