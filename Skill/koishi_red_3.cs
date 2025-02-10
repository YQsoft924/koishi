using DarkTonic.MasterAudio;
using GameDataEditor;
using NLog.Targets;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace koishi114
{
    /// <summary>
    /// ＊现在就给你打电话别忘了接哦＊
    /// <color=#009900>＊今から電話をするから出てね＊</color>
    /// <color=#74011e>呐~现在~我就在~你的背后哦</color>
    /// 消耗场上所有敌人的失神buff * 恋恋自己的闪避率 造成攻击并保底240%倍率
    /// </summary>
    public class koishi_red_3 : Skill_Extended
    {
        public override void SkillUseSingle(Skill SkillD, List<BattleChar> Targets)
        {
            int i = 1;
            foreach (BattleEnemy battleEnemy in BattleSystem.instance.EnemyList)
            {
                if (battleEnemy.BuffFind("shishen", false))
                {
                    i += battleEnemy.BuffReturn("shishen", false).StackNum;
                    Buff buff = battleEnemy.BuffReturn("shishen", false);
                    buff.SelfStackDestroy();
                }
            }
            foreach (BattleEnemy battleEnemy in Targets)
            {
                MasterAudio.PlaySound("koishi3", 100, null, 0f, null, null, false, false);
                BattleSystem.DelayInput(this.Skill(battleEnemy, i));
            }
        }
        public IEnumerator Skill(BattleEnemy battleEnemy, int i)
        {
            yield return new WaitForSecondsRealtime(1.5f);
            if(this.BChar.GetStat.dod < 80)
            battleEnemy.Damage(battleEnemy, (int)((this.BChar.GetStat.dod) * i), false, false, false, 0, true, true, true);
            else
            battleEnemy.Damage(battleEnemy, (int)(80 * i), false, false, false, 0, true, true, true);
            yield break;
        }
    }
}
