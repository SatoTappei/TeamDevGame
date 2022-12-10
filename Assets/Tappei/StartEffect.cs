using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

/// <summary>
/// ゲームスタート時の演出を行う
/// </summary>
public class StartEffect : MonoBehaviour
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
