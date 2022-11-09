using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cysharp.Threading.Tasks;

/// <summary>
/// �Q�[���v���C�̐i�s�𐧌䂷��
/// </summary>
public class PlaySceneManager : MonoBehaviour
{
    /// <summary>�Q�[���̏��s�����܂鏟����</summary>
    readonly int _gameSetPoint = 4;
    /// <summary>�������������𔻒肷��</summary>
    bool _isGameSet;

    [SerializeField] PlayerUnit _player1;
    [SerializeField] PlayerUnit _player2;

    async void Start()
    {
        await StartStag();

        _isGameSet = true; // �e�X�g�p�A�����Ă悵
        while (!_isGameSet)
        {
            // ���҂��J�[�h��I��
            // �J�[�h���}�E�X�I�[�o�[������g�債�ĕ\�������
            // �N���b�N�������ɏo��
            // ���X��ɂ������J�[�h�̓X���C�h���Ė߂�
            // ������ƕ��ёւ���

            // �ǂ�����J�[�h���o�����画��
            // �J�[�h�����炷
            // �Q�[���Z�b�g������
            // �Q�[���Z�b�g�Ȃ烋�[�v�𔲂���
        }

        // ���ʕ\���̉��o
        // ������x��邩�I��
    }

    void Update()
    {
        
    }

    /// <summary>�Q�[���X�^�[�g�̉��o</summary>
    async UniTask StartStag()
    {
        // �����ɉ��o�̏���������
        await UniTask.Delay(1000);
    }
}
