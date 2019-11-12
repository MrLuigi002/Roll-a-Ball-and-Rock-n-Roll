using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{

    public GameObject loadBar;
    public AudioSource musicPlayer;

    public void NewGameBtn(string newGameLevel)
    {
        //loadBar.gameObject.GetComponent<Animator>().SetTrigger("Load");
        //loadBar.gameObject.SetActive(true);
        
        musicPlayer.Stop();
        StartCoroutine(NewGame(newGameLevel));
        //SceneManager.LoadScene(newGameLevel);
    }

    public void ExitGameBtn()
    {
        Application.Quit();
    }

    IEnumerator NewGame(string newGameLevel)
    {

        //loadBar.gameObject.GetComponent<Animator>().SetTrigger("Load");

        loadBar.gameObject.SetActive(true);

        yield return new WaitForSeconds(9);

        SceneManager.LoadScene(newGameLevel);
        yield return null;
    }
}
