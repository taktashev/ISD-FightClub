using FightClub2.Interfaces;
using FightClub2.Presenters;
using System;
using System.Windows;
using System.Windows.Controls;

namespace FightClub2.Views
{
    public partial class LogWindow : Window, ILogWindow
    {
        public string Log
        {
            get { return LogTextBox.Text; }
            set
            {
                if (value == "")
                    LogTextBox.Text = "";
                else
                    LogTextBox.AppendText(value);
            }
        }

        public LogWindow()
        {
            InitializeComponent();

            MainWindows.LogPresenter = new LogPresenter(this);
        }

        #region Обработка нажатия кнопок и событий окна
        private void LogTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (LogTextBox.Text.Length != 0)
            {
                if (Log.Contains("Раунд 3"))
                    LogTextBox.ScrollToLine(LogTextBox.LineCount - 1);
                else
                    LogTextBox.ScrollToLine(LogTextBox.LineCount - 2);
            }
        }
        private void Window_Closed(object sender, EventArgs e)
        {
            Application.Current.Shutdown();
        }
        #endregion
    }
}
