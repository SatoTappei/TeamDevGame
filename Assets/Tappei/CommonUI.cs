using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// �Q�[���̐i�s�Ŏg��UI�𐧌䂷��
/// </summary>
public class CommonUI : MonoBehaviour
{
    [SerializeField] Text _centerText;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void Init()
    {
        _centerText.text = "";
    }

    // TOOD:�ΐ킳����ۂɂ͏��������ɂ͏����A���������ɂ͕���
    //      �ƕ\��������悤�ɂ���
    /// <summary>����������\������</summary>
    public IEnumerator SetBattleResult(int side)
    {
        if(side == 1)
        {
            _centerText.text = "����";
        }
        else if(side == 2)
        {
            _centerText.text = "����";
        }
        else if(side == 0)
        {
            _centerText.text = "��������";
        }

        // TODO:���o���s��
        yield return null;
    }
}
