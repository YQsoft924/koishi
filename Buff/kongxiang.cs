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
	/// 空想上的人格保持者
	/// </summary>
    public class kongxiang:Buff
    {
        public override void Init()
        {
            base.Init();
            this.PlusStat.dod = 10;
        }
    }
}