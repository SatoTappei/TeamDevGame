using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// �Q�[���X�^�[�g���̉��o���s��
/// </summary>
public class StartEffect : MonoBehaviour
{
    public IEnumerator EffectCoroutine()
    {
        Debug.Log("�Q�[���X�^�[�g���o");
        yield return null;
    }
}
