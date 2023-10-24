using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    private bool isPause = false;
    [SerializeField] GameObject OptionUI;


    private void Update()
    {
        GamePause();
    }

    private void GamePause()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPause == false)
            {
                Time.timeScale = 0;
                OptionUI.SetActive(true);
                isPause = true;
            }
            else if (isPause == true)
            {
                Time.timeScale = 1;
                OptionUI.SetActive(false);
                isPause = false;
            }
        }
    }
    

}
