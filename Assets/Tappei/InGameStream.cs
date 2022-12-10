using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

/// <summary>
/// �Q�[���v���C�̐i�s�𐧌䂷��
/// </summary>
public class InGameStream : MonoBehaviour
{
    /// <summary>�Q�[���̏��s�����܂鏟����</summary>
    readonly int _gameSetPoint = 4;
    /// <summary>�������������𔻒肷��</summary>
    bool _isGameSet;

    [SerializeField] StartEffect _startEffect;
    [SerializeField] ResultEffect _resultEffect;
    [SerializeField] PlayerUnit _player1;
    [SerializeField] PlayerUnit _player2;
    [SerializeField] CommonUI _commonUI;

    IEnumerator Start()
    {
        _commonUI.Init();
        yield return _startEffect.EffectCoroutine();
        _player1.Init();
        _player2.Init();

        _isGameSet = false; // �e�X�g�p
        while (!_isGameSet)
        {
            _player1.TurnStart();
            _player2.TurnStart();
            // ���҂��J�[�h��I�Ԃ܂ő҂�
            yield return new WaitUntil(() => _player1.IsSelected);
            yield return new WaitUntil(() => _player2.IsSelected);
            // ���s�̔�����s��
            BattleSystem bs = new BattleSystem();
            int resultP1 = bs.Battle(_player1.GetSelectedCard(), _player2.GetSelectedCard());
            int resultP2 = bs.Battle(_player2.GetSelectedCard(), _player1.GetSelectedCard());
            // ���ꂼ��̃v���C���[��UI���X�V
            _player1.SetBattleResult(resultP1);
            _player2.SetBattleResult(resultP2);
            // ���s�̕\��������
            // TODO:����̓v���C���[1���������珟���A�������畉���ƕ\�����邪
            //      ��X�ΐ����������̂ŏ��������ɂ͏����A���������ɂ͕����ƕ\����������悤�ɂ���
            yield return _commonUI.SetBattleResult(resultP1);

            // �ǂ�����J�[�h���o�����画��
            // �J�[�h�����炷
            // �Q�[���Z�b�g������
            // �Q�[���Z�b�g�Ȃ烋�[�v�𔲂���

            // ������:���̏����������Ɩ������[�v�ɂȂ��Ď~�܂�̂Ńe�X�g���͏����Ȃ�����
            _isGameSet = true;
        }

        // ���ʕ\���̉��o
        // ������x��邩�I��
        yield return _resultEffect.EffectCoroutine();
    }

    void Update()
    {
        
    }
}
