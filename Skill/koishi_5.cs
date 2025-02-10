using GameDataEditor;
using System.Collections.Generic;
namespace koishi114
{
    public class koishi_5 : Skill_Extended
    {
        public override void Init()
        {
            base.Init();
            this.SkillParticleObject = new GDESkillExtendedData(GDEItemKeys.SkillExtended_Public_1_Ex).Particle_Path;
        }
        public override void SkillUseHand(BattleChar Target)
        {
            if (this.BChar.BuffFind("bengwo", false))
            {
                BattleSystem.instance.AllyTeam.AP += 1;
            }
        }
        public override void SkillUseSingle(Skill SkillD, List<BattleChar> Targets)
        {
            foreach (BattleChar battleChar in BattleSystem.instance.EnemyList)
            {
                if (battleChar.BuffFind("maihuo", false))
                {
                    battleChar.Damage(battleChar, (int)(battleChar.HP * 0.1f), false, true, false, 0, false, false, false);
                    Buff buff = battleChar.BuffReturn("maihuo", false);
                    buff.SelfStackDestroy();
                }
                else
                {
                    battleChar.BuffAdd("maihuo", BattleSystem.instance.DummyChar, false, 0, false, -1, false);
                }
            }
        }
        public void SkillCasting(CastingSkill ThisSkill)
        {

            if (this.BChar.BuffFind("bengwo", false))
            {
                this.PlusStat.hit = -10f;
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
