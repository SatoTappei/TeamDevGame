using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UniRx;

/// <summary>
/// �e�v���C���[�̐�����s��
/// </summary>
public class PlayerUnit : MonoBehaviour
{
    [SerializeField] PlayerCommand _playerCommand;
    [SerializeField] Transform _field;
    [SerializeField] Button _submitButton;
    /// <summary>�莝���̃J�[�h��10���ŌŒ�Ȃ̂Ŕz��ŊǗ�����</summary>
    [SerializeField] CardUnit[] _cards;
    
    /// <summary>���݂̏�����</summary>
    int _winCount;

    void Start()
    {

    }

    void Update()
    {
        // TODO:����{�^�����������ۂ̏��������
        //      ��ɉ����o���Ă��Ȃ���ԂȂ牽���N���Ȃ�
        //      ��ɃJ�[�h���o���Ă����ԂȂ�J�[�h��I�������t���O�𗧂Ă�
        //      �I�������t���O�������Ă���ꍇ�̓J�[�h��I�Ԃ��Ƃ��o���Ȃ�
        //      �����̃v���C���[�̑I���t���O���������ꍇ�͏��s�̔���t�F�[�Y�Ɉڂ�B
        // ����{�^��:��ɉ����J�[�h���Ȃ��Ƃ��͉����Ȃ�
    }

    public void Init()
    {
        // ����{�^���ɏ��������蓖�Ă�
        _submitButton.onClick.AsObservable().Subscribe(b => Debug.Log(b));

        foreach (CardUnit card in _cards)
        {
            // �e�J�[�h�̏������������s��
            card.Init(_field);
            // �N���b�N���ꂽ�Ƃ��̏���(��ɏo��)��o�^����
            card.OnClicked += _playerCommand.ToField;
            // �\�[�g�ł���悤�Ƀv���C���[�̎�D���\�[�g�p�̎����ɓo�^����
            _playerCommand.AddSortDic(card.gameObject);
        }

        // ��ɏo���ꂽ���Ƃ����m���邽�߂Ɏq�I�u�W�F�N�g�̐����ς�����u�Ԃ����m����
        _field.ObserveEveryValueChanged(t => t.childCount)
              .Skip(1)
              .Subscribe(_ => _submitButton.interactable = true);
    }

    /// <summary>�^�[���̏��߂�1�񂾂��Ă΂�鏈��</summary>
    public void TurnStart()
    {
        // �J�[�h���o���܂Ń{�^���������Ȃ��悤�ɂ���
        _submitButton.interactable = false;
    }

    /// <summary>�^�[���I������1�񂾂��Ă΂�鏈��</summary>
    public void TurnEnd()
    {
        // ����������
    }
}
