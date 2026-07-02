using UnityEngine;

public class Cube : MonoBehaviour
{

    public Rigidbody2D myRigidBody2D;


    int numberOfTimes = 5;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //PrintingToOurConsole();
    }

    

    // Update is called once per frame
    void Update()
    {
        MovingOurCube();
        OutOfBoundsPrinter();
    }

    public string PrintingFromOutside(int value)
    {
        string printSomething = "The value you passed in was " + value; 
        return printSomething;
    }

    private void OutOfBoundsPrinter()
    {
        if (transform.position.x > 12.5f)
        {
            Debug.LogWarning("You went too far to the right!");
        }
        else if (transform.position.x < -12.5f)
        {
            Debug.LogWarning("You went too far to the left!");
        }
        else if (transform.position.y > 6.5f)
        {
            Debug.LogWarning("You went too far up!");
        }
        else if (transform.position.y < -6.5f)
        {
            Debug.LogWarning("You went too far down!");
        }
    }

    private void MovingOurCube()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            print("You pressed space");
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            myRigidBody2D.linearVelocity = new Vector2(-10f, 0f);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            myRigidBody2D.linearVelocity = new Vector2(10f, 0f);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            myRigidBody2D.linearVelocity = new Vector2(0f, -10f);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            myRigidBody2D.linearVelocity = new Vector2(0f, 10f);
        }
    }

    void PrintingToOurConsole()
    {
        Debug.Log("If you press the up arrow you'll jump!");
        Debug.Log("If you press the down arrow " + numberOfTimes + " you'll crouch!");

        Debug.LogWarning("if you press space, nothing happens");
        Debug.LogError("If you smash the keyboard nothing happens, you just cry");
    }
}
