using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using DG.Tweening;
using System;
using UnityEngine.Events;

/// <summary>
/// カードの動きを制御する
/// </summary>
public class CardMove : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler
{
    [SerializeField] Image _img;
    [SerializeField] Transform _field;

    /// <summary>クリックされたときに行う処理を外部から追加できるようにしておく</summary>
    public UnityAction<Transform> OnClicked;

    void Start()
    {

    }

    void Update()
    {
        
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        _img.transform.DOScale(new Vector3(1.5f, 1.5f, 1), 0.15f);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        _img.transform.DOScale(Vector3.one, 0.15f);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        // 場にいる時にクリックできないようにする
        if (transform.parent != _field)
        {
            // 自身を場の子に設定し、移動させる
            OnClicked(transform);
        }
    }
}
