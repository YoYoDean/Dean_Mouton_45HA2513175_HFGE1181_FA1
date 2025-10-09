using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneMNGR : MonoBehaviour
{
   public string SceneName;
   public GameObject pausemenu;


   public void Update()
   {
      Scene actScnene = SceneManager.GetActiveScene();
      if (pausemenu.activeInHierarchy == true & Keyboard.current.xKey.wasPressedThisFrame)
      {
         LoadScene();
      }
      if (actScnene.name == "Main Menu" & Keyboard.current.sKey.wasPressedThisFrame)
      {
         LoadScene();
      }
   }

   public void LoadScene()
   {  
      Time.timeScale = 1;
      SceneManager.LoadScene(SceneName ,LoadSceneMode.Single);
      
   }
   


}
