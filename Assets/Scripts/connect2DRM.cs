using UnityEngine;
using UnityEngine.SceneManagement;

public class connect2DRM : MonoBehaviour
{
	int i = 0;
	void go()
	{
		SceneManager.LoadScene(sceneName: "Start"); //TODO - Fix licence checking
	}
    void Update()
    {
		i = i + 1;
		if (i > 200)
        {
			go();
        }
    }
}