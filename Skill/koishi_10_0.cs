namespace koishi114
{
    public class koishi_10_0 : Skill_Extended
    {
        public void DamageChange_sumoperation(Skill SkillD, BattleChar Target, int Damage, ref bool Cri, bool View, ref int PlusDamage)
        {
            if (this.BChar.GetStat.dod < 80)
                PlusDamage = BattleChar.CalculationResult((float)Damage, 80, 0);
            else
                PlusDamage = BattleChar.CalculationResult((float)Damage, (int)this.BChar.GetStat.dod, 0);
        }
        public override void AttackEffectSingle(BattleChar hit, SkillParticle SP, int DMG, int Heal)
        {
            if (hit.GetBuffs(BattleChar.GETBUFFTYPE.CC, false, false).Count >= 1)
            {
                hit.Damage(this.BChar, (int)(this.BChar.GetStat.atk * 0.4f), false, false, false, 0, true, true, true);
            }
        }
    }
}