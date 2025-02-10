using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace koishi114
{
    /// <summary>
    /// “胎儿之梦”
    /// <color=#009900>「胎児の夢」 </color>
    /// 连续造成4次攻击，每次攻击有概率附加失神buff，伤害和附加概率随次数递增
    /// </summary>
    public class koishi_8 : Skill_Extended
    {
        public override void SkillUseSingle(Skill SkillD, List<BattleChar> Targets)
        {
            foreach (BattleEnemy battleEnemy in Targets)
            {
                System.Random random = new System.Random();
                double j = 0.3;
                for (int i = 0; i < 3; i++)
                {
                    battleEnemy.Damage(battleEnemy, (int)((this.BChar.GetStat.atk) * j), false, false, false, 0, false, false, false);
                    BattleSystem.DelayInput(this.Skill());
                    double probability = j+1;
                    if (random.NextDouble() < probability)
                    {
                        battleEnemy.BuffAdd("shishen", BattleSystem.instance.DummyChar, false, 0, false, -1, false);
                    }
                    j = j + 0.3;
                }
            }
        }
        public IEnumerator Skill()
        {
            yield return new WaitForSecondsRealtime(0.4f);//延迟0.2秒
            yield break;
        }
    }
}