using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseManager : MonoBehaviour
{
    [SerializeField] private Button resume;
    [SerializeField] private Button back;

    private Canvas canvas;
    void Start()
    {
        canvas = GetComponent<Canvas>();
        resume.onClick.AddListener(Resume);
        back.onClick.AddListener(Back);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (canvas.enabled == false)
            {
                canvas.enabled = true;
                Time.timeScale = 0;
            }
            else
            {
                canvas.enabled = false;
                Time.timeScale = 1;
            }
        }
    }

    public void Resume()
    {
        StartCoroutine(PressResume());
    }

    public void Back()
    {
        StartCoroutine(PressBack());
    }

    IEnumerator PressResume()
    {
        canvas.enabled = false;
        Time.timeScale = 1;
        yield return new WaitForSeconds(1f);
    }
    

    IEnumerator PressBack()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Main Menu");
        yield return new WaitForSeconds(1f);    
    }


}
