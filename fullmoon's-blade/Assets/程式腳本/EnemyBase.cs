using UnityEngine;

public class EnemyBase : MonoBehaviour
{
    #region 逆
    [Header("﹀秖"), Tooltip("┣驹矮局Τ﹀秖"), Range(0, 500)]
    public float Hp = 32;
    [Header("﹀秖"), Tooltip("讽玡﹀秖ぃ穦禬筁程")]
    public float HpMax;
    [Header("┾礟计"),Tooltip("┣–秨﹍┾も礟籔赣计"),Range(0,6)]
    public int CardDraw = 2;
    [Header("┣单"),Range(1,10)]
    public int EnemyLevel = 1;
    enum Action
    {
        instantAttack,delayedAttack,armor,recover,wait
    }
    #endregion
    #region ㄆン
    #endregion
    #region よ猭
    #endregion
}
