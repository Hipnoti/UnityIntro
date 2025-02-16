using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public string sceneToLoad;
    public void LoadGameScene()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}