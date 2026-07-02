using UnityEngine;

public class ball_move : MonoBehaviour

{
    public float speed;
    private Rigidbody rigb;

    void Start()
    {
        rigb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rigb.AddForce(movement * speed);

    }
}
