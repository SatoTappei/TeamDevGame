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
    /// 勝敗の判定をするメソッド
    /// </summary>
    /// <param name="card1"></param>
    /// <param name="card2"></param>
    /// <returns>引き分け = 0 プレイヤー1Win = 1 2Win = 2</returns>
    public int ButtleJudge(int card1,int card2)
    {
        //片方が0の時は強制引き分け
        if(card1 == 0 || card2 == 0)
        {
            //どちらかが6だった場合そっちが勝つ
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
        //プレイヤー1が8でプレイヤー2が1の時はプレイヤー2が勝つ
        if(card1 == 8)
        {
            if(card2 == 1)
            {
                //試合に勝つ
            }
        }
        //プレイヤー2が8でプレイヤー1が1の時はプレイヤー1が勝つ
        else if (card2 == 8)
        {
            if (card1 == 1)
            {
                //試合に勝つ
            }
        }

        ///この上に特殊な判定を全部処理する
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
