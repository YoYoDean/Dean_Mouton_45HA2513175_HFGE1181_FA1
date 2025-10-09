using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class ExitGAMe : MonoBehaviour
{

   
    // Update is called once per frame
    void Update()
    {
         string actScnene = SceneManager.GetActiveScene().name;

        if (actScnene == "Main Menu" & Keyboard.current.qKey.wasPressedThisFrame)
        {
            Debug.Log("Quit");
            UnityEditor.EditorApplication.isPlaying = false;
            Application.Quit();
        }
    }
}
