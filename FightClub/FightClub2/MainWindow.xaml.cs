using FightClub2.Presenters;
using FightClub2.Views;
using System;
using System.Windows;
using System.Windows.Media;

namespace FightClub2
{
    public partial class MainWindows : Window
    {
        public static LogInWindow LogInWindow { get; set; }
        public static Fighter1Window Fighter1Window { get; set; }
        public static Fighter2Window Fighter2Window { get; set; }
        public static LogWindow LogWindow { get; set; }

        public static FighterPresenter FighterPresenter { get; set; }
        public static ComputerAIPresenter ComputerPresenter { get; set; }
        public static LogPresenter LogPresenter { get; set; }

        public static FightPresenter FightPresenter { get; set; }

        MediaPlayer player = new MediaPlayer();

        public MainWindows()
        {
            InitializeComponent();
            Hide();

            PlayMusic(@"..\..\Resources\audio.mp3");
            player.MediaEnded += (s, e) => PlayMusic(@"..\..\Resources\audio.mp3");

            LogInWindow = new LogInWindow();
            LogInWindow.Show();
        }

        public static void StartFight()
        {
            LogInWindow.Hide();

            Fighter1Window.Show();
            Fighter2Window.Show();
            LogWindow.Show();
        }

        private void PlayMusic(string path)
        {
            player.Open(new Uri(path, UriKind.Relative));
            player.Play();
        }
    }
}