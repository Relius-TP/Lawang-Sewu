using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerMovement : MonoBehaviour
{
    public TMP_InputField textBox;
    private Transform playerPos;
    private string commandText;
    private bool isMoving;
    public Camera cam;
    public float ShakeCameraTime = 1f;
    [SerializeField] private float speed;

    private Vector3 destinationPosition;

    void Start()
    {
        playerPos = transform;
        textBox.onSubmit.AddListener(GetText);
        textBox.ActivateInputField();
        textBox.Select();
    }

    void Update()
    {
        if (isMoving)
        {
            transform.position = Vector3.MoveTowards(transform.position, destinationPosition, Time.deltaTime * speed);

            if (transform.position == destinationPosition)
            {
                isMoving = false;
            }

        }
        textBox.ActivateInputField();
        textBox.Select();
    }

    IEnumerator CamShake(){
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
    public void GetText(string input)
    {
        commandText = input.ToLower();
        textBox.text = "";
        textBox.ActivateInputField();
        textBox.Select();

        if (commandText == "left")
        {
            MoveLeft();
        }
        else if (commandText == "right" || commandText == "rght")
        {
            MoveRight();
        }
        else
        {
            Debug.Log("Typo");
        }
    }

    public void MoveLeft()
    {
        if (transform.position.x > -2)
        {
            isMoving = true;
            destinationPosition = new Vector3(transform.position.x - 2, transform.position.y, 0);
        }
        else
        {
            PlayerHP.hp -= 1;
            StartCoroutine(CamShake());
            Debug.Log("Anda Gagal, Terbentur Dinding Kiri");
        }
    }

    public void MoveRight()
    {
        if (transform.position.x < 2)
        {
            isMoving = true;
            destinationPosition = new Vector3(transform.position.x + 2, transform.position.y, 0);
        }
        else
        {
            PlayerHP.hp -= 1;
            StartCoroutine(CamShake());
            Debug.Log("Anda Gagal, Terbentur Dinding Kanan");
        }
    }
}
