using UnityEngine;

public class GameSources : MonoBehaviour {

    [HideInInspector] public static GameSources Instance;
    
    [HideInInspector] public float FrequencyOfActions;
    
    private void Awake ()
    {
        Instance = this;
        FrequencyOfActions = .1f;
    }
}
