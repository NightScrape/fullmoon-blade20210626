using UnityEngine;

public class MainCharacterBase : MonoBehaviour
{
    #region 欄位
    /// <summary>
    /// 定義角色初始屬性及成長
    /// </summary>
    [Header("初始血量"),Tooltip("角色進入遊戲時擁有與其相同的生命上限"), Range(50, 300)]
    public float HpOrigin = 50;
    [Header("初始魔力"),Tooltip("角色進入遊戲後擁有的初始魔力，在戰鬥結束後回到原數值"),Range(0, 100)]
    public float ManaOrigin = 8;
    [Header("手牌上限"), Range(1, 8)]
    public int DrawLimit = 3;
    [Header("等級"), Range(1, 11)]
    public int Level = 1;
    [Header("血量成長"), Tooltip("角色每次升級後獲得對應的血量上限"), Range(0, 50)]
    public float HpAdd = 10;
    [Header("魔力增強"), Tooltip("因為事件而增加的魔力會加到原有的初始魔力值，增強部分不因戰鬥結束而消失"), Range(0, 30)]
    public float ManaAdd = 8;
    [Header("當前血量")]
    public float HpCurrent;
    [Header("當前魔力")]
    public float ManaCurrent;
    [Header("角色技能冷卻"), Tooltip("角色技能冷卻為0時可以發動對應的技能"), Range(0, 10)]
    public int SkillCooldown = 5; //若角色持有的技能為被動，則改為0
    #endregion
    #region 事件
    private void Start()
    {
        HpCurrent = HpOrigin;
        ManaCurrent = ManaOrigin;
        SkillCooldown = 0;
    }
    #endregion
    #region 方法
    #endregion
}
