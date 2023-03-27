using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatteCommande : MonoBehaviour
{
    public GameObject Patte;


    void Update()
    {
        float input = Input.GetAxis("PatteDeploiement");
        EtatPatte rotationEtat = MoveStateForInput(input);
        PatteControleur controller = Patte.GetComponent<PatteControleur>();
        controller.rotationEtat = rotationEtat;

        
    }

    EtatPatte MoveStateForInput(float input)
    {
        if (input > 0)
        {
            return EtatPatte.Positif;
        }
        else if (input < 0)
        {
            return EtatPatte.Negatif;
        }
        else
        {
            return EtatPatte.Fixe;
        }
    }
}
