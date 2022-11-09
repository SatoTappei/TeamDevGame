using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cysharp.Threading.Tasks;

/// <summary>
/// ゲームプレイの進行を制御する
/// </summary>
public class PlaySceneManager : MonoBehaviour
{
    /// <summary>ゲームの勝敗が決まる勝利数</summary>
    readonly int _gameSetPoint = 4;
    /// <summary>決着がついたかを判定する</summary>
    bool _isGameSet;

    [SerializeField] PlayerUnit _player1;
    [SerializeField] PlayerUnit _player2;

    async void Start()
    {
        await StartStag();

        _isGameSet = true; // テスト用、消してよし
        while (!_isGameSet)
        {
            // 両者がカードを選ぶ
            // カードをマウスオーバーしたら拡大して表示される
            // クリックしたら場に出る
            // 元々場にあったカードはスライドして戻る
            // きちんと並び替える

            // どちらもカードを出したら判定
            // カードを減らす
            // ゲームセットか判定
            // ゲームセットならループを抜ける
        }

        // 結果表示の演出
        // もう一度やるか選ぶ
    }

    void Update()
    {
        
    }

    /// <summary>ゲームスタートの演出</summary>
    async UniTask StartStag()
    {
        // ここに演出の処理を書く
        await UniTask.Delay(1000);
    }
}
