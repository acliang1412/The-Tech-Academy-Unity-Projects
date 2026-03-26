using UnityEngine;

public class Cube : MonoBehaviour
{
    int numberOfTimes = 5;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Debug.Log("If you press the up arrow you'll jump!");
        //Debug.Log("If you press the down arrow " + numberOfTimes + " you'll crouch!");

        //Debug.LogWarning("if you press space, nothing happens");
        //Debug.LogError("If you smash the keyboard nothing happens, you just cry");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            print("You pressed space");
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            print("You pressed Left");
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            print("You pressed right");
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            print("You pressed down");
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            print("You pressed up");
        }
    }
}
