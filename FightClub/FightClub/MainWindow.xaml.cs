using FightClub.Views;
using System;
using System.Windows;
using System.Windows.Media;

namespace FightClub
{
    public partial class MainWindow : Window
    {
        MediaPlayer player = new MediaPlayer();

        public MainWindow()
        {
            InitializeComponent();

            PlayMusic(@"..\..\Resources\audio.mp3");
            player.MediaEnded += (s, e) => PlayMusic(@"..\..\Resources\audio.mp3");
            
            Content = new LogInPage();
        }

        void PlayMusic(string path)
        {
            player.Open(new Uri(path, UriKind.Relative));
            player.Play();
        }
    }
}
