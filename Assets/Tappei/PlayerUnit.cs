using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// �e�v���C���[�̐�����s��
/// </summary>
public class PlayerUnit : MonoBehaviour
{
    [SerializeField] PlayerCommand _playerCommand;
    /// <summary>�莝���̃J�[�h��10���ŌŒ�Ȃ̂Ŕz��ŊǗ�����</summary>
    [SerializeField] CardMove[] _cards;

    /// <summary>���݂̏�����</summary>
    int _winCount;

    void Start()
    {
        if (_playerCommand != null)
        {
            // �e�J�[�h���N���b�N���ꂽ���̃C�x���g��"��ɏo��"������ǉ�����
            foreach (CardMove card in _cards)
                card.OnClicked += _playerCommand.ToField;
        }
    }

    void Update()
    {
        // ������ƃJ�[�h���\�[�g���邩�ǂ����̃e�X�g�A���LTODO���o���������
        if(Input.GetKeyDown(KeyCode.Space)) OnMove();
    }

    // TODO:��D�������͏�Ɏq�I�u�W�F�N�g�̐����ύX���ꂽ�ꍇ�c��Subscribe��ǉ�����
    //      ��D���\�[�g����悤�ɂ���
    void OnMove()
    {
        _playerCommand.SortHand();
    }
}
