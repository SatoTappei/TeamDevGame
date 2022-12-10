using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 勝敗の判定を行う
/// </summary>
public class BattleSystem
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    /// <summary>勝敗の判定</summary>
    /// <returns>プレイヤー1勝利: 1 プレイヤー2勝利: 2</returns>
    public int Battle(CardUnit player1, CardUnit player2)
    {
        int card1 = player1.So.Num;
        int card2 = player2.So.Num;

        //片方が0の時は強制引き分け
        if (card1 == 0 || card2 == 0)
        {
            //どちらかが6だった場合そっちが勝つ
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
        //プレイヤー1が8でプレイヤー2が1の時はプレイヤー2が勝つ
        if (card1 == 8)
        {
            if (card2 == 1)
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
        else if (card1 < card2)
        {
            return 2;
        }
        else
        {
            return 0;
        }

        //// TODO:勝敗の判定の処理、現在は仮で1を返す
        //return 1;
    }
}
