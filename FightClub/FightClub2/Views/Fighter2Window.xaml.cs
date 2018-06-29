using FightClub2.Interfaces;
using FightClub2.Presenters;
using System.Windows;

namespace FightClub2.Views
{
    public partial class Fighter2Window : Window, IComputerAIWindow
    {
        public string FighterName { get; set; }
        public int FighterHp
        {
            set
            {
                if (value < 0)
                {
                    FighterHpTextBlock.Text = "0";
                    FighterHpProgressBar.Value = 0;
                }
                else
                {
                    FighterHpTextBlock.Text = value.ToString();
                    FighterHpProgressBar.Value = value;
                }
            }
        }

        public Fighter2Window(IFighter fighter)
        {
            InitializeComponent();

            #region Инициализация элементов интерфейса (уровень здоровья, имена бойцa)
            FighterHp = fighter.Hp;
            FighterNameTextBlock.Text = fighter.FighterName;
            #endregion

            MainWindows.ComputerPresenter = new ComputerAIPresenter(this, fighter);
        }

        #region Обработка нажатия кнопок окна
        private void Window_Closed(object sender, System.EventArgs e)
        {
            Application.Current.Shutdown();
        }
        #endregion 
    }
}
