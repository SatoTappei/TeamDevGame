using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// �e�v���C���[�̐�����s��
/// </summary>
public class PlayerUnit : MonoBehaviour
{
    [SerializeField] PlayerCommand _playerCommand;
    [SerializeField] Transform _field;
    /// <summary>�莝���̃J�[�h��10���ŌŒ�Ȃ̂Ŕz��ŊǗ�����</summary>
    [SerializeField] CardUnit[] _cards;

    /// <summary>���݂̏�����</summary>
    int _winCount;

    void Start()
    {

    }

    void Update()
    {

    }

    public void Init()
    {
        // ���̃v���C���[���g�p����"��"�ւ̎Q�Ƃ��q�I�u�W�F�N�g������擾����
        Transform field = transform.Find("Field");

        foreach (CardUnit card in _cards)
        {
            // �e�J�[�h�̏������������s��
            card.Init(field);
            // �N���b�N���ꂽ�Ƃ��̏���(��ɏo��)��o�^����
            card.OnClicked += _playerCommand.ToField;
            // �\�[�g�ł���悤�Ƀv���C���[�̎�D���\�[�g�p�̎����ɓo�^����
            _playerCommand.AddSortDic(card.gameObject);
        }
    }
}
