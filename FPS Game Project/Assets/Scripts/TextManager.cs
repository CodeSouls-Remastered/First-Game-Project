using UnityEngine;
using UnityEngine.UI;

public class TextManager : MonoBehaviour
{
    // Saw a tutorial for this here: https://www.youtube.com/watch?v=YUcvy9PHeXs, and I editted some stuff.
    public static TextManager instance;

    [SerializeField]
    Text scoreText;

    [SerializeField]
    Text targetsLeftText;

    // [SerializeField]
    // Text eastereggText;
    
    int score = 0;
    int targets_left = 1;

    private void Awake() {
        instance = this;
    }

    void Start()
    {
        //highScore = PlayerPrefs.GetInt("highScore",0);
        scoreText.text = "Score: " + score.ToString();
        targetsLeftText.text = "Targets Left: " + targets_left.ToString();
    }

    public void AddPoint(){
        score += 20;
        targets_left --;
        scoreText.text = "Score: " + score.ToString();
        targetsLeftText.text = "Targets Left: " + targets_left.ToString();
        if (targets_left == 0){
            GameObject congrats = GameObject.Find("Level Complete");
            GameObject verticalCrosshair = GameObject.Find("Vertical");
            GameObject horizontalCrosshair = GameObject.Find("Horizontal");
            verticalCrosshair.GetComponent<Image>().enabled = false;
            horizontalCrosshair.GetComponent<Image>().enabled = false;
            congrats.GetComponent<Text>().text = "Level Complete";
        }
        // if (highScore < score){
        //     PlayerPrefs.SetInt("highScore", score);
        // } I plan on implemening a sifferent way to keep a high score later
    }
    
    public void DiplayCongrats(){
        GameObject eastereggText = GameObject.Find("Easter Egg Notification");
        eastereggText.GetComponent<Text>().text = "Easter Egg Found!";
        score += 50;
        scoreText.text = "Score: " + score.ToString();
    }
}
