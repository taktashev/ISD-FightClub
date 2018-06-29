using FightClub2.Interfaces;

namespace FightClub2.Presenters
{
    public class ComputerAIPresenter
    {
        public IComputerAIWindow ComputerAIWindow { get; set; }
        public IFighter Fighter { get; set; }

        public event FighterHandler Block;
        public event FighterHandler Wound;
        public event FighterHandler Death;

        public ComputerAIPresenter(IComputerAIWindow computerAIWindow, IFighter fighter)
        {
            ComputerAIWindow = computerAIWindow;
            Fighter = fighter;

            #region Подписка на события бойцa
            fighter.Block += (fighterName, hp) => Block?.Invoke(fighterName, hp);
            fighter.Wound += (fighterName, hp) => Wound?.Invoke(fighterName, hp);
            fighter.Death += (fighterName, hp) => Death?.Invoke(fighterName, hp);
            #endregion
        }
    }
}
