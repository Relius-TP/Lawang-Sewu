using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Button start;
    public Button quit;
    public Button p1;
    public Button p2;

    public Canvas chose;
    void Start()
    {
        start.onClick.AddListener(Chose);
        quit.onClick.AddListener(QuitGame);

        p1.onClick.AddListener(P1);
        p2.onClick.AddListener(P2);
    }
    void P1()
    {
        StartCoroutine(LoadP1());
    }
    void P2()
    {
        StartCoroutine(LoadP2());
    }
    void QuitGame()
    {
       StartCoroutine(LoadQuitGame());
    }

    void Chose()
    {
        StartCoroutine(LoadChose());
    }

    IEnumerator LoadP1(){
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Level2");
    }
    IEnumerator LoadP2()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Level3");
    }

    IEnumerator LoadQuitGame(){
        yield return new WaitForSeconds(1f);
        Application.Quit();
    }
    IEnumerator LoadChose()
    {
        yield return new WaitForSeconds(1f);
        chose.enabled = true;
    }
}
