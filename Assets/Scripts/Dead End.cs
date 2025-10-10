using TMPro;
using UnityEngine;

public class DeadEnd : MonoBehaviour
{
    public GameObject deadEndTXT;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            deadEndTXT.SetActive(true);
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            deadEndTXT.SetActive(false);
        }
    }


}
