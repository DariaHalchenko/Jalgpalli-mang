using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalgpalli_mäng
{
    //Mängijate võistkonna klass
    public class Team
    {
        //Võistkonna mängijate nimekiri (Список игроков в команде)
        public List<Player> Players { get; } = new List<Player>();
        //Meeskonna nimi (Название команды)
        public string Name { get; private set; }
        //mäng, mida meeskond mängib (игра, в которую  играет команда)
        public Game Game { get; set; }
        //tiim nimega (команда с именем)
        public Team(string name)
        {
            Name = name;
        }

        //mängijate algrivistus väljakul mängu alustamisel (начальная расстановка игроков на поле при начале игры)
        public void StartGame(int width, int height)
        {
            Random rnd = new Random();
            //Igale mängijale seatakse väljakul juhuslik positsioon 
            //Для каждого игрока устанавливатся случайная позиция на поле
            foreach (var player in Players)
            {
                player.SetPosition(
                    rnd.NextDouble() * width,
                    rnd.NextDouble() * height
                    );
            }
            
        }
        //mängija lisamine meeskonda, kui mängija kuulub juba meeskonnale, siis ei saa lisada
        //добавления игрока в команду, если игрок уже принадлежит команде, то нельзя добавлять
        public void AddPlayer(Player player)
        {
            //Kontrollib, kas mängijal on meeskond (Проверяет, есть ли у игрока команда)
            if (player.Team != null) return;
            //Lisab mängija meeskonda (Добавиляет игрока в команду)
            Players.Add(player);
            player.Team = this;
        }
        //palli asendi määramine meeskonnale (определения положения мяча для команды)
        public (double, double) GetBallPosition()
        {
            return Game.GetBallPositionForTeam(this);
        }
        //mängumeetod palli kiiruse määramiseks  (метод игры для определения скорости  мяча)
        public void SetBallSpeed(double vx, double vy)
        {
            Game.SetBallSpeedForTeam(this, vx, vy);
        }
        //Meetod pallile kõige lähemal oleva mängija leidmiseks
        //Метод поиска игрока, который находится ближе всего к мячу
        public Player GetClosestPlayerToBall()
        {
            Player closestPlayer = Players[0];
            double bestDistance = Double.MaxValue;
            foreach (var player in Players)
            {
                //Mängija pallikauguse arvutamine (Расчет расстояния игрока до мяча)
                var distance = player.GetDistanceToBall();
                if (distance < bestDistance)
                {
                    closestPlayer = player;
                    bestDistance = distance;
                }
            }

            return closestPlayer;
        }
        //Mängu ajal mängijate liigutamise meetod (Метод перемещения игроков во время игры)
        public void Move()
        {
            //Lähima mängija liigutamine palli juurde (Перемещение ближайшего игрока к мячу)
            GetClosestPlayerToBall().MoveTowardsBall();
            Players.ForEach(player => player.Move());
        }
    }
}
