using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EtatSupport { Fixe = 0, Positif = 1, Negatif = -1 };

public class RotationSupport001Controller : MonoBehaviour
{

    public EtatSupport rotationEtat = EtatSupport.Fixe;
    public float vitesse = 30.0f;
    private ArticulationBody articulation;
    void Start()
    {
        articulation = GetComponent<ArticulationBody>();
    }

    void FixedUpdate()
    {
        if (rotationEtat != EtatSupport.Fixe)
        {
            float rotationChange = (float)rotationEtat * vitesse * Time.fixedDeltaTime;
            float rotationGoal = AxeRotation() + rotationChange;
            RotationVers(rotationGoal);
        }


    }

    float AxeRotation()
    {
        float RotationRads = articulation.jointPosition[0];
        float Rotation = Mathf.Rad2Deg * RotationRads;
        return Rotation;
    }

    void RotationVers(float primaryAxisRotation)
    {
        var drive = articulation.xDrive;
        drive.target = primaryAxisRotation;
        articulation.xDrive = drive;
    }
}
