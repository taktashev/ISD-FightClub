using FightClub.Interfaces;
using FightClub.Models;
using System;

namespace FightClub.Presenters
{
    class FightPresenter
    {
        readonly IFightPage fightPage;
        readonly IFighter fighter1;
        readonly IFighter fighter2;

        public FightPresenter(IFightPage fightPage, IFighter fighter1, IFighter fighter2)
        {
            this.fightPage = fightPage;
            this.fighter1 = fighter1;
            this.fighter2 = fighter2;

            #region Подписка на события бойцов 
            fighter1.Block += Fighter_Block;
            fighter2.Block += Fighter_Block;
            fighter1.Wound += Fighter_Wound;
            fighter2.Wound += Fighter_Wound;
            fighter1.Death += Fighter_Death;
            fighter2.Death += Fighter_Death;
            #endregion

            #region Подписка на события страницы
            fightPage.Fight += FightPage_Fight;
            fightPage.Reload += FightPage_Reload;
            #endregion
        }

        #region Обработка собятий бойцов, логирование боя
        private void Fighter_Block(string fighterName, int hp)
        {
            fightPage.Log = $"{fighterName} заблокировал удар и сохранил прежний уровень жизни, равный {hp}\n";
        }
        private void Fighter_Wound(string fighterName, int hp)
        {
            fightPage.Log = $"{fighterName} пропустил удар и теперь уровень его жизни составляет {hp}\n";
        }
        private void Fighter_Death(string fighterName, int hp)
        {
            fightPage.Log = $"{fighterName} проиграл\n";
        }
        #endregion

        #region Обработка событий страницы, логирование боя
        int round = 0;
        private void FightPage_Fight(object sender, EventArgs e)
        {
            fightPage.Log = "- - - - - Раунд " + ++round + " - - - - -\n";
            
            fightPage.SetRoundSettings(fighter1);

            fighter2.SetBlock(PartOfTheBody.None);

            fighter1.GetHit(fighter2.Hit);
            fighter2.GetHit(fighter1.Hit);

            fightPage.Log = RepeatString("- ", 16) + "\n\n";

            fightPage.Fighter1Hp = fighter1.Hp;
            fightPage.Fighter2Hp = fighter2.Hp;
        }
        private void FightPage_Reload(object sender, EventArgs e)
        {
            round = 0;

            fighter1.Hp = 100;
            fighter2.Hp = 100;

            fightPage.Fighter1Hp = 100;
            fightPage.Fighter2Hp = 100;
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
