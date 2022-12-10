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
    [SerializeField] Transform _garbageCan;

    // TODO:�����ȊO�ł��g���Ȃ�Ε֗��N���X������Ĉڂ�
    /// <summary>�Q�[���J�n���̎�D�̖���</summary>
    readonly int DefaultHand = 10;

    /// <summary>
    /// �\�[�g�p�̎����^�A�N�����Ƀq�G�����L�[�ɕ���ł������Ƀ\�[�g������
    /// </summary>
    Dictionary<string, int> _sortDic = new Dictionary<string, int>();

    /// <summary>�\�[�g���Ɏg���ꎞ�ۑ��p�̃��X�g</summary>
    List<Transform> _tempList = new List<Transform>();

    void Start()
    {

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
            card?.SetParent(_field);
            return null;
        }
        else
        {
            // ��ɃJ�[�h������ꍇ�́A�������đO�̃J�[�h��Ԃ�
            Transform prev = _field.transform.GetChild(0);
            card?.SetParent(_field);
            return prev;
        }
    }

    /// <summary>��D���\�[�g(�q�G�����L�[�̏��Ԃ�M��)����</summary>
    public void SortHand()
    {
        // SetSiblingIndex()�͌Ă񂾎��_�Ń\�[�g�����̂Ń��[�v���ɏ��Ԃ��ς���Ă��܂�
        // �Ȃ̂ň�x���X�g�Ɋi�[���Ă�����\�[�g���A���f�����Ă����B
        // SetSiblingIndex�̈������Œ�Ȃ̂͗v�f���ȏ���w�肷���"��ԉ�"�ɔz�u����邽��
        _tempList.Clear();
        foreach (Transform trans in _hand)
            _tempList.Add(trans);

        foreach (Transform trans in _tempList.OrderBy(t => _sortDic[t.gameObject.name]).ToList())
            trans.SetSiblingIndex(DefaultHand + 1);
    }

    /// <summary>
    /// ��̃J�[�h���S�~���Ɉڂ����Ƃ�
    /// ����{�^�����ēx�\���ł���悤�ɂ���
    /// </summary>
    public void CleanField()
    {
        Transform prev = ChangeCard(null);
        prev.SetParent(_garbageCan);
    }
}
