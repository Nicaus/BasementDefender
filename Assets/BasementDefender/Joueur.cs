using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Joueur : MonoBehaviour
{
    //Valeurs configurables de l'inspecteur
    public float speed = 0.1f;
    public float limit = 10.0f;
    public float cadenceTir = 0.5f;

    public Transform prefabAmour;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            StartCoroutine(Tirer());
        }

        if (Input.GetButtonUp("Fire1"))
        {
            StopAllCoroutines();
        }

    }

    IEnumerator Tirer()
    {
        while (true)
        { 
            Instantiate(prefabAmour, transform.position + new Vector3(2f, 0f, 0f), Quaternion.identity);
            yield return new WaitForSeconds(cadenceTir);
        }
    }

    void FixedUpdate()
    {
        float verticalInput = Input.GetAxis("Vertical");
        transform.Translate(0.0f, verticalInput * speed * Time.fixedDeltaTime, 0.0f);
        Vector3 pos = transform.position;
        pos.y = Mathf.Clamp(transform.position.y, -limit, limit);
        transform.position = pos;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Ouch...");
        SceneManager.LoadScene("SampleScene");
    }
}
