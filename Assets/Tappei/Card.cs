using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using DG.Tweening;

/// <summary>�J�[�h</summary>
public class Card : MonoBehaviour, IPointerEnterHandler , IPointerExitHandler
{
    [SerializeField] Image _img;

    void Start()
    {
        // �}�E�X�I�[�o�[�Ŋg��\�������悤�ɂ���
        // TODO:�N���b�N����ƃt�B�[���h�ɏo��悤�ɂ���
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
