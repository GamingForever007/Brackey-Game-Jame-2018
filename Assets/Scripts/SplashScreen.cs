#region Splash Screen
//Made by Syed Shaazib Tanvir(GameMaker46)
#endregion

using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SplashScreen : MonoBehaviour {

    public Image logo;
    Color logoColor;
    public float lerpMultiplier = 0.02f;

	void Start () {
        logoColor = new Color(1, 1, 1, 0);
        logo.color = logoColor;
        StartCoroutine(GoToMM());
	}

    IEnumerator GoToMM()
    {
        yield return new WaitForSeconds(4f);
        SceneManager.LoadScene(1);
    }
	
	void Update () {
        logoColor = Color.Lerp(logoColor, new Color(1, 1, 1, 1), Time.time * lerpMultiplier);
        logo.color = logoColor;
        StartCoroutine(WaitFor3());
	}

    IEnumerator WaitFor3()
    {
        yield return new WaitForSeconds(3f);
    }
}
