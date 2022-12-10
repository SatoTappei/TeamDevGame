using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// �J�[�h�̃f�[�^���Ǘ�����A�e�J�[�h�͂��̃N���X����SO���擾����
/// </summary>
public class CardDataManager : MonoBehaviour
{
    [SerializeField] CardDataSO[] _sos;
    /// <summary>�^�O���L�[��SO���擾���邽�߂̎����^</summary>
    static Dictionary<CardTag, CardDataSO> _dic;

    void Awake()
    {
        if (_dic == null)
        {
            _dic = new Dictionary<CardTag, CardDataSO>();

            foreach (CardDataSO so in _sos)
                _dic.Add(so.Tag, so);
        }
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    /// <summary>�^�O����SO���擾����</summary>
    public static CardDataSO GetSO(CardTag tag) => _dic[tag];
}
