using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthManager : MonoBehaviour
{
    public static HealthManager Instance;
    private HealthSystem healthSystem;

    private GameMNGR gameMNGR;
    private string sceneName;
    public GameObject losescreen;

    private void Awake()
    {

        if (Instance != null)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        healthSystem = FindFirstObjectByType<PlayerController>().GetComponent<HealthSystem>();
        sceneName = SceneManager.GetActiveScene().name;
    }

    public HealthSystem AccessHealthSystem()
    {
        return healthSystem;
    }

    public void CheckHealth()
    {
        if (healthSystem.GetHearts() < 0)
        {
            losescreen.SetActive(true);
           SceneManager.LoadScene(sceneName);
        }
        
    }
}
