using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class emitbulllet : MonoBehaviour
{
    public Transform prefabBullet;
    public float limite;
    public float vitesse;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(EmittingBullet());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate()
    {
        // transform.position = new Vector3(vitesse, transform.position.y, transform.position.z);
    }

    IEnumerator EmittingBullet(){
        int nbBullet=0;
        while (true){
            nbBullet++;
            yield return new WaitForSeconds(1/nbBullet);  
            Transform newBullet = Instantiate(prefabBullet);
            float randomy = Random.Range(-limite, limite);
            newBullet.position = new Vector3(transform.position.x, transform.position.y+randomy, transform.position.z);
        }
    }
}
