using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public bool isAlive = true;  // 살았는지 죽었는지

    [SerializeField] GameObject CheckScore;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject && isAlive) // 살아있는 상태에서 맞았을 때
        {
            Time.timeScale = 0;  // 죽었을 때 게임화면이 멈춤 (빼셔도 대용)
            isAlive = false; // 죽음 
        }
    }
    private void Update()
    {
 
        if(!isAlive)
        {
            CheckScore.SetActive(true);
        }
        else
        {
            CheckScore.SetActive(false);
        }
             
    }

}
