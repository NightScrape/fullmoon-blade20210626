using UnityEngine;

public class MainCharacterBase : MonoBehaviour
{
    #region ���
    /// <summary>
    /// �w�q�����l�ݩʤΦ���
    /// </summary>
    [Header("��l��q"),Tooltip("����i�J�C���ɾ֦��P��ۦP���ͩR�W��"), Range(50, 300)]
    public float HpOrigin = 50;
    [Header("��l�]�O"),Tooltip("����i�J�C����֦�����l�]�O�A�b�԰�������^���ƭ�"),Range(0, 100)]
    public float ManaOrigin = 8;
    [Header("��P�W��"), Range(1, 8)]
    public int DrawLimit = 3;
    [Header("����"), Range(1, 11)]
    public int Level = 1;
    [Header("��q����"), Tooltip("����C���ɯū���o��������q�W��"), Range(0, 50)]
    public float HpAdd = 10;
    [Header("�]�O�W�j"), Tooltip("�]���ƥ�ӼW�[���]�O�|�[��즳����l�]�O�ȡA�W�j�������]�԰������Ӯ���"), Range(0, 30)]
    public float ManaAdd = 8;
    [Header("��e��q")]
    public float HpCurrent;
    [Header("��e�]�O")]
    public float ManaCurrent;
    [Header("����ޯ�N�o"), Tooltip("����ޯ�N�o��0�ɥi�H�o�ʹ������ޯ�"), Range(0, 10)]
    public int SkillCooldown = 5; //�Y����������ޯର�Q�ʡA�h�אּ0
    #endregion
    #region �ƥ�
    private void Start()
    {
        HpCurrent = HpOrigin;
        ManaCurrent = ManaOrigin;
        SkillCooldown = 0;
    }
    #endregion
    #region ��k
    #endregion
}
