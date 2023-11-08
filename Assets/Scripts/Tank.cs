using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : MonoBehaviour
{
    public float speed = 6;
    public float rotateSpeed = 90;

    public string verticalAxis;
    public string horizontalAxis;
    public KeyCode shootKey;

    public GameObject bullet;
    public Transform shootPoint;

    void Update()
    {
        var vertical = Input.GetAxis(verticalAxis);
        //transform.position += transform.forward * speed * vertical * Time.deltaTime;
        GetComponent<Rigidbody>().velocity = transform.forward * speed * vertical;

        var horizontal = Input.GetAxis(horizontalAxis);
        transform.Rotate(0, 90 * Time.deltaTime * horizontal, 0);

        if (Input.GetKeyDown(shootKey))
        {
            print("Shoot");
            Instantiate(bullet, shootPoint.position, shootPoint.rotation);
        }
    }
}

