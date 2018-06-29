using FightClub2.Interfaces;
using System;

namespace FightClub2.Presenters
{
    public class FighterPresenter
    {
        public IFighterWindow FighterWindow { get; set; }
        public IFighter Fighter { get; set; }

        public event FighterHandler Block;
        public event FighterHandler Wound;
        public event FighterHandler Death;

        public event EventHandler Fight;
        public event EventHandler Reload;

        public FighterPresenter(IFighterWindow fighterWindow, IFighter fighter)
        {
            FighterWindow = fighterWindow;
            Fighter = fighter;

            #region Подписка на события бойцa
            Fighter.Block += (fighterName, hp) => Block?.Invoke(fighterName, hp);
            Fighter.Wound += (fighterName, hp) => Wound?.Invoke(fighterName, hp);
            Fighter.Death += (fighterName, hp) => Death?.Invoke(fighterName, hp);
            #endregion

            #region Подписка на события страницы
            FighterWindow.Fight += (sender, e) => Fight?.Invoke(sender, e);
            FighterWindow.Reload += (sender, e) => Reload?.Invoke(sender, e);
            #endregion
        }
    }
}
