using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// �J�[�h�̃X�e�[�^�X���Ǘ�����
/// </summary>
public class CardStatus : MonoBehaviour
{
    /// <summary>SO���擾���Ă���̂Ɏg�p����^�O</summary>
    [SerializeField] CardTag _cardTag;
    CardDataSO _so;

    void OnEnable()
    {
        // OnEnable()�ŌĂ�ł���̂͑��̃X�N���v�g��Start()�֐���
        // ���̃X�N���v�g���̃f�[�^���Q�Ƃł���悤�ɂ��邽��
        _so = CardDataManager.GetSO(_cardTag);
    }

    void Start()
    {
        // TODO: SO�̎擾���o�����̂Ŏg������������
    }

    void Update()
    {
        
    }
}
