using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Emetteur : MonoBehaviour
{
    public GameObject prefBullet;
    public float spawnRange = 5f;
    private float timePassed = 0f;
    private float delay = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        timePassed += Time.fixedDeltaTime;
        if (timePassed > delay)
        {
            float delayScale = Time.timeSinceLevelLoad / 5.0f;
            delay = Random.Range(0.5f/ delayScale, 2f/delayScale);
            Vector3 spawnPosition = transform.position;
            spawnPosition.y += Random.Range(-spawnRange, spawnRange);
            timePassed = 0f;
            Instantiate(prefBullet, spawnPosition, Quaternion.identity);
        }
    }
}
