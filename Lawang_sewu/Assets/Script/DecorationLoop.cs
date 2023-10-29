using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecorationLoop : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    [SerializeField] private Vector3 loopPosition;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * Time.deltaTime * moveSpeed);

        if(gameObject.transform.position.y < -6)
        {
            gameObject.transform.position = loopPosition;
        }
    }
}
