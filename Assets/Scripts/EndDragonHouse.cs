using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndDragonHouse : MonoBehaviour
{
    int nb_cats_on_scene;
    int nb_cats_spawned;
    // Start is called before the first frame update
    void Start()
    {
        nb_cats_on_scene = nb_cats_spawned = GameObject.Find("World").GetComponent<CatBotGenerator>().nbObjects;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddHit() 
    {
        nb_cats_on_scene--;
    }

    void OnTriggerEnter(Collider other) 
    { // OnCollisionEnter
        if (other.tag == "Player" && nb_cats_on_scene <= 0) 
            SceneManager.LoadScene("Terrain");
    }
}
