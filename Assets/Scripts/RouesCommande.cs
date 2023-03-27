using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouesCommande : MonoBehaviour
{
    public GameObject Roues;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float input = Input.GetAxis("RouesDevantDerriere");
        float rotate = Input.GetAxis("RouesRotation");
        

        if(input < 0){
            transform.Translate(Vector3.back * 0.02f);
        }else if(input > 0){

            transform.Translate(Vector3.forward* 0.02f);
        }

        if(rotate < 0){
            //On tourne à gauche 
            transform.Rotate(0,1.0f,0);
        }else if(rotate > 0){
            //On tourne à droite
            transform.Rotate(0,-1.0f,0);
        }
    }
}
