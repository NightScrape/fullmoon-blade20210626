using UnityEngine;

public class EnemyBase : MonoBehaviour
{
    #region ���
    [Header("��q"), Tooltip("�Ǫ��԰���֦�����q"), Range(50, 300)]
    public float Hp = 32;
    [Header("�]�O"), Tooltip("�Ǫ��J������o���]�O"), Range(0, 100)]
    public float Mana = 12;
    [Header("��P��"),Tooltip("�Ǫ��C�^�X�}�l�����P�A����P�ӼƦr�ۦP"),Range(0,6)]
    public int CardDraw = 2;
    #endregion
    #region �ƥ�
    #endregion
    #region ��k
    #endregion
}
