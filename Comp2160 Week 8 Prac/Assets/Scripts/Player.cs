using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    Vector3 movement;
    [SerializeField] private float moveSpeed;
    private float dx, dy, dz;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        dx = Input.GetAxis("Horizontal");
        dy = 0;
        dz = Input.GetAxis("Vertical");
    
        movement = new Vector3(dx*moveSpeed*Time.deltaTime, 0, dz * moveSpeed * Time.deltaTime);
        transform.Translate(movement, Space.World);

        if(movement!=Vector3.zero){
            Quaternion toRotation = Quaternion.LookRotation(movement, Vector3.up);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, 5);
        }


    }

     
}
