using System.Collections;
using UnityEngine;
namespace koishi114
{
    /// <summary>
    /// 表象"弹幕偏执症"
    /// 表象「弾幕パラノイア」
    /// 对地方全体造成80%攻击力伤害，每次攻击有30%概率附加一层“失神”，成功施加“失神”后追加攻击50%攻击
    /// </summary>
    public class koishi114_koishi_2 : Skill_Extended
    {
        public override void SkillUseHand(BattleChar Target)
        {
            BattleSystem.DelayInput(this.Skill());
        }
        public IEnumerator Skill()
        {
            foreach (BattleEnemy battleEnemy in BattleSystem.instance.EnemyList)
            {
                if (battleEnemy.BuffFind("shishen", false))
                {
                    battleEnemy.Damage(this.BChar, (int)(this.BChar.GetStat.atk * 0.5f), false, false, false, 0, true, true, true);
                }
            }
            yield return new WaitForSecondsRealtime(0.2f);//延迟0.2秒
            yield break;
        }
    }
}




