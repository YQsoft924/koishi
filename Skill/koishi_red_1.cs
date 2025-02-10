using GameDataEditor;
using I2.Loc;
using System.Collections.Generic;

namespace koishi114
{
    /// <summary>
    ///  "被厌恶者的哲学"   
    /// <color=#009900>「嫌われ者のフィロソフィ」</color>
    /// </summary>
    public class koishi_red_1 : Skill_Extended
    {
        public override void SkillUseSingle(Skill SkillD, List<BattleChar> Targets)
        {
            foreach (BattleChar battleChar in Targets)
            {
                List<Skill> list = new List<Skill>
                    {
                         Skill.TempSkill("choose_1", this.BChar, BattleSystem.instance.AllyTeam),
                         Skill.TempSkill("choose_2", this.BChar, BattleSystem.instance.AllyTeam)
                    };
                BattleSystem.instance.EffectDelays.Enqueue(BattleSystem.I_OtherSkillSelect(list, new SkillButton.SkillClickDel(this.Del), ScriptLocalization.System_SkillSelect.EffectSelect, false, false, true, false, false));
            }
        }
        public void Del(SkillButton Mybutton)
        {
            bool flag = Mybutton.Myskill.MySkill.KeyID == "choose_1";
            if (flag)
            {
                this.BChar.BuffAdd("wuyishi", this.BChar, false, 0, false, -1, false);
            }
            bool flag2 = Mybutton.Myskill.MySkill.KeyID == "choose_2";
            if (flag2)
            {
                this.BChar.BuffAdd("ziwo", this.BChar, false, 0, false, -1, false);

            }
        }
    }
}