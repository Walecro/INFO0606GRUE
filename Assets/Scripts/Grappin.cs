using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grappin : MonoBehaviour
{
    public ArticulationBody crochet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float input = Input.GetAxis("GrappinVertical");
        if(input != 0){

            // Suivant l'input on retracte ou étend le grappin d'une vitesse arbitraire
            var drive = crochet.zDrive;
            drive.target += input*0.009f;
            crochet.zDrive = drive;
        }

        if (Input.GetKey(KeyCode.Space)){
            // Destruction du joint crée entre le cube et le crochet
            Destroy(this.gameObject.GetComponent<FixedJoint>());
        }

        
    }
    void OnCollisionEnter(Collision Collision){
        if (Collision.gameObject.GetComponent<Rigidbody>() != null){
            FixedJoint joint = this.gameObject.AddComponent<FixedJoint>();
            joint.connectedBody = Collision.rigidbody;
        }
}
}
