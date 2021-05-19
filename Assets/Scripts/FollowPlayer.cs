using UnityEngine;

public class FollowPlayer : MonoBehaviour {
    public Transform player;
    private Vector3 offset = new Vector3(0,5,-5);
    void Update()
    {
        transform.position = player.position + offset;
    }
}
