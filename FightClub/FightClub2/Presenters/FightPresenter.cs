using FightClub2.Models;
using System;

namespace FightClub2.Presenters
{
    public class FightPresenter
    {
        private readonly FighterPresenter fighter1;
        private readonly ComputerAIPresenter fighter2;
        private readonly LogPresenter log;

        public FightPresenter(FighterPresenter fighter1, ComputerAIPresenter fighter2, LogPresenter log)
        {
            this.fighter1 = fighter1;
            this.fighter2 = fighter2;
            this.log = log;

            #region Подписка на события бойцов 
            fighter1.Fighter.Block += Fighter_Block;
            fighter2.Fighter.Block += Fighter_Block;
            fighter1.Fighter.Wound += Fighter_Wound;
            fighter2.Fighter.Wound += Fighter_Wound;
            fighter1.Fighter.Death += Fighter_Death;
            fighter2.Fighter.Death += Fighter_Death;
            #endregion

            #region Подписка на события окна
            fighter1.FighterWindow.Fight += Fight;
            fighter1.FighterWindow.Reload += Reload;
            #endregion
        }

        #region Обработка собятий бойцов, логирование боя
        private void Fighter_Block(string fighterName, int hp)
        {
            log.LogWindow.Log = $"{fighterName} заблокировал удар и сохранил прежний уровень жизни, равный {hp}\n";
        }
        private void Fighter_Wound(string fighterName, int hp)
        {
            log.LogWindow.Log = $"{fighterName} пропустил удар и теперь уровень его жизни составляет {hp}\n";
        }
        private void Fighter_Death(string fighterName, int hp)
        {
            log.LogWindow.Log = $"{fighterName} проиграл\n";
        }
        #endregion

        #region Обработка событий страницы, логирование боя
        int round = 0;
        private void Fight(object sender, EventArgs e)
        {
            if (log.LogWindow.Log.Length != 0)
                log.LogWindow.Log = "\n\n";

            log.LogWindow.Log = "- - - - - Раунд " + ++round + " - - - - -\n";

            fighter1.FighterWindow.SetRoundSettings(fighter1.Fighter);

            fighter2.Fighter.SetBlock(PartOfTheBody.None);

            fighter1.Fighter.GetHit(fighter2.Fighter.Hit);
            fighter2.Fighter.GetHit(fighter1.Fighter.Hit);

            log.LogWindow.Log = RepeatString("- ", 16);

            fighter1.FighterWindow.FighterHp = fighter1.Fighter.Hp;
            fighter2.ComputerAIWindow.FighterHp = fighter2.Fighter.Hp;
        }
        private void Reload(object sender, EventArgs e)
        {
            log.LogWindow.Log = "";

            round = 0;

            fighter1.Fighter.Hp = 100;
            fighter2.Fighter.Hp = 100;

            fighter1.FighterWindow.FighterHp = 100;
            fighter2.ComputerAIWindow.FighterHp = 100;
        }
        #endregion

        #region Вспомогательные private-методы
        private string RepeatString(string str, int count)
        {
            string newString = "";

            for (int i = 0; i < count; i++)
            {
                newString += str;
            }

            return newString;
        }
        #endregion
    }
}
