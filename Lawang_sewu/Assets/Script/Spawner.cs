using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject closeDoorPrefab;
    [SerializeField] private GameObject openDoorPrefab;
    public GameObject Reseter;
    public float reseterPos=8f;


    private void Start()
    {
        InvokeRepeating("SpawnDoor", 2f, 3f);
        InvokeRepeating("SpawnReseter", 2f, 3f);

    }

    private void Update()
    {

    }

    private void SpawnReseter()
    {
        Instantiate(Reseter, new Vector3(0, reseterPos, 0), Quaternion.identity);
    }

    private void SpawnDoor()
    {
            Instantiate(openDoorPrefab, new Vector3(0, 7, 0), Quaternion.identity); //pintu tengah
            Instantiate(openDoorPrefab, new Vector3(-2, 7, 0), Quaternion.identity); //pintu kiri
            Instantiate(openDoorPrefab, new Vector3(2, 7, 0), Quaternion.identity); //pintu kanan
        
    }


}