using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSquare : MonoBehaviour
    
{
   [SerializeField] private float MaxDistance;
   [SerializeField] private float speed;
    private Vector2 StartPosition;

    //private Vector3 direction = new Vector3 (1, 0, 0) per dare una posizione ad un game object 
    // Start is called before the first frame update
    void Start()
    {
        StartPosition = transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        

       float h = Input.GetAxis("Horizontal");
       float v = Input.GetAxis("Vertical");
       Vector3 nuova = (new Vector3(h, v ,0 )).normalized;
        transform.position = transform.position + speed * Time.deltaTime * nuova;

        float Distanza = Vector2.Distance(transform.position,StartPosition);
        if (Distanza > MaxDistance)
        {
            transform.position = StartPosition;
        }
         
        
        
    }
}
