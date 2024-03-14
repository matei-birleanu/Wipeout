using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class demo : MonoBehaviour
{
    public float sensX;
    public float sensY;
    
    public Transform orientation;
    
    float xRotation, yRotation;
    // Start is called before the first frame update
    public GameObject player;
    void Start()
    {   
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        player = GameObject.FindGameObjectWithTag("PlayerAll");
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensX;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensY;

        yRotation += mouseX;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);
        orientation.rotation = Quaternion.Euler(0,yRotation, 0);

        if (player.transform.position.y < 10) {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);

        }

    }
}
