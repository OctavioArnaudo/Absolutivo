using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    void Update()
    {

		if (Input.GetKeyDown(KeyCode.Escape))
		{
			Application.Quit();
		}
		if (Input.GetKeyDown(KeyCode.Z))
		{
			SceneManager.LoadScene("SampleScene");
		}

    }
}
