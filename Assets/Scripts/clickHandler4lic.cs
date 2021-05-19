using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class clickHandler4lic : MonoBehaviour
{
	public Button button;
	public InputField serNum;

	void Start()
	{
		Button btn = button.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}

	void TaskOnClick()
	{
		if (serNum.text != "")
		{
			SceneManager.LoadScene(sceneName: "Start");
		}
	}
}