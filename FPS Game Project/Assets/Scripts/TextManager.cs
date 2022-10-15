using UnityEngine;
using UnityEngine.UI;

public class TextManager : MonoBehaviour
{
    // Saw a tutorial for this here: https://www.youtube.com/watch?v=YUcvy9PHeXs, and I editted some stuff.
    public static TextManager instance;

    [SerializeField]
    Text scoreText;

    [SerializeField]
    Text eastereggText;
    
    int score = 0;

    private void Awake() {
        instance = this;
    }

    void Start()
    {
        //highScore = PlayerPrefs.GetInt("highScore",0);
        scoreText.text = "Score: " + score.ToString();
    }

    public void AddPoint(){
        score += 20;
        scoreText.text = "Score: " + score.ToString();
        // if (highScore < score){
        //     PlayerPrefs.SetInt("highScore", score);
        // } I plan on implemening a sifferent way to keep a high score later
    }
    
    public void DiplayCongrats(){
        eastereggText.text = "Easter Egg Found!";
        score += 50;
        scoreText.text = "Score: " + score.ToString();
    }
}
