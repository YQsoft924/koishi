using ChronoArkMod;
namespace koishi114
{
    public static class ModItemKeys
    {
		/// <summary>
		/// 本我的解放
		/// <color=#999999>本我代表思绪的原始程序——人最为原始的、属满足本能冲动的欲望 </color>
		/// </summary>
        public static string Buff_bengwo = "bengwo";
		/// <summary>
		/// 被识破
		/// 雕虫小计，竟敢班门弄斧
		/// 知道我姐是谁吗就敢上来打
		/// </summary>
        public static string Buff_cehuangyi = "cehuangyi";
		/// <summary>
		/// 无意识
		/// 大幅降低被攻击概率
		/// 加攻击力
		/// </summary>
        public static string Skill_choose_1 = "choose_1";
		/// <summary>
		/// 保留自我
		/// 大幅增加被攻击概率
		/// 加闪避率
		/// </summary>
        public static string Skill_choose_2 = "choose_2";
		/// <summary>
		/// 空想上的人格保持者
		/// 打出之后，给恋恋提供10%闪避率加成
		/// </summary>
        public static string SkillExtended_EX_koishi = "EX_koishi";
		/// <summary>
		/// 觉之眼
		/// 每回合给敌方施加洞察buff
		/// 古明地恋的姐姐古明地觉的觉之眼的复制品，可以看穿敌人的动向
		/// <color=#999999>似乎被纳尔汗改进过 </color>
		/// </summary>
        public static string Item_Equip_eyes = "eyes";
		/// <summary>
		/// 弗洛伊德学说
		/// 消失后从弃牌堆中随机抽取一张牌
		/// <color=#999999>潜意识论在弗洛伊德主义中占有特别重要的地位，它是精神分析学的基石和核心，弗洛伊德的其他一些基本理论都是从不同侧面论证和阐释潜意识论的。 </color>
		/// </summary>
        public static string Buff_fuluoyide = "fuluoyide";
        public static string Character_Skin_fumo = "fumo";
		/// <summary>
		/// 潜意识唤醒
		/// </summary>
        public static string Buff_huanxing = "huanxing";
		/// <summary>
		/// 潜意识の基因
		/// 会根据命中率的降低提高伤害
		/// <color=#999999>荣格认为，在潜意识中有着从祖先那里遗传下来的经验积累 </color>
		/// </summary>
        public static string Buff_jiying = "jiying";
		/// <summary>
		/// 古明地恋
		/// Passive:
		/// <color=#009900>閉じた恋の瞳 </color>
		/// 操控无意识程度的能力
		/// 降低被攻击的概率，增加20%闪避概率，每次闪避敌人攻击时，抽1张牌并打出（优先抽取自己的牌，不会打出其他人的牌）。
		/// </summary>
        public static string Character_koishi114_koishi = "koishi114_koishi";
		/// <summary>
		/// 心符“忘我之爱”
		/// <color=#009900>心符「没我の愛」 </color>
		/// </summary>
        public static string Skill_koishi114_koishi_1 = "koishi114_koishi_1";
		/// <summary>
		/// 潜意识"弹幕的墨迹测验"
		/// <color=#009900>無意識「弾幕のロールシャッハ」 </color>
		/// 根据所有敌人拥有的干扰buff总层数追加攻击（对有干扰buff的敌人使用时会额外触发追加攻击）此技能伤害最终乘以闪避率结算（包括追加攻击）
		/// </summary>
        public static string Skill_koishi_10 = "koishi_10";
        public static string Skill_koishi_10_0 = "koishi_10_0";
        public static string SimpleCampDialogue_koishi_114 = "koishi_114";
		/// <summary>
		/// 表象"弹幕偏执症"
		/// <color=#009900>表象「弾幕パラノイア」 </color>
		/// 对有“失神”的敌人额外再造成50%攻击
		/// </summary>
        public static string Skill_koishi114_koishi_2 = "koishi114_koishi_2";
		/// <summary>
		/// 本能"本我的解放"
		/// <color=#009900>本能「イドの解放」 </color>
		/// 当自身已存在此buff时该技能无法使用 
		/// 将一张"抑制'超我'"放入手牌
		/// </summary>
        public static string Skill_koishi_3 = "koishi_3";
		/// <summary>
		/// 抑制"超我"
		/// <color=#009900>抑制「スーパーエゴ」 </color>
		/// 当没有“本我的解放”buff时，抽1张牌
		/// 当自身存在“本我的解放”buff时，解除“本我的解放”buff，从牌库和废牌库各抽1张牌并回复1费
		/// </summary>
        public static string Skill_koishi_4 = "koishi_4";
		/// <summary>
		/// 复燃“恋爱的埋火”
		/// <color=#009900>復燃「恋の埋火」 </color>
		/// 倒计时期间内，恋恋受攻击概率增加，闪避率提高5%,若自身存在“本我的解放”，回复一点法力值且闪避率增加10%
		/// 再次击中敌方时扣除目标10%最大生命值
		/// </summary>
        public static string Skill_koishi_5 = "koishi_5";
		/// <summary>
		/// 深层“潜意识的基因”
		/// <color=#009900>深層「無意識の遺伝子」 </color>
		/// </summary>
        public static string Skill_koishi_6 = "koishi_6";
		/// <summary>
		/// 反应"妖怪测谎机"
		/// <color=#009900>反応「妖怪ポリグラフ」 </color>
		/// 对存在“失神”的敌人使用时施加“被识破”，下回合攻击必定被闪避
		/// 对不存在“失神”的敌人使用时，使敌人陷入眩晕
		/// </summary>
        public static string Skill_koishi_7 = "koishi_7";
		/// <summary>
		/// “胎儿之梦”
		/// <color=#009900>「胎児の夢」 </color>
		/// 连续造成3次攻击，每次攻击有概率附加失神buff，伤害和附加概率随次数递增（30%+60%+90%）
		/// </summary>
        public static string Skill_koishi_8 = "koishi_8";
		/// <summary>
		/// 本能"弗洛伊德学说"
		/// <color=#009900>本能「フロウディアン」 </color>
		/// </summary>
        public static string Skill_koishi_9 = "koishi_9";
		/// <summary>
		/// 潜意识唤醒
		/// 给予全体友军2回合“闪避率+5”
		/// 抽2张牌
		/// </summary>
        public static string Skill_koishi_lucy = "koishi_lucy";
		/// <summary>
		/// <color=#66ffcc>「被厌恶者的哲学」</color>
		/// <color=#009900>「嫌われ者のフィロソフィ」</color>
		/// 选择进入无意识亦或者保留自我
		/// 进入无意识时将会大幅降低被攻击概率，且增加攻击力
		/// 保留自我会增加被攻击概率，并增加闪避率
		/// </summary>
        public static string Skill_koishi_red_1 = "koishi_red_1";
		/// <summary>
		/// <color=#cc3300>现在就给你打电话别忘了接哦</color> 
		/// <color=#009900>＊今から電話をするから出てね＊</color>
		/// <color=#8f142f>呐~现在~我就在~你的背后哦</color>
		/// 消耗场上所有敌人的失神buff，造成攻击为总层数*恋恋闪避率（按%前面算）的伤害
		/// </summary>
        public static string Skill_koishi_red_3 = "koishi_red_3";
		/// <summary>
		/// <color=#fed674>“Subterranean Rose”（地底的蔷薇） </color>
		/// <color=#009900>「サブタレイニアンローズ」 </color>
		/// 抹除自身气息，潜入黑暗，之后获得蔷薇绽放（+20%攻击，+10%闪避，被攻击概率增加）
		/// </summary>
        public static string Skill_koizhi_red_2 = "koizhi_red_2";
		/// <summary>
		/// 空想上的人格保持者
		/// </summary>
        public static string Buff_kongxiang = "kongxiang";
		/// <summary>
		/// 恋之埋火
		/// （似乎只有恋恋可以触动它）
		/// <color=#999999>把炭火埋在灰烬之中。因为灰烬有着良好的隔热性能，同时也可以把炭火和空气隔绝开来，所以可以把炭火的能量保存相当长的一段时间。之后只要供给氧气，炭火就可以重新燃烧起来。 </color>
		/// </summary>
        public static string Buff_maihuo = "maihuo";
		/// <summary>
		/// 无意识妖怪帽子
		/// </summary>
        public static string Item_Equip_maozi = "maozi";
        public static string Character_Skin_pyhua = "pyhua";
		/// <summary>
		/// 潜入黑暗
		/// 无法攻击，每回合回复50%血量。
		/// <color=#999999>サブタレイニアン（subterranean）
		/// 可以解作“地下的、表面下的”或者“隐藏、秘密的”
		/// 居住在地下的人，栖息在地底的生物 </color>
		/// </summary>
        public static string Buff_qiangwei = "qiangwei";
        public static string SkillEffect_SE_S_choose_1 = "SE_S_choose_1";
        public static string SkillEffect_SE_S_choose_2 = "SE_S_choose_2";
        public static string SkillEffect_SE_S_koishi_3 = "SE_S_koishi_3";
        public static string SkillEffect_SE_S_koishi_9 = "SE_S_koishi_9";
        public static string SkillEffect_SE_S_koizhi_red_2 = "SE_S_koizhi_red_2";
        public static string SkillEffect_SE_Tick_bengwo = "SE_Tick_bengwo";
        public static string SkillEffect_SE_Tick_jiying = "SE_Tick_jiying";
        public static string SkillEffect_SE_Tick_maihuo = "SE_Tick_maihuo";
        public static string SkillEffect_koishi114_SE_T_koishi114_koishi_1 = "koishi114_SE_T_koishi114_koishi_1";
        public static string SkillEffect_koishi114_SE_T_koishi114_koishi_2 = "koishi114_SE_T_koishi114_koishi_2";
        public static string SkillEffect_SE_T_koishi1_10_0 = "SE_T_koishi1_10_0";
        public static string SkillEffect_SE_T_koishi_10 = "SE_T_koishi_10";
        public static string SkillEffect_SE_T_koishi_10_0 = "SE_T_koishi_10_0";
        public static string SkillEffect_SE_T_koishi_3 = "SE_T_koishi_3";
        public static string SkillEffect_SE_T_koishi_5 = "SE_T_koishi_5";
        public static string SkillEffect_SE_T_koishi_6 = "SE_T_koishi_6";
        public static string SkillEffect_SE_T_koishi_7 = "SE_T_koishi_7";
        public static string SkillEffect_SE_T_koishi_red_3 = "SE_T_koishi_red_3";
		/// <summary>
		/// 埋火
		/// <color=#999999>紧闭的第三只眼似乎变得柔和起来 </color>
		/// </summary>
        public static string Buff_shanbi5 = "shanbi5";
		/// <summary>
		/// 失神
		/// <color=#999999>一语双关（恋恋不好看嘛QAQ？） </color>
		/// </summary>
        public static string Buff_shishen = "shishen";
		/// <summary>
		/// 无意识
		/// 大幅降低被攻击概率
		/// 加攻击力
		/// </summary>
        public static string Buff_wuyishi = "wuyishi";
		/// <summary>
		/// 蔷薇绽放
		/// <color=#999999>A rose by any other name would smell as sweet.
		/// 玫瑰无论被称作什么名字，都是芳香的；无论表面上被如何遮掩，本质是不会改变的
		/// 玫瑰的花语，根据花的颜色及大小而有所不同，但总体来说，代表爱和恋。 </color>
		/// </summary>
        public static string Buff_zhanfang = "zhanfang";
		/// <summary>
		/// 自我
		/// </summary>
        public static string Buff_ziwo = "ziwo";
        public static string Character_Skin_zun = "zun";

    }

    public static class ModLocalization
    {

    }
}