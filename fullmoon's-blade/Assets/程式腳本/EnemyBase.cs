using UnityEngine;

public class EnemyBase : MonoBehaviour
{
    #region 欄位
    [Header("血量"), Tooltip("怪物戰鬥後擁有的血量"), Range(50, 300)]
    public float Hp = 32;
    [Header("魔力"), Tooltip("怪物入場時獲得的魔力"), Range(0, 100)]
    public float Mana = 12;
    [Header("抽牌數"),Tooltip("怪物每回合開始抽取手牌，直到與該數字相同"),Range(0,6)]
    public int CardDraw = 2;
    #endregion
    #region 事件
    #endregion
    #region 方法
    #endregion
}
