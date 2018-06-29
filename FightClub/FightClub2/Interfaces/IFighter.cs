using FightClub2.Models;

namespace FightClub2.Interfaces
{
    public delegate void FighterHandler(string fighterName, int hp);

    public interface IFighter
    {
        string FighterName { get; }
        int Hp { get; set; }
        PartOfTheBody Hit { get; set; }
        PartOfTheBody Blocked { get; set; }

        void GetHit(PartOfTheBody hit);
        void SetBlock(PartOfTheBody block);

        event FighterHandler Block;
        event FighterHandler Wound;
        event FighterHandler Death;
    }
}
