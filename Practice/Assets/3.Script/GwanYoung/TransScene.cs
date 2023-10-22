using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransScene : MonoBehaviour
{
    [SerializeField] private GameObject TouchingObj;

    public void ToGame() // 메인게임으로
    {
        // 메인게임 string값 넣기
        // SceneManager.LoadScene("");
    }
    public void ToRule() // 게임방법 으로
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
