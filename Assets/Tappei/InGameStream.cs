using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

/// <summary>
/// ゲームプレイの進行を制御する
/// </summary>
public class InGameStream : MonoBehaviour
{
    /// <summary>ゲームの勝敗が決まる勝利数</summary>
    readonly int _gameSetPoint = 4;
    /// <summary>決着がついたかを判定する</summary>
    bool _isGameSet;

    [SerializeField] StartEffect _startEffect;
    [SerializeField] ResultEffect _resultEffect;
    [SerializeField] PlayerUnit _player1;
    [SerializeField] PlayerUnit _player2;
    [SerializeField] CommonUI _commonUI;

    IEnumerator Start()
    {
        _commonUI.Init();
        yield return _startEffect.EffectCoroutine();
        _player1.Init();
        _player2.Init();

        _isGameSet = false; // テスト用
        while (!_isGameSet)
        {
            _player1.TurnStart();
            _player2.TurnStart();
            // 両者がカードを選ぶまで待つ
            yield return new WaitUntil(() => _player1.IsSelected);
            yield return new WaitUntil(() => _player2.IsSelected);
            // 勝敗の判定を行う
            BattleSystem bs = new BattleSystem();
            int resultP1 = bs.Battle(_player1.GetSelectedCard(), _player2.GetSelectedCard());
            int resultP2 = bs.Battle(_player2.GetSelectedCard(), _player1.GetSelectedCard());
            // それぞれのプレイヤーのUIを更新
            _player1.SetBattleResult(resultP1);
            _player2.SetBattleResult(resultP2);
            // 勝敗の表示をする
            // TODO:現状はプレイヤー1が勝ったら勝ち、負けたら負けと表示するが
            //      後々対戦を実装するので勝った側には勝ち、負けた側には負けと表示させられるようにする
            yield return _commonUI.SetBattleResult(resultP1);

            // どちらもカードを出したら判定
            // カードを減らす
            // ゲームセットか判定
            // ゲームセットならループを抜ける

            // ★注意:この処理を消すと無限ループになって止まるのでテスト中は消さないこと
            _isGameSet = true;
        }

        // 結果表示の演出
        // もう一度やるか選ぶ
        yield return _resultEffect.EffectCoroutine();
    }

    void Update()
    {
        
    }
}
