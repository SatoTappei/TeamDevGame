using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cysharp.Threading.Tasks;

/// <summary>
/// �Q�[���v���C�̐i�s�𐧌䂷��
/// </summary>
public class InGameStream : MonoBehaviour
{
    /// <summary>�Q�[���̏��s�����܂鏟����</summary>
    readonly int _gameSetPoint = 4;
    /// <summary>�������������𔻒肷��</summary>
    bool _isGameSet;

    [SerializeField] PlayerUnit _player1;
    [SerializeField] PlayerUnit _player2;

    IEnumerator Start()
    {
        yield return StartStag();
        _player1.Init();
        _player2.Init();

        _isGameSet = false; // �e�X�g�p
        while (!_isGameSet)
        {
            _player1.TurnStart();
            _player2.TurnStart();
            // ���҂��J�[�h��I��
            // �J�[�h���}�E�X�I�[�o�[������g�債�ĕ\�������
            // �N���b�N�������ɏo��
            // ���X��ɂ������J�[�h�̓X���C�h���Ė߂�
            // ������ƕ��ёւ���

            // �ǂ�����J�[�h���o�����画��
            // �J�[�h�����炷
            // �Q�[���Z�b�g������
            // �Q�[���Z�b�g�Ȃ烋�[�v�𔲂���

            // ������:���̏����������Ɩ������[�v�ɂȂ��Ď~�܂�̂Ńe�X�g���͏����Ȃ�����
            _isGameSet = true;
        }

        // ���ʕ\���̉��o
        // ������x��邩�I��
    }

    void Update()
    {
        
    }

    /// <summary>�Q�[���X�^�[�g�̉��o</summary>
    IEnumerator StartStag()
    {
        // �����ɉ��o�̏���������
        yield return null;
    }
}
