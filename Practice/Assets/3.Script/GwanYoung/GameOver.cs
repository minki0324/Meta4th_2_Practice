using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public bool isAlive = true;  // ��Ҵ��� �׾�����

    [SerializeField] GameObject CheckScore;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject && isAlive) // ����ִ� ���¿��� �¾��� ��
        {
            Time.timeScale = 0;  // �׾��� �� ����ȭ���� ���� (���ŵ� ���)
            isAlive = false; // ���� 
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
