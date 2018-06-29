using FightClub2.Interfaces;

namespace FightClub2.Presenters
{
    public class LogPresenter
    {
        public ILogWindow LogWindow { get; set; }

        public LogPresenter(ILogWindow logWindow)
        {
            LogWindow = logWindow;
        }
    }
}
