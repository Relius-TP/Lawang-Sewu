using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHP : MonoBehaviour
{
    public Image Top;
    public Image Mid;
    public Image Bottom;

    public GameObject WinScreen;

    GameObject top;
    GameObject mid;
    GameObject bot;

    bool isHit;

    public static int hp;
      public Camera cam;
          public float ShakeCameraTime = 1f;
    void Start()
    {
        hp = 3;
        bot = GameObject.Find(Bottom.name);
        mid = GameObject.Find(Mid.name);
        top = GameObject.Find(Top.name);

    }

    void Update()
    {
        if (hp == 2 && bot.active == true)
        {
            Bottom.enabled = false;
            bot.SetActive(false);
        }
        else if (hp == 1 && mid.active == true)
        {
            Mid.enabled = false;
            mid.SetActive(false);
        }
        else if (hp == 0 && top.active == true)
        {
            Top.enabled = false;
            top.SetActive(false);
        }
        else if(hp == 1 && top.active == false)
        {
            Top.enabled = true;
            top.SetActive(true);
        }
        else if(hp == 2 && mid.active == false)
        {
            Mid.enabled = true;
            mid.SetActive(true);
        }
        else if(hp == 3 && bot.active == false)
        {
            Bottom.enabled = true;
            bot.SetActive(true);
        }
        else if (hp == -1)
        {
            Destroy(gameObject);
            WinScreen.SetActive(true);
            Time.timeScale = 0;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Door")
        {
            isHit = true;
            hp -= 1;
            StartCoroutine(CamShake());
        }
        else
        {
            isHit = false;
        }

        if (collision.CompareTag("Health"))
        {
            if(hp < 3)
            {
                hp += 1;
                Debug.Log("Get HP");
            }
            Destroy(collision.gameObject);
        }

    }

     IEnumerator CamShake(){
        Debug.Log("Shake");
        Vector3 originalPos = cam.transform.position;
        float elapsed = 0.0f;

        while(elapsed < ShakeCameraTime){
            float x = Random.Range(-1f, 1f) * 0.2f;
            float y = Random.Range(-1f, 1f) * 0.2f;

            cam.transform.position = new Vector3(3+x, y, originalPos.z);
            elapsed += Time.deltaTime;
            yield return null;
        }
        cam.transform.position = originalPos;
    }

}
