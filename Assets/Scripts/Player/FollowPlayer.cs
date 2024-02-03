using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    Transform player;
    public Vector3 offset;

    private void Start()
    {
        player = GameObject.Find("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset;
    }
}
