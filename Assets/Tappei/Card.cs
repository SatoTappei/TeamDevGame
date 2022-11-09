using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using DG.Tweening;

/// <summary>カード</summary>
public class Card : MonoBehaviour, IPointerEnterHandler , IPointerExitHandler
{
    [SerializeField] Image _img;

    void Start()
    {
        // マウスオーバーで拡大表示されるようにした
        // TODO:クリックするとフィールドに出るようにする
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
}
