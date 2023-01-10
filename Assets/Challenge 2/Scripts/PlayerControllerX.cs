using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    //Nouvelles vars pour le delai d'appui sur espace
    private float delai = 1.5f;
    private bool appuye = false;

    // Update is called once per frame
    void Update()
    {
            // On spacebar press, send dog et que l'on a pas deja appuyé dessus
            if (Input.GetKeyDown(KeyCode.Space) && !appuye)
            {
                appuye = true;//On a deja appuye une fois sur espace
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            }
            //Si on a deja appuye une fois
            if (appuye)
            {
                delai = delai - Time.deltaTime; //Compte a rebours(2s dans notre cas)
                if (delai <= 0) //Si compte a rebours a zero
                {
                    delai = 1.5f; // On reinitialise le delai
                    appuye = false; //On passe appuye a false
                }
            }


    }
}
