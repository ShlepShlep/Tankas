using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20;
    public int particleCount;
    public GameObject stone;
    public GameObject smallStone;
    public GameObject particle;

    void Start()
    {
        Destroy(gameObject, 1f);
    }
    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Boom")
        {
            Destroy(collision.gameObject);

            for (int i = 0; i < particleCount; i++)
            {
                var offset = Random.insideUnitSphere;
                Instantiate(particle, transform.position + offset, transform.rotation);
            }
        }
        Destroy(gameObject);
    }

    

}
