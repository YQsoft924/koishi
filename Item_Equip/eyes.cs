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
	/// 觉之眼
	/// 古明地恋的姐姐古明地觉的觉之眼的复制品，可以看穿敌人的动向
	/// </summary>
    public class eyes:EquipBase
    {
        public override void TurnUpdate()
        {
			foreach (BattleEnemy battleEnemy in BattleSystem.instance.EnemyList)
			{
                battleEnemy.BuffAdd(GDEItemKeys.Buff_B_Control_P, this.BChar, false, 0, false, -1, false);
            }
		}
    }
}