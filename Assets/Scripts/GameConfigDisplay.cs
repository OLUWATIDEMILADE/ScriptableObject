using UnityEngine;
using UnityEngine.UI;
using TMPro; // Required for TextMeshPro UI

public class GameConfigDisplay : MonoBehaviour
{
    public GameConfig gameConfig; // Reference to ScriptableObject
    public TMP_Text titleText;
    public TMP_Text playersText;
    public TMP_Text speedText;

    void Start()
    {
        if (gameConfig != null)
        {
            titleText.text = "Game Title: " + gameConfig.gameTitle;
            playersText.text = "Max Players Lives: " + gameConfig.maxPlayerlives;
            speedText.text = "Game Speed: " + gameConfig.gameSpeed.ToString("F2");
        }
        else
        {
            Debug.LogError("GameConfig is not assigned!");
        }
    }
}
