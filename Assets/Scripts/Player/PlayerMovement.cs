using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float force = 10f;
    public float jumpForce = 5f;
    public bool onGround = true;

    private float horizontalInput;
    private float verticalInput;

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * force * verticalInput);
        transform.Translate(Vector3.right * Time.deltaTime * force * horizontalInput);

        if (Input.GetKeyDown(KeyCode.Space) && onGround) {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            onGround = false;
        }
    }
}
