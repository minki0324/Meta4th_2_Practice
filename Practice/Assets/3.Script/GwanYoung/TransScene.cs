using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransScene : MonoBehaviour
{
    [SerializeField] private GameObject TouchingObj;

    public void ToGame() // ���ΰ�������
    {
        // ���ΰ��� string�� �ֱ�
        // SceneManager.LoadScene("");
    }
    public void ToRule() // ���ӹ�� ����
    {
        SceneManager.LoadScene("Rule");
    }
    public void GameQuit()
    {
        Application.Quit();
    }
    public void NoGameExit()
    {
        TouchingObj.gameObject.SetActive(false);
    }
    public void ExitMenu()
    {
        TouchingObj.gameObject.SetActive(true);
    }


}
