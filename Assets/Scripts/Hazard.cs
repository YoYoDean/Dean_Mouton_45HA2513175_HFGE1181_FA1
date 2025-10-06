using UnityEngine;

public class Hazard : MonoBehaviour
{
    public int damage;
    public void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            if (CameraShake.Instance != null)
            {
                CameraShake.Instance.Shake(.5f, .3f);
            }

            col.gameObject.GetComponent<HealthSystem>().Damage(damage);
            HealthManager.Instance.CheckHealth();

        }
    }
}
