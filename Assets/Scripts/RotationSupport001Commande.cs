using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationSupport001Commande : MonoBehaviour
{
    public GameObject Support;
    


    void Update()
    {
        float input = Input.GetAxis("RotationSupport");
        EtatSupport rotationEtat = MoveStateForInput(input);
        RotationSupport001Controller controller = Support.GetComponent<RotationSupport001Controller>();
        controller.rotationEtat = rotationEtat;

        
    }

    EtatSupport MoveStateForInput(float input)
    {
        if (input > 0)
        {
            return EtatSupport.Positif;
        }
        else if (input < 0)
        {
            return EtatSupport.Negatif;
        }
        else
        {
            return EtatSupport.Fixe;
        }
    }
}
