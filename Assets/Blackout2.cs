using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading.Tasks;

public class Blackout2 : MonoBehaviour
{
    public void ChangeScene(string Transition)
    {
        void OnTriggerEnter(Collider other)
        {
            SceneManager.LoadScene (Transition);
        }
        
    }

}
