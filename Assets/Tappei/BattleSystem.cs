using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ���s�̔�����s��
/// </summary>
public class BattleSystem
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    /// <summary>���s�̔�����s��</summary>
    /// <returns>����:1 �s�k:-1 ��������:0</returns>
    public int Battle(CardUnit myself, CardUnit enemy)
    {
        int my = myself.So.Num;
        int ene = enemy.So.Num;

        // �ǂ��炩��0�̎��͈�������
        if (my == 0 || ene == 0)
        {
            // �ǂ��炩��0�̏ꍇ�͂�����̏���
            if (my == 6)
            {
                return 1;
            }
            else if (ene == 6)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
        // 8��1�̏ꍇ��1�̏���
        if (my == 8)
        {
            if (ene == 1)
            {
                //�����ɏ���
            }
        }
        else if (ene == 8)
        {
            if (my == 1)
            {
                //�����ɏ���
            }
        }

        //���̏�ɓ���Ȕ����S����������
        if (my > ene)
        {
            return 1;
        }
        else if (my < ene)
        {
            return -1;
        }
        else
        {
            return 0;
        }
    }
}
