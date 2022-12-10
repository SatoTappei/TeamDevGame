using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

/// <summary>
/// ���̃^�[���֐��ڎ��̉��o���s��
/// </summary>
public class NextTurnEffect : MonoBehaviour
{
    [SerializeField] GameObject _text;

    void Awake()
    {
        _text.SetActive(false);
    }

    public IEnumerator EffectCoroutine()
    {
        yield return DOVirtual.DelayedCall(1f, () => _text.SetActive(false))
                              .OnStart(() => _text.SetActive(true))
                              .WaitForCompletion();
    }
}
