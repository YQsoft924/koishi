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
	/// 无意识妖怪帽子
	/// </summary>
    public class maozi:EquipBase, IP_Dodge
    {
        public override void Init()
        {
            base.Init();
            this.PlusStat.dod = 20;
        }
        public void Dodge(BattleChar Char, SkillParticle SP)
        {
            Char.Heal(BattleSystem.instance.DummyChar, this.BChar.GetStat.atk * 0.25f, false, true, null);
        }
    }
}