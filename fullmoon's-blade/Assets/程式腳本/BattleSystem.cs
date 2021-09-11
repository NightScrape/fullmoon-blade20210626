using UnityEngine.UI;
using UnityEngine;

public class BattleSystem : MonoBehaviour
{
    #region 欄位
    public enum BattleStates
    {
        Start,PlayerTurn,EnemyTurn,Victory,Defeat
    }
    [Header("確認主動權"),Tooltip("若此欄位為真，即為玩家行動階段")]
    public bool PlayerisActive = true;
    public Button Endphase;
    [Header("玩家和怪物"),Tooltip("確認玩家跟怪物")]
    public GameObject Gamer;
    public GameObject Enemy;
    #endregion
    #region 事件
    void Start()
    {
        ResetStatus();
    }
    private void Update()
    {
        TurnCheck();
    }
    private void FixedUpdate()
    {
        StatusCheck();
        
    }
    #endregion
    #region 方法
    private void ResetStatus()
    {
    }
    private void TurnCheck()
    {
        if (PlayerisActive == true) TurnPlayer();
        else TurnEnemy();
    }
    private void StatusCheck()
    {

    }
    private void TurnPlayer()
    {

        if (Input.GetButtonDown(Endphase.name))
        {
            Endphase.enabled = false;
            PlayerisActive = false;
        }
    }
    private void TurnEnemy()
    {
        Endphase.enabled = true;
        PlayerisActive = true;
    }
    #endregion

}
