using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatBehaviour : MonoBehaviour
{
    AudioSource collisionSound;
    public GameObject fx;
    GameObject worldObject;
    GameObject dragonObject;

    void Start() 
    {
        worldObject = GameObject.Find("World");
        dragonObject = GameObject.Find("Dragon");
        collisionSound = worldObject.GetComponent<AudioSource>();
    }

    void Update() 
    {

    }

    void OnTriggerEnter(Collider other) 
    { // OnCollisionEnter
        if (other.tag == "Player") 
        {
            Destroy(gameObject);
            Instantiate( fx, transform.position, Quaternion.identity );
            worldObject.SendMessage("AddHit");
            dragonObject.SendMessage("AddHit");
            
            if( collisionSound )
                collisionSound.Play();
        }
    }
}