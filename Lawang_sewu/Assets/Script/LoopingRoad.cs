using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class LoopingRoad : MonoBehaviour
{
    [SerializeField] private float speed;
    private void Update()
    {
        transform.Translate(Vector3.down * speed *  Time.deltaTime);

        if(transform.position.y < -10)
        {
            transform.position = new Vector3(0,0,0);
        }
    }
}
