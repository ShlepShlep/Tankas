using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stone : MonoBehaviour
{
    public GameObject smallStone;
   
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name.Contains("Bullet"))
        {
            gameObject.SetActive(false);
            smallStone.SetActive(true);
            print("Stone");
        }
        
    }
}
