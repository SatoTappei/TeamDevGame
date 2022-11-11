using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using DG.Tweening;
using System;
using UnityEngine.Events;

/// <summary>
/// �J�[�h�̓����𐧌䂷��
/// </summary>
public class CardMove : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler
{
    [SerializeField] Image _img;
    [SerializeField] Transform _field;

    /// <summary>�N���b�N���ꂽ�Ƃ��ɍs���������O������ǉ��ł���悤�ɂ��Ă���</summary>
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
        // ��ɂ��鎞�ɃN���b�N�ł��Ȃ��悤�ɂ���
        if (transform.parent != _field)
        {
            // ���g����̎q�ɐݒ肵�A�ړ�������
            OnClicked(transform);
        }
    }
}
