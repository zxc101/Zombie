using UnityEngine;

public class MainSources : MonoBehaviour {

    [HideInInspector] public static MainSources Instance;

    [HideInInspector] public int Coins;
    [HideInInspector] public string Language;
    [HideInInspector] public GameObject Player;
    
    private void Awake () {
        if (Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
    }
}
