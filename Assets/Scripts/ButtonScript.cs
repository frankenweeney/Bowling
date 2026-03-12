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
    public void GoToLvlThree()
    {
        SceneManager.LoadScene("LevelThree");
    }
    public void GoToLvlFour()
    {
        SceneManager.LoadScene("LevelFour");
    }
    public void GoToLvlFive()
    {
        SceneManager.LoadScene("LevelFive");
    }
    public void ReturnToMenu()
    {
        SceneManager.LoadScene("AlleyScene");
    }
}
