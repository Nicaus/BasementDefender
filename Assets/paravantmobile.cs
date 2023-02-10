using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paravantmobile : MonoBehaviour
{
    public Transform paravant;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        // transform.position = new Vector3(0.0f, vitesse, 0.0f); 
        // float y = Mathf.Clamp(transform.position.y, -limite, limite);

        if (transform.position.x > 12){
            // transform.position = new Vector3(transform.position.x, y, transform.position.y);
            transform.position = transform.position + new Vector3(-0.01f, 0.0f, 0.0f);
        }
    }

}
