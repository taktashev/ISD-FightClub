using FightClub2.Interfaces;
using FightClub2.Models;
using FightClub2.Views;
using System;

namespace FightClub2.Presenters
{
    class LogInPresenter
    {
        readonly ILogInWindow logInPage;

        public LogInPresenter(ILogInWindow logInPage)
        {
            this.logInPage = logInPage;

            logInPage.LogIn += (sender, e) =>
            {
                if (logInPage.FighterName.Length < 3 || logInPage.FighterName.Length > 20)
                    logInPage.Error = "Имя бойца должно содержать от 3 до 20 символов";
                else
                {
                    MainWindows.Fighter1Window = new Fighter1Window(new Fighter(logInPage.FighterName));
                    MainWindows.Fighter2Window = new Fighter2Window(new ComputerAI("Тайлер Дёрден"));
                    MainWindows.LogWindow = new LogWindow();

                    MainWindows.FightPresenter = new FightPresenter(MainWindows.FighterPresenter, MainWindows.ComputerPresenter, MainWindows.LogPresenter);

                    MainWindows.StartFight();
                }
            };
        }
    }
}
