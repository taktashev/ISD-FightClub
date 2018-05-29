using FightClub.Interfaces;
using FightClub.Models;
using System;
using System.Windows;

namespace FightClub.Presenters
{
    class LogInPresenter
    {
        readonly ILogInPage logInPage;

        public LogInPresenter(ILogInPage logInPage)
        {
            this.logInPage = logInPage;

            logInPage.LogIn += LogInPage_LogIn;
        }

        private void LogInPage_LogIn(object sender, EventArgs e)
        {
            if (logInPage.FighterName.Length < 3 || logInPage.FighterName.Length > 20)
                logInPage.Error = "Имя бойца должно содержать от 3 до 20 символов";
            else
                Application.Current.MainWindow.Content = new FightPage(new Fighter(logInPage.FighterName), new ComputerAI("Тайлер Дёрден"));
        }
    }
}
