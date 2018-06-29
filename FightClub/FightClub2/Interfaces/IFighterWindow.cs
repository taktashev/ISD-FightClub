using System;

namespace FightClub2.Interfaces
{
    public interface IFighterWindow
    {
        int FighterHp { set; }

        void SetRoundSettings(IFighter fighter);

        event EventHandler Fight;
        event EventHandler Reload;
    }
}
