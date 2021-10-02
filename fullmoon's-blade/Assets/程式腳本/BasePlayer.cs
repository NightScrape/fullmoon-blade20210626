using UnityEngine;
using UnityEngine.UI;

public class BasePlayer : MonoBehaviour
{
    #region ���
    [Header("��¦�ݩ�"), Tooltip("��ܷ�e���⨭�W�Ҧ��ƾ�")]
    [Header("�̤j�ͩR"), Range(0, 5000)]
    public float hpMax = 30;
    [Range(0, 2000)]
    public float atk = 5;
    [Range(0, 10)]
    public float ApMax = 3;
    public float hp;
    public float Ap;
    public float Rage = 0;
    [Header("��q���"), Tooltip("�ت��O���F�P�B���������ƾ�")]
    public Image HealthBar;
    public Text HpPlayer;
    public Text PlayerState;
    #endregion
    #region �ƥ�
    private void Start()
    {
        SetStates();
    }
    private void Update()
    {
        StateCheck();
    }
    #endregion
    #region ��k
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
