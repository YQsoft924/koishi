using GameDataEditor;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
namespace koishi114
{
    public class koishi : Skill_Extended
    {
        public override void SkillUseSingle(Skill SkillD, List<BattleChar> Targets)
        {
            foreach (BattleChar battleChar in BattleSystem.instance.AllyTeam.AliveChars)
            {
                if (this.koishi114_koishi != null)
                {
                    this.BChar.BuffAdd("kongxiang", this.koishi114_koishi.BChar, false, 999, false, -1, false);
                }
            }
        }
        public P_koishi114_koishi koishi114_koishi;
    }
}