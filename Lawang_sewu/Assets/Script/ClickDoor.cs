using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickDoor : MonoBehaviour
{
    public GameObject CloseDoor;
    public GameObject Reseter;
    public GameObject DeactiveDoorObj;

    private GameObject ThisDoor;
    public float CoolDown = 5f;
    private static bool isClicked = false; // static variable shared among all instances
    private float nextClickTime;
    private static int maxClose = 2;
    public static int currentClose = 0;

    // get this gameobject
    void Start()
    {
        ThisDoor = gameObject;
    }

    public void CloseThisDoor()
    {
        // DeactiveDoor();
        // close this door
        Instantiate(CloseDoor, ThisDoor.transform.position, Quaternion.identity);
        // destroy this door
        Destroy(ThisDoor);
    }

    private bool thisDoorClicked()
    {
        // check if this door is clicked
        if (Input.GetMouseButtonDown(0))
        {
            
            // get the mouse position
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            // check if the mouse position is on this door
            if (ThisDoor.GetComponent<Collider2D>() == Physics2D.OverlapPoint(mousePosition))
            {
                currentClose += 1;
                return true;
            }
        }
        return false;
    }

    // Update is called once per frame
    void Update()
    {
        // check if this door is clicked
        if (thisDoorClicked())
        {
            // if this door is clicked and not in cooldown
            if (Time.time >= nextClickTime && !isClicked && currentClose <= maxClose)
            {
                // start the timer
                StartCoroutine(ClickTimer());
                // set the next click time
                nextClickTime = Time.time + CoolDown;
                // set isClicked to true
                isClicked = true;
            }
        }

    }

    IEnumerator ClickTimer()
    {
        // wait for the duration
        yield return new WaitForSeconds(CoolDown);
        // close this door
        CloseThisDoor();
        // set isClicked to false
        isClicked = false;
    }

    void DeactiveDoor()
    {
        // swap openDoorPrefab sprite with DeactiveDoorSprite
        Instantiate(DeactiveDoorObj, ThisDoor.transform.position, Quaternion.identity);
        // destroy this door
        Destroy(ThisDoor);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Cant Click")
        {
            DeactiveDoor();
        }
    }


}
