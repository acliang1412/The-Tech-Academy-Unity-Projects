using UnityEngine;

public class RotateAround : MonoBehaviour
{
    public Transform target;
    public int speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if(target == null)
        {
            target = this.gameObject.transform;
            Debug.Log("RotateAround: No target assigned, using self as target.");
        }
    }

    // Update is called once per frame
    void LateUpdate()
    {
     //rotate takes three arguments, first is the vector to rotate around, second is the angle to rotate in degrees, and third is the space to rotate in (world or self)
        transform.RotateAround(target.position, Vector3.up, speed * Time.deltaTime);
    }
}
