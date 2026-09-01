using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public string playerName;
    public static MenuManager Instance;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    private void Awake()
    {
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void StartNew()
    {
        // SceneManager.LoadScene(1);
        Debug.Log("Game started!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
