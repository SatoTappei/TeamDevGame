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
        // TODO:勝敗の判定の処理、現在は仮で1を返す
        return 1;
    }
}
