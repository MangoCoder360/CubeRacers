using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonClickHandler2 : MonoBehaviour {
	public Button button;
	int highScore;
	public Text scoreText;

	void Start () {
		Button btn = button.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);

		highScore = PlayerPrefs.GetInt("highScore", 0);
		scoreText.text = "Infinite Mode Highscore: " + highScore.ToString("0");
	}

	void TaskOnClick(){
		 SceneManager.LoadScene (sceneName:"InfiniteMode");
	}
}