
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using GameDataEditor;
using I2.Loc;
using DarkTonic.MasterAudio;
using ChronoArkMod;
using ChronoArkMod.Plugin;
using ChronoArkMod.Template;
using Debug = UnityEngine.Debug;
namespace koishi114
{
    /// <summary>
    /// 古明地恋
    /// Passive:
    /// 閉じた恋の瞳
    /// 操控无意识程度的能力
    /// </summary>
    public class P_koishi114_koishi : Passive_Char, IP_Dodge
    {
        public override void Init()
        {
            base.Init();
            this.OnePassive = true;
            this.PlusStat.AggroPer = -20;
            this.PlusStat.dod = 20;
        }
        public void Dodge(BattleChar Char, SkillParticle SP)
        {
            if (Char == this.BChar)
            {
                BattleSystem.DelayInput(this.draw());
            }
        }
        public void Drawinput(Skill skill)
        {
            if (skill.Master.Info.KeyData == "koishi114_koishi")
            {
                BattleSystem.DelayInputAfter(BattleSystem.instance.SkillRandomUseIenum(skill.Master, skill, false, false, true));
            }
        }
        public IEnumerator draw()
        {
            yield return new WaitForSecondsRealtime(0.1f);
            Skill skill2 = BattleSystem.instance.AllyTeam.Skills_Deck.Find((Skill skill) => skill.Master == this.BChar);
            if (skill2 == null)
            {
                yield return null;
            }
            else
            {
                yield return BattleSystem.instance.StartCoroutine(BattleSystem.instance.AllyTeam._ForceDraw(skill2, Drawinput));
            }
            BattleSystem.instance.StartCoroutine(BattleSystem.instance.ActWindow.Window.SkillInstantiate(BattleSystem.instance.AllyTeam, true));
            yield break;
        }
    }
}



