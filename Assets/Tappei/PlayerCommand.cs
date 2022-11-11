using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

/// <summary>
/// �v���C���[�̓��͂ɉ����ăJ�[�h����ɏo��
/// </summary>
public class PlayerCommand : MonoBehaviour
{
    [SerializeField] Transform _hand;
    [SerializeField] Transform _field;

    void Start()
    {
        
    }

    void Update()
    {
        
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
}
