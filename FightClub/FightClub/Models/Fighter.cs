using FightClub.Interfaces;

namespace FightClub.Models
{
    class Fighter : IFighter
    {
        public string FighterName { get; }
        public int Hp { get; set; }
        public PartOfTheBody Hit { get; set; }
        public PartOfTheBody Blocked { get; set; }

        public event FighterHandler Block;
        public event FighterHandler Wound;
        public event FighterHandler Death;

        public Fighter(string name)
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
        public void SetBlock(PartOfTheBody block)
        {
            Blocked = block;
        }
    }
}
