using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class GCPause : MonoBehaviour
{

    public GameObject menu;

    void Update()
    {
     
    }

    public void ButtonPause()
    {
        menu.SetActive(true);
        Time.timeScale = 0f;
    }

    public void BotaoVoltar()
    {
        Time.timeScale = 1f;
        menu.SetActive(false);
    }

    public void BotaoMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }

    public void BotaoSair()
    {
        //Time.timeScale = 1f;
        Application.Quit();
    }
}