using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using System.Linq;
using UniRx;

/// <summary>
/// �v���C���[�̓��͂ɉ����ăJ�[�h����ɏo��
/// </summary>
public class PlayerCommand : MonoBehaviour
{
    [SerializeField] Transform _hand;
    [SerializeField] Transform _field;
    //[SerializeField] Button _submitButton;

    // TODO:�����ȊO�ł��g���Ȃ�Ε֗��N���X������Ĉڂ�
    /// <summary>�Q�[���J�n���̎�D�̖���</summary>
    readonly int DefaultHand = 10;

    /// <summary>
    /// �\�[�g�p�̎����^�A�N�����Ƀq�G�����L�[�ɕ���ł������Ƀ\�[�g������
    /// </summary>
    Dictionary<string, int> _sortDic = new Dictionary<string, int>();

    void Start()
    {
        //_submitButton.onClick.AddListener(SubmitCard);
    }

    void Update()
    {
        
    }

    /// <summary>�\�[�g�ł���悤�ɃJ�[�h�������^�ɒǉ�����</summary>
    public void AddSortDic(GameObject card)
    {
        _sortDic.Add(card.name, card.transform.GetSiblingIndex());
    }

    /// <summary>�J�[�h����ɏo��</summary>
    public void ToField(Transform card)
    {
        // �n���ꂽ�J�[�h����Ɉړ�������A�j���[�V�������s��
        card.DOMove(_field.position, 0.15f);
        // �n���ꂽ�J�[�h����̃J�[�h�ƌ�������
        Transform prev = ChangeCard(card);
        // �߂��Ă����J�[�h�͎�D�ɉ�����
        if (prev != null) prev.SetParent(_hand);
        // �\�[�g����
        SortHand();
    }

    /// <summary>��̃J�[�h����������</summary>
    Transform ChangeCard(Transform card)
    {
        if (_field.transform.childCount == 0)
        {
            // ��ɃJ�[�h���Ȃ��ꍇ�́A���̃J�[�h����ɃZ�b�g����null��Ԃ�
            card.SetParent(_field);
            return null;
        }
        else
        {
            // ��ɃJ�[�h������ꍇ�́A�������đO�̃J�[�h��Ԃ�
            Transform prev = _field.transform.GetChild(0);
            card.SetParent(_field);
            return prev;
        }
    }

    /// <summary>��D���\�[�g(�q�G�����L�[�̏��Ԃ�M��)����</summary>
    public void SortHand()
    {
        Debug.Log("�V���b�t��");
        // SetSiblingIndex()�͌Ă񂾎��_�Ń\�[�g�����̂Ń��[�v���ɏ��Ԃ��ς���Ă��܂�
        // �Ȃ̂ň�x���X�g�Ɋi�[���Ă�����\�[�g���A���f�����Ă����B
        // SetSiblingIndex�̈������Œ�Ȃ̂͗v�f���ȏ���w�肷���"��ԉ�"�ɔz�u����邽��
        List<Transform> list = new List<Transform>();
        foreach (Transform trans in _hand)
            list.Add(trans);

        foreach (Transform trans in list.OrderBy(t => _sortDic[t.gameObject.name]).ToList())
            trans.SetSiblingIndex(DefaultHand + 1);
    }

    /// <summary>��ɏo���ꂽ�J�[�h�Ō��肷��</summary>
    public void SubmitCard()
    {
        // TODO:����{�^�����������ۂ̏���������
        //      _field�̎q�I�u�W�F�N�g���擾 <= ���ꂪ�I�������J�[�h
        // 
        // BattleSystem(��)�ɒʒm���Đ퓬����
        //if (_field.childCount == 0)
        //{
        //    Debug.Log("�J�[�h���I������Ă��܂���");
        //}
        //else
        //{
        //    Debug.Log(_field.GetChild(0));
        //}
    }
}
