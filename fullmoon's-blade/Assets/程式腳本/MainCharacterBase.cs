using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Linq;

public class MainCharacterBase : MonoBehaviour
{
    #region ���}��� �����ݩ�
    /// <summary>
    /// �w�q�����l�ݩʤΦ���
    /// </summary>
    [Header("��l��q"), Tooltip("����i�J�C���ɾ֦��P��ۦP���ͩR�W��"), Range(50, 300)]
    public float HpOrigin = 50;
    [Header("��e��q")]
    public float HpCurrent;
    [Header("��q�W��"), Tooltip("��e��q���|�W�L�̤j��")]
    public float HpMax;
    [Header("��l�]�O"), Tooltip("����i�J�C����֦�����l�]�O�A�b�԰�������^���ƭ�"), Range(0, 100)]
    public float ManaOrigin = 5;
    [Header("��e�]�O")]
    public float ManaCurrent;
    [Header("��e��l�]�O"), Tooltip("�԰�������զ^���")]
    public float ManaMax;
    [Header("����"), Range(1, 11)]
    public int Level = 1;
    [Header("�g���")]
    public int Experience;
    [Header("��������")]
    public int gold;
    #endregion
    #region ���}��� ��L
    [Header("��q����"), Tooltip("����C���ɯū���o��������q�W��"), Range(0, 50)]
    public float HpAdd = 10;
    [Header("��P�W��"), Range(1, 8)]
    public int DrawLimit = 4;
    [Header("�ɯũһݸg���"), Tooltip("��e�g��ȶW�L�ɯũһݡA�h�|��֬����Ȥɯ�")]  //�c���Ưx�}�Ƥ�
    public int ExpNeeded;
    #endregion
    #region �����}���
    #endregion
    #region �ƥ�
    private void Start()
    {
        CharacterReset();
    }
    private void Update()
    {
        AfterBattle(Level);
    }
    #endregion
    #region ��k
    private void CharacterReset()  //����k���]�w����i���ɪ��w�]��
    {
        HpMax = HpOrigin;
        HpCurrent = HpMax;
        ManaCurrent = ManaMax;
    }
    private void AfterBattle(int exp)  //�C���԰�������i��վ�
    {
        gold += Random.Range(10, 25);
        Experience += exp;
        ManaCurrent = ManaOrigin;
        if (Experience >= ExpNeeded) LevelUP();
    }
    private void LevelUP()  //����ɯ�
    {
        Experience = Experience - ExpNeeded;
        Level++;
        HpCurrent = HpMax = HpOrigin + HpAdd * Level;
    }
    public void Hurt()
    {
        if (HpCurrent <= 0) Dead();
    }
    private void Dead() //���⦺�`
    {
        HpCurrent = 0;
        enabled = false;
    }
    #endregion
}
