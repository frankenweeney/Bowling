using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    public void ResetScene()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScene.name);
    }
    public void GoToLvlTwo()
    {
        SceneManager.LoadScene("LevelTwo");
    }
    public void ReturnToMenu()
    {
        SceneManager.LoadScene("AlleyScene");
    }
}
