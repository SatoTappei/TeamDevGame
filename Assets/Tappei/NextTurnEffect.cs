using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// �Q�[���I�����̉��o���s��
/// </summary>
public class NextTurnEffect : MonoBehaviour
{
    public IEnumerator EffectCoroutine()
    {
        Debug.Log("���̃^�[���ւ̉��o");
        yield return null;
    }
}
