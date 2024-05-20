using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FogSceneChanger : MonoBehaviour
{
    //private void OnTriggerEnter(Collider other)
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.name == "Player")
        {

        
            var currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

            if (currentSceneIndex == 3 || currentSceneIndex == 4)
            {
                SceneManager.LoadScene(1);
            }
            else if (currentSceneIndex == 1)
            {
                SceneManager.LoadScene(4);
            }
        }
       
    }
}
