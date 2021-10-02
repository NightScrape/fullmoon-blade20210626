using UnityEngine;
using UnityEngine.UI;

public class BasePlayer : MonoBehaviour
{
    #region 欄位
    [Header("基礎屬性"), Tooltip("顯示當前角色身上所有數據")]
    [Header("最大生命"), Range(0, 5000)]
    public float hpMax = 30;
    [Range(0, 2000)]
    public float atk = 5;
    [Range(0, 10)]
    public float ApMax = 3;
    public float hp;
    public float Ap;
    public float Rage = 0;
    [Header("當量顯示"), Tooltip("目的是為了同步紀錄相關數據")]
    public Image HealthBar;
    public Text HpPlayer;
    public Text PlayerState;
    #endregion
    #region 事件
    private void Start()
    {
        SetStates();
    }
    private void Update()
    {
        StateCheck();
    }
    #endregion
    #region 方法
    private void SetStates()
    {
        hp = hpMax;
        Ap = 0;
        Rage = 0;
        HealthBar.fillAmount = hp / hpMax;
        HpPlayer.text = "Hp = " + hp / hpMax;
    }
    private void StateCheck()
    {
        HealthBar.fillAmount = hp / hpMax;
        HpPlayer.text = "Hp = " + hp / hpMax;
    }
    private void Attack()
    {

    }
    private void Recover()
    {

    }
    public void Injure(float damage)
    {

    }
    #endregion
}
