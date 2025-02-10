using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
namespace koishi114
{
    /// <summary>
    /// 潜意识"弹幕的墨迹测验"
    /// </summary>
    public class koishi_10 : Skill_Extended, IP_DamageChange_sumoperation
    {
        public void DamageChange_sumoperation(Skill SkillD, BattleChar Target, int Damage, ref bool Cri, bool View, ref int PlusDamage)
        {
            if (this.BChar.GetStat.dod <80)
                PlusDamage = BattleChar.CalculationResult((float)Damage, 80, 0);
            else
                PlusDamage = BattleChar.CalculationResult((float)Damage, (int)this.BChar.GetStat.dod, 0);
            if (this.BChar.GetStat.dod > 40)
            {
                Cri = true;
            }
        }
        public override void SkillUseSingle(Skill SkillD, List<BattleChar> Targets)
        {
            if (this.BChar.GetStat.dod < 80)
                this.PlusPerStat.Damage = 80;
            else
                this.PlusPerStat.Damage = (int)(this.BChar.GetStat.dod);
            int originalNum = 0;
            foreach (var enemy in BattleSystem.instance.EnemyList.ToList())
            {
                originalNum += enemy.GetBuffs(BattleChar.GETBUFFTYPE.CC, false, false).Sum(buff => buff.StackNum);
            }
            for (int i = 0; i < originalNum; i++)
            {
                BattleSystem.DelayInputAfter(this.Attack(Targets[0]));
            }
        }
        public IEnumerator Attack(BattleChar Target)
        {
            yield return new WaitForSecondsRealtime(0.2f);
            Skill skill = Skill.TempSkill("koishi_10_0", this.BChar, this.BChar.MyTeam);
            skill.PlusHit = true;
            skill.FreeUse = true;
            if (!Target.IsDead)
            {
                this.BChar.ParticleOut(this.MySkill, skill, Target);
            }
            else if (BattleSystem.instance.EnemyList.Count != 0)
            {
                this.BChar.ParticleOut(this.MySkill, skill, BattleSystem.instance.EnemyList.Random(this.BChar.GetRandomClass().Main));
            }
            yield break;

        }
    }
}