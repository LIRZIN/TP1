using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class icecreamcone : MonoBehaviour
{
        public GameObject fx;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other) 
    { // OnCollisionEnter
        if (other.tag == "Player" )//&& nb_cats_on_scene <= 0) 
        {
            GameObject.Find("ThirdPersonController").transform.GetChild(1).gameObject.SetActive(true);
            Instantiate( fx, transform.position, Quaternion.identity );
        }
    }
}
