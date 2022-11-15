using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinCountScript : MonoBehaviour
{
    [SerializeField] Text _player1LifeText;
    [SerializeField] Text _player2LifeText;
    int _player1Life = 4;
    int _player2Life = 4;
    // Start is called before the first frame update
    void Start()
    {
        _player1LifeText.GetComponent<Text>().text = _player1Life.ToString();
        _player2LifeText.GetComponent<Text>().text = _player2Life.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Player1WinCount(int _player1WinCount)//player1が勝ったからplayer2の体力を減らす
    {
        _player2Life -= _player1WinCount;
        _player2LifeText.GetComponent<Text>().text = _player2Life.ToString();
    }
    public void Player2WinCount(int _player2WinCount)//player2が勝ったからplayer1の体力を減らす
    {
        _player1Life -= _player2WinCount;
        _player1LifeText.GetComponent<Text>().text = _player1Life.ToString();
    }
}
