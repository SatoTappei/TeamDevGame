using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtleJudgeScript : MonoBehaviour
{

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    /// <summary>
    /// ���s�̔�������郁�\�b�h
    /// </summary>
    /// <param name="card1"></param>
    /// <param name="card2"></param>
    /// <returns>�������� = 0 �v���C���[1Win = 1 2Win = 2</returns>
    public int ButtleJudge(int card1,int card2)
    {
        //�Е���0�̎��͋�����������
        if(card1 == 0 || card2 == 0)
        {
            //�ǂ��炩��6�������ꍇ������������
            if(card1 == 6)
            {
                return 1;
            }
            else if(card2 == 6)
            {
                return 2;
            }
            else
            {
                return 0;
            }
        }
        //�v���C���[1��8�Ńv���C���[2��1�̎��̓v���C���[2������
        if(card1 == 8)
        {
            if(card2 == 1)
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
        else if(card1 < card2)
        {
            return 2;
        }
        else
        {
            return 0;
        }

    }
}
