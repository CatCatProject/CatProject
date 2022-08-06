using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public void StartButton()
    {
        SceneManager.LoadScene(1);
    }
    public void OpenButton()
    {
        SceneManager.LoadScene(2);
    }
    public void BackToLobby()
    {
        SceneManager.LoadScene(1);
    }
    public void BackToMain()
    {
        SceneManager.LoadScene(0);
    }
}
