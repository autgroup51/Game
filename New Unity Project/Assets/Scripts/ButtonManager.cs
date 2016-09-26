using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour {

    //Load the Scene according from the sceneIndex that I created
    public void PlayButton(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);

    }
    //Application will be quit once the button clicked
    public void ExitGameButton()
    {
        Application.Quit();
    }
}
