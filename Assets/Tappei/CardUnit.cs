using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using DG.Tweening;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;

/// <summary>
/// 各カードの制御を行う
/// </summary>
public class CardUnit : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler
{
    /// <summary>カードの画像</summary>
    [SerializeField] Image _sprite;
    /// <summary>SOを取得するのに使用するタグ</summary>
    [Header("SOを取得してくるためのタグ")]
    [SerializeField] CardTag _cardTag;

    Transform _field;
    CardDataSO _so;

    /// <summary>クリックされたときに行う処理を外部から追加できるようにしておく</summary>
    public UnityAction<Transform> OnClicked;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    /// <summary>初期化処理</summary>
    public void Init(Transform field)
    {
        _field = field;
        _so = CardDataManager.GetSO(_cardTag);
        // TOOD: _soのデータを実際のカードに反映する処理
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        _sprite.transform.DOScale(new Vector3(1.5f, 1.5f, 1), 0.15f);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        _sprite.transform.DOScale(Vector3.one, 0.15f);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        // 場にいる時にクリックできないようにする
        if (transform.parent != _field)
        {
            // クリックされた時の処理(場に出す)を実行する
            OnClicked?.Invoke(transform);
        }
    }
}
