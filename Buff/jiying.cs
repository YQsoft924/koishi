using GameDataEditor;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace koishi114
{
    /// <summary>
    /// 潜意识の基因
    /// </summary>
    public class jiying : Buff, IP_Dead
    {
        public override void TurnUpdate()
        {
            BattleSystem.DelayInput(this.Skill());
            float i = this.BChar.GetStat.hit;
            float j = (100 - i)/10;
            this.BChar.Damage(BattleSystem.instance.DummyChar, (int)j, false, true, false, 0, false, false, false);
        }
        public void Dead()
        {
            List<BattleChar> list = new List<BattleChar>();
            list.AddRange(this.BChar.MyTeam.AliveChars);
            list.Remove(this.BChar);
            if (list.Count == 0)
            {
                return;
            }
            for (int i = 0; i < base.StackNum; i++)
            {
                list.Random(this.BChar.GetRandomClass().Main).BuffAdd("jiying", base.Usestate_L, false, 500, false, this.StackInfo[i].RemainTime, false);
            }
        }
        public IEnumerator Skill()
        {
            yield return new WaitForSecondsRealtime(1f);
            yield break;
        }
    }
}
