using FightClub2.Interfaces;
using FightClub2.Presenters;
using System;
using System.Windows;

namespace FightClub2.Views
{
    public partial class LogInWindow : Window, ILogInWindow
    {
        public string FighterName { get => FighterNameTextBox.Text; }
        public string Error { set => ErrorTextBlock.Text = value; }

        public event EventHandler LogIn;

        public LogInWindow()
        {
            InitializeComponent();

            LogInPresenter logInPresenter = new LogInPresenter(this);
        }

        #region Обработка нажатия кнопок окна
        private void LogInButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            LogIn?.Invoke(this, EventArgs.Empty);
        }
        private void HelpButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            MessageBox.Show("Бойцовский клуб\n\n" +
                            "Правила:\n" +
                            " 1. каждый раунд игроки выбирают часть тела, которую они\n" +
                            "     собираются атаковать и которую будут защищать; в концe\n" +
                            "     раунда идёт сверка защищённых частей тела с атакуемыми\n" +
                            "     частями\n" +
                            " 2. попадание по незащищенной части тела отнимает 20НР\n" +
                            " 3. попадание в заблокированную часть тела не отнимает жизней\n\n" +
                            "Приложение написано с помощью технологии WPF с применением MVР-архитектуры\n\n" +
                            "Автор: Такташев Никита");
        }
        private void Window_Closed(object sender, EventArgs e)
        {
            Application.Current.Shutdown();
        }
        #endregion
    }
}
