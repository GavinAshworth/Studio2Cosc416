using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private float score = 0;
    [SerializeField] private TextMeshProUGUI scoreText;

    private FallTrigger[] pins;

    private void Start() {
    //had to hadd sortmode.none 
    pins = FindObjectsByType<FallTrigger>(FindObjectsInactive.Include, FindObjectsSortMode.None);

    foreach (FallTrigger pin in pins){
        pin.OnPinFall.AddListener(IncrementScore);
    }

    }

    private void IncrementScore(){
        score++;
        scoreText.text = $"Score: {score}";
    }

}
