using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Switch : MonoBehaviour
{
    [SerializeField]
    private bool isActive;
    [SerializeField]
    private GameObject hidingObject;
    public GameObject eTXT;

    private bool canInteract = false;


    private void Start()
    {

        hidingObject.SetActive(isActive);
        
    }

    private void Update()
    {
        if (canInteract)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (hidingObject.activeInHierarchy)
                {
                    isActive = false;
                    hidingObject.SetActive(isActive);
                }
                else
                {
                    isActive = true;
                    hidingObject.SetActive(isActive);
                }
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("Entered");
        if (col.gameObject.tag == "Player")
        {
            Debug.Log("CanInter true");
            canInteract = true;
            eTXT.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            Debug.Log("CanInter false");
            canInteract = false;
            eTXT.SetActive(false);
        }
    }
}
