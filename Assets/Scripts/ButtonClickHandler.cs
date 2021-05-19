using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonClickHandler : MonoBehaviour {
	public Button button;

	void Start () {
		Button btn = button.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}

	void TaskOnClick(){
		SceneManager.LoadScene (sceneName:"LevelMode");
		RenderSettings.fog = true;
		if (Application.platform == RuntimePlatform.Android)
        {
			RenderSettings.fog = false;
        }
	}
}