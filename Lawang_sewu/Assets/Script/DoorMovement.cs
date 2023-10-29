using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorMovement : MonoBehaviour
{
    private Transform door;
    [SerializeField] private float moveSpeed;
    [SerializeField] private float lifeTime;

    private void Start()
    {
        door = this.transform;
    }

    private void Update()
    {
        door.Translate(new Vector3(0, -1 * Time.deltaTime * moveSpeed, 0));
        Invoke("DestroyDoor", lifeTime);
    }

    private void DestroyDoor()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Cant Click")
        {
            ClickDoor.currentClose = 2;
        }
    }
}
