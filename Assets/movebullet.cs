using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movebullet : MonoBehaviour
{
    public float vitesse;
    public float limite;
    
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
        transform.position = transform.position + new Vector3(vitesse + Random.Range(-limite, limite), 0.0f, 0.0f);
    }

    void OnTriggerEnter2D(Collider2D collision){
        Destroy(transform.gameObject);
    }
}
