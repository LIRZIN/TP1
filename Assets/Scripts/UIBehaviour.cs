using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using static StaticVariables;

public class UIBehaviour : MonoBehaviour 
{
    TMP_Text headText;
    TMP_Text timerText;
    int nbCats = -1;

    void Start() 
    {
        headText = GameObject.Find("lblCats").GetComponent<TMPro.TMP_Text>();
        AddHit();
        timerText = GameObject.Find("lblTime").GetComponent<TMPro.TMP_Text>();
        timerText.text = "Time :" + StaticVariables.currentTime.ToString();
        StartCoroutine(TimerTick());
    }

    void Update() 
    {
        
    }

    public void AddHit() 
    {
        nbCats++;
        headText.text = "BobHeads: " + nbCats;
    }

    IEnumerator TimerTick() 
    {
        while( StaticVariables.currentTime > 0)
        {
            // attendre une seconde
            yield return new WaitForSeconds(1);
            StaticVariables.currentTime--;
            timerText.text = "Time :" + StaticVariables.currentTime.ToString();
        }

        // game over
        SceneManager.LoadScene("dragonHouse"); // le nom de votre scene
    }
}
