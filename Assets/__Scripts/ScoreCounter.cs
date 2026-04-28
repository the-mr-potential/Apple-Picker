using UnityEngine;
using UnityEngine.UI;
using TMPro; 

public class ScoreCounter : MonoBehaviour
{
    [Header("Dynamic)")]
    public int score = 0;

    private TextMeshProUGUI uiText;

    void Start()
    {
        uiText = GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        uiText.text = score.ToString( "#,0" ); 
    }
}
