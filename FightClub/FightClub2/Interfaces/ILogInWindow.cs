using System;

namespace FightClub2.Interfaces
{
    interface ILogInWindow
    {
        string FighterName { get; }
        string Error { set; }

        event EventHandler LogIn;
    }
}
