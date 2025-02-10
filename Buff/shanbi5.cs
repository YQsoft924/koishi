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
	/// 埋火
	/// </summary>
    public class shanbi5:Buff
    {
        public override void Init()
        {
            base.Init();
            this.PlusStat.AggroPer = 30;
            this.PlusStat.dod = (float)(10 * base.StackNum);
        }
    }
}