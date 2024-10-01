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
            if (newX < 1 || newX >= _game.Stadium.Width + 1)
            {
                _vx = -_vx; // изменить направление скорости по Х
                newX = X + _vx;
            }

            if (newY < 1 || newY >= _game.Stadium.Height + 1)
            {
                _vy = -_vy; // изменить направление скорости по Y
                newY = Y + _vy;
            }

            X = newX;
            Y = newY;
        }
    }
}
