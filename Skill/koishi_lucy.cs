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
    public class koishi_lucy:Skill_Extended
    {
        public override void SkillUseSingle(Skill SkillD, List<BattleChar> Targets)
        {
            foreach (BattleChar battleChar in BattleSystem.instance.AllyTeam.AliveChars)
            {
                battleChar.BuffAdd("huanxing", battleChar, false, 0, false, -1, false);
            }
            BattleSystem.instance.AllyTeam.Draw();
            BattleSystem.instance.AllyTeam.Draw();
        }
    }
}