using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 各プレイヤーの制御を行う
/// </summary>
public class PlayerUnit : MonoBehaviour
{
    [SerializeField] PlayerCommand _playerCommand;
    [SerializeField] Transform _field;
    /// <summary>手持ちのカードは10枚で固定なので配列で管理する</summary>
    [SerializeField] CardUnit[] _cards;

    /// <summary>現在の勝利数</summary>
    int _winCount;

    void Start()
    {

    }

    void Update()
    {

    }

    public void Init()
    {
        // このプレイヤーが使用する"場"への参照を子オブジェクトからを取得する
        Transform field = transform.Find("Field");

        foreach (CardUnit card in _cards)
        {
            // 各カードの初期化処理を行う
            card.Init(field);
            // クリックされたときの処理(場に出す)を登録する
            card.OnClicked += _playerCommand.ToField;
            // ソートできるようにプレイヤーの手札をソート用の辞書に登録する
            _playerCommand.AddSortDic(card.gameObject);
        }
    }
}
