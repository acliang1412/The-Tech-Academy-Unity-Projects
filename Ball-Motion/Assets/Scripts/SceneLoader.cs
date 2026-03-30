using UnityEngine;
using UnityEngine.SceneManagement; // Essential for switching scenes

public class SceneLoader : MonoBehaviour
{
    public void StartGame()
    {
        // Replace "MazeScene" with the exact name of your game scene
        SceneManager.LoadScene("MazeScene");
    }
}