using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// カードのステータスを管理する
/// </summary>
public class CardStatus : MonoBehaviour
{
    /// <summary>SOを取得してくるのに使用するタグ</summary>
    [SerializeField] CardTag _cardTag;
    CardDataSO _so;

    void OnEnable()
    {
        // OnEnable()で呼んでいるのは他のスクリプトのStart()関数で
        // このスクリプト内のデータを参照できるようにするため
        _so = CardDataManager.GetSO(_cardTag);
    }

    void Start()
    {
        // TODO: SOの取得が出来たので使う処理を書く
    }

    void Update()
    {
        
    }
}
