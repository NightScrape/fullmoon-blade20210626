using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Linq;

public class MainCharacterBase : MonoBehaviour
{
    #region 公開欄位 角色屬性
    /// <summary>
    /// 定義角色初始屬性及成長
    /// </summary>
    [Header("初始血量"), Tooltip("角色進入遊戲時擁有與其相同的生命上限"), Range(50, 300)]
    public float HpOrigin = 50;
    [Header("當前血量")]
    public float HpCurrent;
    [Header("血量上限"), Tooltip("當前血量不會超過最大值")]
    public float HpMax;
    [Header("初始魔力"), Tooltip("角色進入遊戲後擁有的初始魔力，在戰鬥結束後回到原數值"), Range(0, 100)]
    public float ManaOrigin = 5;
    [Header("當前魔力")]
    public float ManaCurrent;
    [Header("當前初始魔力"), Tooltip("戰鬥結束後調回原值")]
    public float ManaMax;
    [Header("等級"), Range(1, 11)]
    public int Level = 1;
    [Header("經驗值")]
    public int Experience;
    [Header("持有金錢")]
    public int gold;
    #endregion
    #region 公開欄位 其他
    [Header("血量成長"), Tooltip("角色每次升級後獲得對應的血量上限"), Range(0, 50)]
    public float HpAdd = 10;
    [Header("手牌上限"), Range(1, 8)]
    public int DrawLimit = 4;
    [Header("升級所需經驗值"), Tooltip("當前經驗值超過升級所需，則會減少相應值升級")]  //構思資料矩陣化中
    public int ExpNeeded;
    #endregion
    #region 不公開欄位
    #endregion
    #region 事件
    private void Start()
    {
        CharacterReset();
    }
    private void Update()
    {
        AfterBattle(Level);
    }
    #endregion
    #region 方法
    private void CharacterReset()  //此方法為設定角色進場時的預設值
    {
        HpMax = HpOrigin;
        HpCurrent = HpMax;
        ManaCurrent = ManaMax;
    }
    private void AfterBattle(int exp)  //每次戰鬥結束後進行調整
    {
        gold += Random.Range(10, 25);
        Experience += exp;
        ManaCurrent = ManaOrigin;
        if (Experience >= ExpNeeded) LevelUP();
    }
    private void LevelUP()  //角色升級
    {
        Experience = Experience - ExpNeeded;
        Level++;
        HpCurrent = HpMax = HpOrigin + HpAdd * Level;
    }
    public void Hurt()
    {
        if (HpCurrent <= 0) Dead();
    }
    private void Dead() //角色死亡
    {
        HpCurrent = 0;
        enabled = false;
    }
    #endregion
}
