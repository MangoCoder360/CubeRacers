using UnityEngine;
using UnityEngine.SceneManagement;

public class FallDetection : MonoBehaviour {
    public Transform player;
    void Update()
    {
        if (player.position.y < -1) {
            SceneManager.LoadScene (sceneName:"Start");
        }
    }
}
