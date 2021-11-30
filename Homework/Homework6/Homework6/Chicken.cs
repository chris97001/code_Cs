using System;

namespace Homework6
{
    internal class ElectroChicken
    {
        public String Name;
        public int Age;
        public int Health;
        public int Weight;
        public int Satisfaction;
        public int Emotion;
        public bool IsDirty;
        public bool IsSick;
        public bool IsDead;

        public ElectroChicken(String name)
        {
            Name = name;
            Age = 1;
            Health = 70;
            Weight = 700;
            Satisfaction = 70;
            Emotion = 50;
            IsDirty = false;
            IsSick = false;
            IsDead = false;
        }

        private static Random rnd = new Random();

        public void Feed(ref int money)
        {
            money -= 10;
            if (money < 0) money = 0;
            Satisfaction += rnd.Next(0, 21);
            if (Satisfaction > 100) Satisfaction = 100;
            Weight += rnd.Next(50, 101);
            if (Weight > 4000) Weight = 4000;

            if (IsDirty)
            {
                Health -= 10;
                if (Health < 0) Health = 0;
            }
        }

        public void Play(ref int money)
        {
            money -= 5;
            if (money < 0) money = 0;
            Health += rnd.Next(0, 21);
            if (Health > 100) Health = 100;
            Emotion += rnd.Next(0, 21);
            if (Emotion > 100) Emotion = 100;
            Satisfaction -= rnd.Next(0, 21);
            if (Satisfaction < 0) Satisfaction = 0;
        }

        public void Clean(ref int money)
        {
            money -= 5;
            if (money < 0) money = 0;
            IsDirty = false;
        }

        public void GoToDoctor(ref int money)
        {
            money -= 20;
            if (money < 0) money = 0;
            Health += 30;
            if (Health > 100) Health = 100;
            Emotion -= 20;
            if (Emotion < 0) Emotion = 0;
            IsSick = false;
        }

        public String Grow(ref int money)
        {
            if (IsDirty)
            {
                Health -= 30;
                if (Health < 0) Health = 0;
            }
            if (IsSick)
            {
                Weight -= 150;
                if (Weight < 600) Weight = 600;
                Emotion -= 20;
                if (Emotion < 0) Emotion = 0;
            }
            if (Satisfaction == 0)
            {
                Weight -= 200;
                if (Weight < 600) Weight = 600;
            }
            else
            {
                Satisfaction -= 20;
                if (Satisfaction < 0) Satisfaction = 0;
            }

            if (Age > 10)
            {
                Health -= 10;
                if (Health < 0) Health = 0;
            }

            String eventString = "";
            //
            if (Satisfaction >= 50)
            {
                eventString += "牠大便了 "+Environment.NewLine;
                IsDirty = true;
            }
            //
            if (Weight > 1000 && Health > 60)
            {
                int LaidChance = rnd.Next(0, 101);
                if (LaidChance <= Emotion)
                {
                    int eggMoney = rnd.Next(15, 26);
                    eventString += Name+"下蛋了，賣掉蛋後賺了"+eggMoney.ToString()+"塊錢"+Environment.NewLine;
                    Health -= 5;
                    money += eggMoney;
                }
            }
            //
            if (Health <= 50 && Emotion <= 50)
            {
                int SickChance = rnd.Next(0, 101);
                if (SickChance <= 100 - Health)
                {
                    eventString += Name + "生病了 "+Environment.NewLine;
                    IsSick = true;
                }
            }
            //
            if (Health < 10 && Weight < 1000)
            {
                int deadChance = rnd.Next(0, 101);
                if (deadChance <= 100 - Emotion)
                {
                    IsDead = true;
                    eventString = "死掉了，遊戲結束"+Environment.NewLine;
                }
            }
            //
            if (eventString.Length == 0)  
                eventString = "一天平安的過去了"+Environment.NewLine;
            return eventString;
        }
    }
}