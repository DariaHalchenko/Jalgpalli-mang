using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalgpalli_mäng
{
    //Klass mängijate joonistamiseks mänguväljakul
    //Класс для отрисовки игроков на игровом поле
    public class Joonistus_mängijad
    {
        private Game _game;
        public Joonistus_mängijad(Game game)
        {
            _game = game;
        }
        //Meetod mängijate positsioonide puhastamiseks ekraanilt 
        //Метод для очистки позиций игроков с экрана
        public void Clear()
        {
            //Möödume mõlema meeskonna mängijatest (Проходим по игрокам обеих команд)
            foreach (var player in _game.HomeTeam.Players.Concat(_game.AwayTeam.Players))
            {   
                Console.SetCursorPosition((int)player.X, (int)player.Y); 
                Console.Write(' '); //Puhastame mängija hetkepositsiooni (Очищаем текущую позицию игрока)
            }
        }
        //joonistab väljakule kõik mängijad (рисует всех игроков на поле)
        public void Draw()
        {
            //joonistab kodumeeskonna mängijaid (рисует игроков домашней команды)
            foreach (var player in _game.HomeTeam.Players)
            {
                Console.ForegroundColor = ConsoleColor.Magenta; //mängija värv (цвет игрока)
                Console.SetCursorPosition((int)player.X, (int)player.Y); //mängija positsioon (позицию игрока)
                Console.Write('M'); //mängija sümbol (символ игрока)
            }
            //joonistab külalisvõistkonna mängijaid (рисует игроков гостевой команды)
            foreach (var player in _game.AwayTeam.Players)
            {
                Console.ForegroundColor = ConsoleColor.Yellow; //mängija värv (цвет игрока)
                Console.SetCursorPosition((int)player.X, (int)player.Y); //mängija positsioon (позицию игрока)
                Console.Write('Y'); //mängija sümbol (символ игрока)
            }
        }
    }
}



