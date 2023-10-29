using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReseterMovement : MonoBehaviour
{
    private Transform reseter;

    [SerializeField] private float moveSpeed;
    [SerializeField] private float lifeTime;
    void Start()
    {
        reseter = this.transform;
    }

    void Update()
    {
        reseter.Translate(new Vector3(0, -1 * Time.deltaTime * moveSpeed, 0));
        Invoke("DestroyReseter", lifeTime);
    }
    private void DestroyReseter()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            ClickDoor.currentClose = 0;
        }
    }
}
