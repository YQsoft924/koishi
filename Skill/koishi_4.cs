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
using Spine;
namespace koishi114
{
	/// <summary>
	/// 抑制"超我"
	/// 抑制「スーパーエゴ」
	/// 当没有“本我的解放”buff时，抽1张牌
	/// 解除“本我的解放”buff，抽2张牌并回复1费
	/// </summary>
    public class koishi_4:Skill_Extended
    {
        public override void Init()
        {
            base.Init();
            this.SkillParticleObject = new GDESkillExtendedData(GDEItemKeys.SkillExtended_Public_1_Ex).Particle_Path;
        }
        public override void SkillUseSingle(Skill SkillD, List<BattleChar> Targets)
		{
            base.SkillUseSingle(SkillD, Targets);
            BattleSystem.instance.AllyTeam.CharacterDraw(this.BChar);
            if (this.BChar.BuffFind("bengwo",false))
			{
                List<Skill> list = new List<Skill>();
                list.AddRange(this.BChar.MyTeam.Skills_UsedDeck);
                BattleSystem.instance.AllyTeam.ForceDraw(list.Random());
                BattleSystem.instance.AllyTeam.AP += 1;
                Buff buff = this.BChar.BuffReturn("bengwo", false);
                buff.SelfStackDestroy();
            }
        }
        public override void FixedUpdate()
        {
            base.FixedUpdate();
            if (this.BChar.BuffFind("bengwo", false))
            {
                base.SkillParticleOn();
            }
            else
            {
                base.SkillParticleOff();
            }
        }
    }
}