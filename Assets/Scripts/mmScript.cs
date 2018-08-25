#region Main Menu
//Made by Syed Shaazib Tanvir(GameMaker46)
#endregion

using UnityEngine;
using UnityEngine.SceneManagement;

public class mmScript : MonoBehaviour {

    public void PlayGame()
    {
        SceneManager.LoadScene(2);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
