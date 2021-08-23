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
    public float ManaOrigin = 8;
    [Header("��e�]�O")]
    public float ManaCurrent;
    [Header("��e��l�]�O"), Tooltip("�԰�������զ^���")]
    public float ManaMax;
    [Header("��P�W��"), Range(1, 20)]
    public int DrawLimit = 3;
    [Header("����"), Range(1, 11)]
    public int Level = 1;
    [Header("�g���")]
    public int Experience;
    [Header("��������")]
    public int gold;
    [Header("����ޯ�N�o"), Tooltip("�b�g�L�h�־԰��ƫᬰ0�A����ޯ�N�o��0�ɥi�H�o�ʹ������ޯ�"), Range(0, 10)]
    public int SkillCooldown = 5; //�Y����������ޯର�Q�ʡA�h�אּ0
    #endregion
    #region ���}��� ��L
    [Header("��q����"), Tooltip("����C���ɯū���o��������q�W��"), Range(0, 50)]
    public float HpAdd = 10;
    [Header("�ɯ��]�O�W�j"), Tooltip("�]���ɯŦӼW�[���]�O�|�[��즳����l�]�O�ȡA�W�j�������]�԰������Ӯ���"), Range(0, 30)]
    public float ManaAdd = 8;
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
        ManaCurrent = ManaMax = ManaOrigin + ManaAdd * Level;
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
