using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float speed = 20f;
    private float movementX; // deplacement fleche horizontal
    private float Xrange = 22f;
    public GameObject projectilePrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < -Xrange)
        {
            transform.position = new Vector3(-Xrange, transform.position.y, transform.position.z);
        }

        if (transform.position.x > Xrange)
        {
            transform.position = new Vector3(Xrange, transform.position.y, transform.position.z);
        }
        //On applique le vecteur
        transform.Translate(new Vector3(movementX, 0.0f, 0.0f) * Time.deltaTime * speed);
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        //On recupère le vecteur 2
        Vector2 movementVector = context.ReadValue<Vector2>();
        movementX = movementVector.x;
    }

    public void OnFire(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
