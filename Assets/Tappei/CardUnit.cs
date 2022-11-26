using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using DG.Tweening;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;

/// <summary>
/// �e�J�[�h�̐�����s��
/// </summary>
public class CardUnit : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler
{
    /// <summary>�J�[�h�̉摜</summary>
    [SerializeField] Image _sprite;
    /// <summary>SO���擾����̂Ɏg�p����^�O</summary>
    [Header("SO���擾���Ă��邽�߂̃^�O")]
    [SerializeField] CardTag _cardTag;

    Transform _field;
    CardDataSO _so;

    /// <summary>�I���\���̃t���O</summary>
    bool _isSelectable;

    /// <summary>�N���b�N���ꂽ�Ƃ��ɍs���������O������ǉ��ł���悤�ɂ��Ă���</summary>
    public UnityAction<Transform> OnClicked;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    /// <summary>����������</summary>
    public void Init(Transform field)
    {
        _field = field;
        _so = CardDataManager.GetSO(_cardTag);
        _isSelectable = true;
        // TOOD: _so�̃f�[�^�����ۂ̃J�[�h�ɔ��f���鏈��
    }

    /// <summary>�I���\����؂�ւ���</summary>
    public void Inactive(bool value)
    {
        _sprite.color = value ? Color.white : Color.black;
        _isSelectable = value ? true : false;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (_isSelectable)
        {
            _sprite.transform.DOScale(new Vector3(1.5f, 1.5f, 1), 0.15f);
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (_isSelectable)
        {
            _sprite.transform.DOScale(Vector3.one, 0.15f);
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        // ��ɂ��鎞�ɃN���b�N�ł��Ȃ��悤�ɂ���
        if (_isSelectable && transform.parent != _field)
        {
            // �N���b�N���ꂽ���̏���(��ɏo��)�����s����
            OnClicked?.Invoke(transform);
        }
    }
}
