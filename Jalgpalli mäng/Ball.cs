using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalgpalli_mäng
{
    public class Ball
    {
        public double X { get; private set; } //Palli X asend (Положение мяча по оси X)
        public double Y { get; private set; } //Palli Y asend (Положение мяча по оси Y)

        private double _vx, _vy; //palli kiiruse salvestamine piki X- ja Y-telge (хранения скорости мяча по осям X и Y)

        private Game _game;

        //määrab palli algsed koordinaadid (задает начальные координаты мяча)
        public Ball(double x, double y, Game game)
        {
            _game = game;
            X = x;
            Y = y;
        }

        //määrab palli kiiruse (устанавливает скорость мяча)
        public void SetSpeed(double vx, double vy)
        {
            _vx = vx;
            _vy = vy;
        }

        //palli liigutades (перемещения мяча)
        public void Move()
        {
            double newX = X + _vx;
            double newY = Y + _vy;
            //Kontrollige, kas palli uus asukoht on staadionil
            //Проверка, находится ли новая позиция мяча в пределах стадиона
            if (_game.Stadium.IsIn(newX, newY))
            {
                //Kui pall on piirides, värskendab selle koordinaate
                //Если мяч находится в пределах, обновляет его координаты
                X = newX;
                Y = newY;
            }
            else
            {
                //Kui pall läheb mänguväljast välja, muutub palli kiirus 0 ja peatab selle liikumise
                //Если мяч выходит за пределы поля, скорость мяча становится 0 и останавливает его движение
                _vx = 0;
                _vy = 0;
            }
        }
    }
}
