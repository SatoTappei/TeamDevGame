using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UniRx;

/// <summary>
/// 各プレイヤーの制御を行う
/// </summary>
public class PlayerUnit : MonoBehaviour
{
    [SerializeField] PlayerCommand _playerCommand;
    [SerializeField] Transform _field;
    [SerializeField] Button _submitButton;
    /// <summary>手持ちのカードは10枚で固定なので配列で管理する</summary>
    [SerializeField] CardUnit[] _cards;
    
    /// <summary>現在の勝利数</summary>
    int _winCount;

    void Start()
    {

    }

    void Update()
    {
        // TODO:決定ボタンを押した際の処理を作る
        //      場に何も出していない状態なら何も起きない
        //      場にカードを出している状態ならカードを選択完了フラグを立てる
        //      選択完了フラグが立っている場合はカードを選ぶことが出来ない
        //      両方のプレイヤーの選択フラグが立った場合は勝敗の判定フェーズに移る。
        // 決定ボタン:場に何もカードがないときは押せない
    }

    public void Init()
    {
        // 決定ボタンに処理を割り当てる
        _submitButton.onClick.AsObservable().Subscribe(b => Debug.Log(b));

        foreach (CardUnit card in _cards)
        {
            // 各カードの初期化処理を行う
            card.Init(_field);
            // クリックされたときの処理(場に出す)を登録する
            card.OnClicked += _playerCommand.ToField;
            // ソートできるようにプレイヤーの手札をソート用の辞書に登録する
            _playerCommand.AddSortDic(card.gameObject);
        }

        // 場に出されたことを検知するために子オブジェクトの数が変わった瞬間を検知する
        _field.ObserveEveryValueChanged(t => t.childCount)
              .Skip(1)
              .Subscribe(_ => _submitButton.interactable = true);
    }

    /// <summary>ターンの初めに1回だけ呼ばれる処理</summary>
    public void TurnStart()
    {
        // カードを出すまでボタンを押せないようにする
        _submitButton.interactable = false;
    }

    /// <summary>ターン終了時に1回だけ呼ばれる処理</summary>
    public void TurnEnd()
    {
        // 処理を書く
    }
}
