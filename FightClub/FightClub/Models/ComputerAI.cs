using FightClub.Interfaces;
using System;

namespace FightClub.Models
{
    class ComputerAI : IFighter
    {
        public string FighterName { get; }
        public int Hp { get; set; }
        public PartOfTheBody Hit { get; set; }
        public PartOfTheBody Blocked { get; set; }

        public event FighterHandler Block;
        public event FighterHandler Wound;
        public event FighterHandler Death;

        public ComputerAI(string name)
        {
            FighterName = name;
            Hp = 100;
        }

        public void GetHit(PartOfTheBody hit)
        {
            if (Blocked == hit)
            {
                Block?.Invoke(FighterName, Hp);
            }
            else
            {
               Hp -= 20;

                if (Hp <= 0)
                    Death?.Invoke(FighterName, 0);
                else
                    Wound?.Invoke(FighterName, Hp);
            }
        }
        Random random = new Random();
        public void SetBlock(PartOfTheBody block)
        {
            int rnd = random.Next(0, 3);
            if (rnd == 0)
                Blocked = PartOfTheBody.Head;
            if (rnd == 1)
                Blocked = PartOfTheBody.Body;
            if (rnd == 2)
                Blocked = PartOfTheBody.Legs;

            SetRandomHit();
        }

        private void SetRandomHit()
        {
            int rnd = random.Next(0, 3);
            if (rnd == 0)
                Hit = PartOfTheBody.Head;
            if (rnd == 1)
                Hit = PartOfTheBody.Body;
            if (rnd == 2)
                Hit = PartOfTheBody.Legs;
        }
    }
}
