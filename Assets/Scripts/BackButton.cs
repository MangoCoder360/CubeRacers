using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class BackButton : MonoBehaviour {
    public Button button;
    void Start()
    {
        Button btn = button.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }
    void TaskOnClick()
    {
        Debug.Log("Button clicked");
        SceneManager.LoadScene(sceneName: "Start");
    }
}
