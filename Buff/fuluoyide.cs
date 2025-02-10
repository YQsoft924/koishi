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
    /// 弗洛伊德学说
    /// </summary>
    public class fuluoyide : Buff
    {
        public override void Init()
        {
            base.Init();
            this.PlusStat.dod = (float)(10 * base.StackNum);
        }
        public override void DestroyByTurn()
        {
        List<Skill> list = new List<Skill>();
        list.AddRange(this.BChar.MyTeam.Skills_UsedDeck);
        BattleSystem.instance.AllyTeam.ForceDraw(list.Random());
        }
    }
}