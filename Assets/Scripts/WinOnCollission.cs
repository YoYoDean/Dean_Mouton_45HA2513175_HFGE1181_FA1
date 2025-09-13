using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinOnCollission : MonoBehaviour
{
    private string sceneName;
    

    private void Start()
    {
        sceneName = SceneManager.GetActiveScene().name;
    }
    

    private void OnTriggerEnter2D(Collider2D trig)
    {
        if (!GameMNGR.instance.GetHasKey())
        {
            
            return ;
        }

        if (trig.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(sceneName);
            
        }
    }

}
