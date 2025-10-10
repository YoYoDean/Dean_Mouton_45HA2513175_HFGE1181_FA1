using UnityEngine;

public class StartHelptxt : MonoBehaviour
{
    public GameObject helpScreen;
     void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            helpScreen.SetActive(true);
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            helpScreen.SetActive(false);
        }
    }
}
