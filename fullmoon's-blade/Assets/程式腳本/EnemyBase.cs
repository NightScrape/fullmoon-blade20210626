using UnityEngine;

public class EnemyBase : MonoBehaviour
{
    #region ���
    [Header("��q"), Tooltip("�Ǫ��԰���֦�����q"), Range(0, 500)]
    public float Hp = 32;
    [Header("��q�W��"), Tooltip("��e��q���|�W�L�̤j��")]
    public float HpMax;
    [Header("��P��"),Tooltip("�Ǫ��C�^�X�}�l�����P�A����P�ӼƦr�ۦP"),Range(0,6)]
    public int CardDraw = 2;
    [Header("�Ǫ�����"),Range(1,10)]
    public int EnemyLevel = 1;
    enum Action
    {
        instantAttack,delayedAttack,armor,recover,wait
    }
    #endregion
    #region �ƥ�
    #endregion
    #region ��k
    #endregion
}
