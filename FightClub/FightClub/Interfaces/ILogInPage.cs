using System;

namespace FightClub.Interfaces
{
    public interface ILogInPage
    {
        string FighterName { get; }
        string Error { set; }

        event EventHandler LogIn;
    }
}
