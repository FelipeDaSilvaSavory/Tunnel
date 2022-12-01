using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;

public class Blackout : MonoBehaviour
{
    public Transform teleportTarget;
    public Transform theLight;
    public Transform teleportTarget2;
    public Transform theLight2;
    public Transform teleportTargetB;
    public Transform theLightB;

    void OnTriggerEnter(Collider other)
    {
        theLight.transform.position = teleportTarget.transform.position;
        theLight2.transform.position = teleportTarget2.transform.position;
        theLightB.transform.position = teleportTargetB.transform.position;
        theLightB.transform.position = teleportTarget2.transform.position;
    }
}
