using UnityEngine;
using UnityEngine.UI;

public class SingletonGameManager : MonoBehaviour
{
   
    void Start()
    {
        GetComponent<Text>().text = GameApplicationManager.Instance.DIFFICULTY_LEVEL_NAMES[GameApplicationManager.Instance.DifficultyLevel];
    }

    
}
