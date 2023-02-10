using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paravant : MonoBehaviour
{

    public float speed;
    public float limite;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(speed * Time.fixedDeltaTime, 0.0f, 0.0f);
        float x = Mathf.Max(transform.position.x, limite);
        transform.position = new Vector3(x, transform.position.y, transform.position.z);
    }
}
