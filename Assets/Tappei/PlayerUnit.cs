using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 各プレイヤーの制御を行う
/// </summary>
public class PlayerUnit : MonoBehaviour
{
    [SerializeField] PlayerCommand _playerCommand;
    /// <summary>手持ちのカードは10枚で固定なので配列で管理する</summary>
    [SerializeField] CardMove[] _cards;

    /// <summary>現在の勝利数</summary>
    int _winCount;

    void Start()
    {
        if (_playerCommand != null)
        {
            // 各カードがクリックされた時のイベントに"場に出す"処理を追加する
            foreach (CardMove card in _cards)
                card.OnClicked += _playerCommand.ToField;
        }
    }

    void Update()
    {
        // きちんとカードがソートするかどうかのテスト、下記TODOが出来次第消す
        if(Input.GetKeyDown(KeyCode.Space)) OnMove();
    }

    // TODO:手札もしくは場に子オブジェクトの数が変更された場合…のSubscribeを追加して
    //      手札がソートするようにする
    void OnMove()
    {
        _playerCommand.SortHand();
    }
}
