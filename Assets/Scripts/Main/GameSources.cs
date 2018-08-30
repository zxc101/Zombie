using UnityEngine;

public class GameSources : MonoBehaviour {

    [HideInInspector] public static GameSources Instance;
    
    [HideInInspector] public float RPS;
    
    private void Awake ()
    {
        Instance = this;
        RPS = .1f;
    }
}
