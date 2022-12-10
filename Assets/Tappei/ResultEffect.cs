using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

/// <summary>
/// ゲーム終了時の演出を行う
/// </summary>
public class ResultEffect : MonoBehaviour
{
    [SerializeField] GameObject _root;

    void Awake()
    {
        _root.SetActive(false);
    }

    public IEnumerator EffectCoroutine()
    {
        _root.SetActive(true);
        yield return null;

        //yield return DOVirtual.DelayedCall(1f, () => _root.SetActive(false))
        //                      .OnStart(() => _root.SetActive(true))
        //                      .WaitForCompletion();
    }
}
