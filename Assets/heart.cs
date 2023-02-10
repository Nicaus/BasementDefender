using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // shoot = Input.GetAxisRaw("Horizontal");
    }

    void FixedUpdate(){
        if (Input.GetButtonDown("Fire1")){
            Instantiate(projectile, transform.position + vector3(2f,0.0f,0.0f), Quaternion.identity);
        }
    }
}
