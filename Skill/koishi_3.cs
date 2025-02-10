using GameDataEditor;
using Spine;
using System.Collections.Generic;

namespace koishi114
{
    /// <summary>
    /// 	本能"本我的解放"
    /// 本能「イドの解放」
    /// </summary>
    public class koishi_3 : Skill_Extended
    {
        public override void FixedUpdate()
        {
            this.Flag = true;
            if (this.BChar.BuffFind("bengwo", false))
            {
                this.Flag = false;
            }
        }
        public override bool Terms()
        {
            return this.Flag;
        }
        public bool Flag;
        public override void SkillUseSingle(Skill SkillD, List<BattleChar> Targets)
        {
            Skill skill = Skill.TempSkill("koishi_4", this.BChar, this.BChar.MyTeam);
            skill.NotCount = true;
            skill.isExcept = true;
            skill.AutoDelete = 1;
            BattleSystem.instance.AllyTeam.Add(skill,true);
        }
    }
}

