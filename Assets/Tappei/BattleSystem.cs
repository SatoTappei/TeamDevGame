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

    /// <summary>���s�̔���</summary>
    /// <returns>�v���C���[1����: 1 �v���C���[2����: 2</returns>
    public int Battle(CardUnit player1, CardUnit player2)
    {
        int card1 = player1.So.Num;
        int card2 = player2.So.Num;

        //�Е���0�̎��͋�����������
        if (card1 == 0 || card2 == 0)
        {
            //�ǂ��炩��6�������ꍇ������������
            if (card1 == 6)
            {
                return 1;
            }
            else if (card2 == 6)
            {
                return 2;
            }
            else
            {
                return 0;
            }
        }
        //�v���C���[1��8�Ńv���C���[2��1�̎��̓v���C���[2������
        if (card1 == 8)
        {
            if (card2 == 1)
            {
                //�����ɏ���
            }
        }
        //�v���C���[2��8�Ńv���C���[1��1�̎��̓v���C���[1������
        else if (card2 == 8)
        {
            if (card1 == 1)
            {
                //�����ɏ���
            }
        }

        ///���̏�ɓ���Ȕ����S����������
        if (card1 > card2)
        {
            return 1;
        }
        else if (card1 < card2)
        {
            return 2;
        }
        else
        {
            return 0;
        }

        //// TODO:���s�̔���̏����A���݂͉���1��Ԃ�
        //return 1;
    }
}
