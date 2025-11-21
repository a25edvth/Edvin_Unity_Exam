using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour

{
    public void PlayGame()
    
    {
        SceneManager.LoadSceneAsync("LevelScene");
    }

    public void QuitGame()

    {
        Application.Quit();
    }
}

