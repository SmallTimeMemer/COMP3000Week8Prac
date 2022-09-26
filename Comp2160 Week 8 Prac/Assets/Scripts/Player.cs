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
        dz = Input.GetAxis("Vertical");
        dy = 0;
        movement = new Vector3(dx*moveSpeed*Time.deltaTime, dy * moveSpeed * Time.deltaTime, dz * moveSpeed * Time.deltaTime);
        transform.Translate(movement);
    }
}
