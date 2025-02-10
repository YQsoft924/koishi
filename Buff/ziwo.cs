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
	/// 自我
	/// </summary>
    public class ziwo:Buff
    {
        public override void Init()
        {
            base.Init();
            this.OnePassive = true;
            this.PlusStat.AggroPer = 60;
            this.PlusStat.dod = 20;
        }
    }
}