using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

/// <summary>
/// プレイヤーの入力に応じてカードを場に出す
/// </summary>
public class PlayerCommand : MonoBehaviour
{
    [SerializeField] Transform _hand;
    [SerializeField] Transform _field;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    /// <summary>カードを場に出す</summary>
    public void ToField(Transform card)
    {
        // 渡されたカードを場に移動させるアニメーションを行う
        card.DOMove(_field.position, 0.15f);
        // 渡されたカードを場のカードと交換する
        Transform prev = ChangeCard(card);
        // 戻ってきたカードは手札に加える
        if (prev != null) prev.SetParent(_hand);
    }

    /// <summary>場のカードを交換する</summary>
    Transform ChangeCard(Transform card)
    {
        if (_field.transform.childCount == 0)
        {
            // 場にカードがない場合は、そのカードを場にセットしてnullを返す
            card.SetParent(_field);
            return null;
        }
        else
        {
            // 場にカードがある場合は、交換して前のカードを返す
            Transform prev = _field.transform.GetChild(0);
            card.SetParent(_field);
            return prev;
        }
    }
}
