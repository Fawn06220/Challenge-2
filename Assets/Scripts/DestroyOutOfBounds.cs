using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Classe de destruction des objets qui sortent de la zone de jeu
public class DestroyOutOfBounds : MonoBehaviour
{
    [SerializeField]
    private float topBound=30f;
    [SerializeField]
    private float lowerBound = -1f;
    //On ramène le gameObject du GameOver
    private GameObject go;
    // Start is called before the first frame update

    private void Awake()
    {
        //Instanciation du gameObject
        go = GameObject.Find("Main Camera");
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //On vérifie la position des gameObjects par rapport aux limites
        if(transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if(transform.position.z < lowerBound)
        {
            Destroy(gameObject);
            //On appelle la fonction EndGame() du script GO.cs qui est sur la camera
            go.GetComponent<GO>().EndGame();
        }
    }
}
