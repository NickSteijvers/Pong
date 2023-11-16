using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    /// <summary>
    /// loads a scene based on the scene id that is inputted
    /// </summary>
    /// <param name="sceneId"></param>
    public void MoveToScene(int sceneId)
    {
        SceneManager.LoadScene(sceneId);
    }

    /// <summary>
    /// quits the entire application
    /// </summary>
    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
