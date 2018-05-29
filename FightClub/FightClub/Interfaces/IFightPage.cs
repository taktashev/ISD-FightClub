using System;

namespace FightClub.Interfaces
{
    interface IFightPage
    {
        int Fighter1Hp { set; }
        int Fighter2Hp { set; }

        string Log { get; set; } 

        void SetRoundSettings(IFighter fighter);

        event EventHandler Fight;
        event EventHandler Reload;
    }
}
