using UnityEngine.UI;
using UnityEngine;

public class BattleSystem : MonoBehaviour
{
    #region ���
    public enum BattleStates
    {
        Start,PlayerTurn,EnemyTurn,Victory,Defeat
    }
    [Header("�T�{�D���v"),Tooltip("�Y����쬰�u�A�Y�����a��ʶ��q")]
    public bool PlayerisActive = true;
    public Button Endphase;
    [Header("���a�M�Ǫ�"),Tooltip("�T�{���a��Ǫ�")]
    public GameObject Gamer;
    public GameObject Enemy;
    #endregion
    #region �ƥ�
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
    #region ��k
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
