using GameDataEditor;
using System;
using System.Collections.Generic;
namespace koishi114
{
    /// <summary>
    /// 反应"妖怪测谎机"
    /// <color=#009900>反応「妖怪ポリグラフ」 </color>
    /// </summary>
    public class koishi_7 : Skill_Extended
    {
        public override void SkillUseSingle(Skill SkillD, List<BattleChar> Targets)
        {
            foreach (BattleEnemy battleEnemy in Targets)
            {
                if (battleEnemy.GetBuffs(BattleChar.GETBUFFTYPE.CC, false, false).Count >= 1)
                {
                    battleEnemy.BuffAdd("cehuangyi", BattleSystem.instance.DummyChar, false, 0, false, -1, false);
                }
                else
                {
                    battleEnemy.BuffAdd(GDEItemKeys.Buff_B_Common_Rest, battleEnemy, false, 120, false, -1, false);
                }
            }
        }
    }
}