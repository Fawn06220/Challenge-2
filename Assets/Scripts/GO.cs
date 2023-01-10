using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Classe d'affichage du Game Over et d'arret du jeu
public class GO : MonoBehaviour
{

    private GameObject go;
    // Start is called before the first frame update

    private void Awake()
    {
        go = GameObject.Find("GameOver");
        //On desactive l'affichage
        go.SetActive(false);
    }
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void EndGame()
    {
        //On active l'affichage
        go.SetActive(true);
        //On arrête le spawn
        Time.timeScale = 0;
    }
}
