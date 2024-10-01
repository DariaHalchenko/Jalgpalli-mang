using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalgpalli_mäng
{
    public class Game
    {
        public Team HomeTeam { get; } //kodumeeskond (домашняя команда)
        public Team AwayTeam { get; }//võõrsil meeskond (команда гостей)
        public Stadium Stadium { get; }
        public Ball Ball { get; private set; }
        
        //Mängu konstruktor, initsialiseerib kodu- ja võõrsilvõistkonnad ning staadioni
        //Конструктор игры, инициализирует домашнюю и гостевую команды и стадион
        public Game(Team homeTeam, Team awayTeam, Stadium stadium)
        {
            HomeTeam = homeTeam; //kodumeeskond (домашняя команда)
            homeTeam.Game = this; 
            AwayTeam = awayTeam; //võõrsil meeskond (команда гостей)
            awayTeam.Game = this;
            Stadium = stadium; 
        }

        //mängu algust (начала игры)
        public void Start()
        {
            //Palli loomine ja asetamine väljaku keskele (Создание мяча и помещение его в центр поля)
            Ball = new Ball(Stadium.Width / 2, Stadium.Height / 2, this);
            //kodumeeskonna stardipositsioon (начальная позиция для домашней команды)
            HomeTeam.StartGame(Stadium.Width / 1, Stadium.Height);
            //stardipositsioon võõrsil (начальная позиция для гостевой команды)
            AwayTeam.StartGame(Stadium.Width / 2, Stadium.Height);
        }

        //tagastab pallipositsiooni konkreetse meeskonna jaoks (возвращает позицию мяча для конкретной команды)
        public (double, double) GetBallPosition()
        {
            return (Ball.X, Ball.Y);
        }

        //määrab meeskonna palli kiiruse (задает скорость мяча для команды)
        public void SetBallSpeedForTeam(Team team, double vx, double vy)
        {
            //kui see on kodumeeskond, seadke palli kiirus nii nagu see on
            //если это домашняя команда, устанавливаем скорость мяча как она есть 
            if (team == HomeTeam)
            {
                Ball.SetSpeed(-vx, vy);
            }
            //Kui meeskond on külas, pöörame kiiruse ümber (kuna nende väli on peegeldatud)
            //Если команда гостевая, инвертируем скорость (так как их поле зеркально)
            else
            {
                Ball.SetSpeed(vx, vy);
            }
        }

        //uuendab mängijate ja palli asukohti väljakul (обновляет позиции игроков и мяча на поле)
        public void Move()
        {
            //Saame pallile lähimad mängijad mõlemale meeskonnale
            //Получаем ближайших к мячу игроков для обеих команд
            var closestHomePlayer = HomeTeam.GetClosestPlayerToBall();
            var closestAwayPlayer = AwayTeam.GetClosestPlayerToBall();
            //Valime mängija, kes on pallile lähemal
            // Выбираем игрока, который ближе к мячу
            Player closestPlayer;
            if (closestHomePlayer.GetDistanceToBall() < closestAwayPlayer.GetDistanceToBall())
            {
                closestPlayer = closestHomePlayer; //Lähemal on kodumeeskonna mängija (Ближе игрок домашней команды)
            }
            else
            {
                closestPlayer = closestAwayPlayer; //Lähemal on külalismeeskonna mängija (Ближе игрок гостевой команды)
            }

            closestPlayer.Move(); //Valitud mängija liikumine palli poole (Движение выбранного игрока к мячу)

            Ball.Move(); //Palli liikumine (Движение мяча)
        }
    }
}
