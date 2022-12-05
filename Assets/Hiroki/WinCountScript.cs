using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinCountScript : MonoBehaviour
{
    [SerializeField] Text _player1LifeTextObj;
    [SerializeField] Text _player2LifeTextObj;
    int _player1Life = 4;
    int _player2Life = 4;
    Text _player1LifeText;
    Text _player2LifeText;
    void Start()
    {
        _player1LifeText =_player1LifeTextObj.GetComponent<Text>();
        _player2LifeText = _player2LifeTextObj.GetComponent<Text>();
    }

    void Update()
    {

    }

    //player2‚ªŸ‚Á‚½‚©‚çplayer1‚Ì‘Ì—Í‚ğŒ¸‚ç‚·
    public void SetPlayer1Count(int player2WinCount)
    {
        _player1Life -= player2WinCount;
        _player1LifeText.text = _player1Life.ToString();
    }

    //player1‚ªŸ‚Á‚½‚©‚çplayer2‚Ì‘Ì—Í‚ğŒ¸‚ç‚·
    public void SetPlayer2Count(int player1WinCount)
    { 
        _player2Life -= player1WinCount;
        _player2LifeText.text = _player2Life.ToString();
    }

    
}
