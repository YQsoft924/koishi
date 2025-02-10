namespace koishi114
{
    /// <summary>
    /// 潜入黑暗
    /// </summary>
    public class qiangwei : Buff, IP_TurnEnd
    {
        public override void Init()
        {
            base.Init();
            this.NoShowTimeNum_Tooltip = true;
            this.OnePassive = true;
        }
        public void TurnEnd()
        {
            this.BChar.Heal(this.BChar, this.BChar.GetStat.maxhp * 0.5f, false, true, null);
        }
        public override void DestroyByTurn()
        {
            base.DestroyByTurn();
            this.BChar.BuffAdd("zhanfang", this.BChar, false, 0, false, -1, false);
        }
    }
}