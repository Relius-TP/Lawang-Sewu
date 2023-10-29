using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SinglePlayer : MonoBehaviour
{
    [SerializeField] private GameObject closeDoorPrefab;
    [SerializeField] private GameObject openDoorPrefab;
    public float time = 3f;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI scoreFinalText;
    public GameObject HealthPickup;
    private float originalTime;

    public int score = 0;


    private void Start()
    {
        // InvokeRepeating("SpawnDoor", 2f, 3f);
        StartCoroutine(SpawnDoorRandom());
        originalTime = time;
        
    }

    private void Update()
    {
            

    }

    void updateScore(){
        scoreText.text = score.ToString();
        scoreFinalText.text = score.ToString();
    }

    IEnumerator SpawnHealthPickup(){
        int random = Random.Range(0,3);
        if(random == 0){
            Instantiate(HealthPickup, new Vector3(0, 7, 0), Quaternion.identity); //pintu tengah
        }
        else if(random == 1){
            Instantiate(HealthPickup, new Vector3(-2, 7, 0), Quaternion.identity); //pintu kiri
        }
        else if(random == 2){
            Instantiate(HealthPickup, new Vector3(2, 7, 0), Quaternion.identity); //pintu kanan
        }
    yield return new WaitForSeconds(5f);
    }

    IEnumerator SpawnDoorRandom(){
        int random = Random.Range(0,12);
        time = Random.Range(1.5f, time);
        if(Random.Range(0,100) == 100){
            time = 1f;
        }
        if(random == 0){
            Instantiate(openDoorPrefab, new Vector3(0, 7, 0), Quaternion.identity); //pintu tengah
            Instantiate(closeDoorPrefab, new Vector3(-2, 7, 0), Quaternion.identity); //pintu kiri
            Instantiate(openDoorPrefab, new Vector3(2, 7, 0), Quaternion.identity); //pintu kanan
        }
        else if(random == 1){
            Instantiate(closeDoorPrefab, new Vector3(0, 7, 0), Quaternion.identity); //pintu tengah
            Instantiate(openDoorPrefab, new Vector3(-2, 7, 0), Quaternion.identity); //pintu kiri
            Instantiate(openDoorPrefab, new Vector3(2, 7, 0), Quaternion.identity); //pintu kanan
        }
        else if(random == 2){
            Instantiate(openDoorPrefab, new Vector3(0, 7, 0), Quaternion.identity); //pintu tengah
            Instantiate(openDoorPrefab, new Vector3(-2, 7, 0), Quaternion.identity); //pintu kiri
            Instantiate(closeDoorPrefab, new Vector3(2, 7, 0), Quaternion.identity); //pintu kanan
        }
        else if(random == 3){
            Instantiate(openDoorPrefab, new Vector3(0, 7, 0), Quaternion.identity); //pintu tengah
            Instantiate(closeDoorPrefab, new Vector3(-2, 7, 0), Quaternion.identity); //pintu kiri
            Instantiate(closeDoorPrefab, new Vector3(2, 7, 0), Quaternion.identity); //pintu kanan
        }
        else if(random == 4){
            Instantiate(closeDoorPrefab, new Vector3(0, 7, 0), Quaternion.identity); //pintu tengah
            Instantiate(openDoorPrefab, new Vector3(-2, 7, 0), Quaternion.identity); //pintu kiri
            Instantiate(closeDoorPrefab, new Vector3(2, 7, 0), Quaternion.identity); //pintu kanan
        }
        else if(random == 5){
            Instantiate(closeDoorPrefab, new Vector3(0, 7, 0), Quaternion.identity); //pintu tengah
            Instantiate(closeDoorPrefab, new Vector3(-2, 7, 0), Quaternion.identity); //pintu kiri
            Instantiate(openDoorPrefab, new Vector3(2, 7, 0), Quaternion.identity); //pintu kanan
        }
        else if(random == 6){
            Instantiate(openDoorPrefab, new Vector3(0, 7, 0), Quaternion.identity); //pintu tengah
            Instantiate(openDoorPrefab, new Vector3(-2, 7, 0), Quaternion.identity); //pintu kiri
            Instantiate(closeDoorPrefab, new Vector3(2, 7, 0), Quaternion.identity); //pintu kanan
        }
        else if(random == 7){
            Instantiate(closeDoorPrefab, new Vector3(0, 7, 0), Quaternion.identity); //pintu tengah
            Instantiate(openDoorPrefab, new Vector3(-2, 7, 0), Quaternion.identity); //pintu kiri
            Instantiate(openDoorPrefab, new Vector3(2, 7, 0), Quaternion.identity); //pintu kanan
        }
        else if(random == 8){
            Instantiate(openDoorPrefab, new Vector3(0, 7, 0), Quaternion.identity); //pintu tengah
            Instantiate(closeDoorPrefab, new Vector3(-2, 7, 0), Quaternion.identity); //pintu kiri
            Instantiate(closeDoorPrefab, new Vector3(2, 7, 0), Quaternion.identity); //pintu kanan
        }
        else if(random == 9){
            Instantiate(closeDoorPrefab, new Vector3(0, 7, 0), Quaternion.identity); //pintu tengah
            Instantiate(openDoorPrefab, new Vector3(-2, 7, 0), Quaternion.identity); //pintu kiri
            Instantiate(openDoorPrefab, new Vector3(2, 7, 0), Quaternion.identity); //pintu kanan
        }
        else if(random == 10){
            Instantiate(openDoorPrefab, new Vector3(0, 7, 0), Quaternion.identity); //pintu tengah
            Instantiate(closeDoorPrefab, new Vector3(-2, 7, 0), Quaternion.identity); //pintu kiri
            Instantiate(openDoorPrefab, new Vector3(2, 7, 0), Quaternion.identity); //pintu kanan
        }
        else if(random == 11){
            Instantiate(closeDoorPrefab, new Vector3(0, 7, 0), Quaternion.identity); //pintu tengah
            Instantiate(openDoorPrefab, new Vector3(-2, 7, 0), Quaternion.identity); //pintu kiri
            Instantiate(closeDoorPrefab, new Vector3(2, 7, 0), Quaternion.identity); //pintu kanan
        }
        else if(random == 12){
            Instantiate(openDoorPrefab, new Vector3(0, 7, 0), Quaternion.identity); //pintu
            Instantiate(closeDoorPrefab, new Vector3(-2, 7, 0), Quaternion.identity); //pintu
            Instantiate(openDoorPrefab, new Vector3(2, 7, 0), Quaternion.identity); //pintu
        }
    yield return new WaitForSeconds(time);
    time = originalTime;
    score += 1;
    updateScore();
    bool isSpawnHealthPickup = Random.Range(0,2) == 0;
    if(isSpawnHealthPickup){
        StartCoroutine(SpawnHealthPickup());
    }
    StartCoroutine(SpawnDoorRandom());
    }
}