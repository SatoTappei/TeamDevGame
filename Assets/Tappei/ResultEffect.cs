using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// �Q�[���I�����̉��o���s��
/// </summary>
public class ResultEffect : MonoBehaviour
{
    public IEnumerator EffectCoroutine()
    {
        Debug.Log("�Q�[���I�����o");
        yield return null;
    }
}
