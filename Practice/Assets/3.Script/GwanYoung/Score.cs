using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public float timescore = 0;

    [SerializeField] GameObject player;
    GameOver gameover;

    private Text scoretext;

    private void Start()
    {
        gameover = player.GetComponent<GameOver>();
        scoretext = GetComponent<Text>();    
    }

    void Update()
    {
        timescore += Time.deltaTime * 25f;
        Calculation();
        
    }
    private void Calculation()
    {
        
        if (gameover.isAlive) // 스코어 출력 UI
        {
            scoretext.text = $"Score : {(int)timescore}";
        }

    }
}
