using UnityEngine;
using UnityEngine.UI;
public class Credits : MonoBehaviour
{
    public Text playerName;
    public Text HighScore;
    public void Start()
    {
        playerName.text = ReadInput.playerName.ToUpper() + "!";
        HighScore.text = "HIGH SCORE: " + Score.HighScore;
    }
    public void Quit()
    {
        // exit the game for real play
        //Application.Quit();
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
