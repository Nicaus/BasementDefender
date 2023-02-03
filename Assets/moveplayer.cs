using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveplayer : MonoBehaviour{
    public Transform player;
    public float vitesse;
    public float limite;
    private float vertical;


    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){
        vertical = Input.GetAxisRaw("Vertical");
    }

    // Controls and mouvements
    void FixedUpdate(){
        player.position = player.position + vertical * new Vector3(0.0f,vitesse,0.0f);
        float y = Mathf.Clamp(player.position.y, -limite, limite);  

        player.position = new Vector3(player.position.x,y,player.position.y);
    }
}
