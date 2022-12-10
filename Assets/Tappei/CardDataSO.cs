using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ���ꂼ��̃J�[�h�̃f�[�^
/// �v���C���[2�l�������f�[�^���Q�Ƃ���
/// </summary>
[CreateAssetMenu]
public class CardDataSO : ScriptableObject
{
    [SerializeField] CardTag _tag;
    [SerializeField] string _name;
    [SerializeField] int _num;
    [TextArea]
    [SerializeField] string _ability;

    public string Name { get => _name; }
    public int Num { get => _num; }
    public string Ability { get => _ability; }
    public CardTag Tag { get => _tag; }
}

/// <summary>
/// CardDataSO���擾����Ƃ��Ɏg�p����^�O
/// �J�[�h�ɂ��ꂼ�ꊄ�蓖�ĂăQ�[���J�n����SO���擾���Ă���
/// </summary>
public enum CardTag
{
    Card1,
    Card2,
    Card3,
    Card4,
    Card5,
    Card6,
    Card7,
    Card8,
    Card9,
    CardSlash,
}