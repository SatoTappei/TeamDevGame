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
    [SerializeField] Text _counter;
    /// <summary>�莝���̃J�[�h��10���ŌŒ�Ȃ̂Ŕz��ŊǗ�����</summary>
    [SerializeField] CardUnit[] _cards;

    /// <summary>���̃^�[���I�������J�[�h</summary>
    CardUnit _selectedCard;
    /// <summary>���݂̏�����</summary>
    public int WinCount { get; private set; }
    /// <summary>
    /// ���̃^�[���ɏo���J�[�h�����肵����
    /// �J�[�h���o������ԂŌ���{�^����������true�ɂȂ�
    /// </summary>
    public bool IsSelected { get; private set; }

    void Start()
    {

    }

    void Update()
    {

    }

    public void Init()
    {
        // ����{�^���ɃJ�[�h�I�������̏��������蓖�Ă�
        _submitButton.onClick.AddListener(() => ClickedSubmitButton());

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
              .Subscribe(_ => _submitButton.interactable = true)
              .AddTo(this);
    }

    /// <summary>�^�[���̏��߂�1�񂾂��Ă΂�鏈��</summary>
    public void TurnStart()
    {
        IsSelected = false;
        // �J�[�h���o���܂Ń{�^���������Ȃ��悤�ɂ���
        _submitButton.interactable = false;
        // �S�ẴJ�[�h���A�N�e�B�u�ɂ���
        foreach (CardUnit card in _cards)
            card.Inactive(true);
    }

    /// <summary>�^�[���I������1�񂾂��Ă΂�鏈��</summary>
    public void TurnEnd()
    {
        // ����������
        // ��̃J�[�h���S�~���Ɉړ�������
        _playerCommand.CleanField();
    }

    /// <summary>���̃^�[���I�������J�[�h���擾����</summary>
    public CardUnit GetSelectedCard() => _selectedCard;

    /// <summary>
    /// ����{�^�����N���b�N�����Ƃ��̏���
    /// TODO:��X�ɕʂ̐�p�ꏊ�Ɉڂ����Ƃ��l������
    /// </summary>
    void ClickedSubmitButton()
    {
        // ��x�����ꂽ�炱�̃^�[���͉����Ȃ��悤�ɂ���
        _submitButton.interactable = false;
        // �o���J�[�h�����肵���t���O�𗧂Ă�
        IsSelected = true;
        // ��̎q�I�u�W�F�N�g����擾���A�����I�������J�[�h�Ƃ���
        _selectedCard = _field.GetComponentInChildren<CardUnit>();

        // ��ɏo�����J�[�h�ȊO���A�N�e�B�u��Ԃɂ���
        foreach (CardUnit card in _cards)
        {
            // TODO:����͏�̈�Ԗڂ̃I�u�W�F�N�g���擾���đI�������J�[�h�����Ă��邪
            //      �I�������J�[�h�Ƃ����ϐ�����邱�Ƃ��l������
            if (_selectedCard == card) continue;

            card.Inactive(false);
        }
    }

    /// <summary>���̃^�[���̃o�g���̌��ʂ𔽉f������</summary>
    public void SetBattleResult(int result)
    {
        // ����͏����ȊO��UI���X�V���邱�Ƃ��Ȃ�
        if (result != 1) return;
        Debug.Log("��΂��");
        WinCount++;
        _counter.text =WinCount.ToString();
    }
}
