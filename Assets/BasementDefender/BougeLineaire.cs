using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BougeLineaire : MonoBehaviour
{
    public float speed = -0.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(speed * Time.fixedDeltaTime, 0.0f,0.0f);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(this.gameObject);
    }
}
