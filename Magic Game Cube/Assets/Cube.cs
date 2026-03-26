using UnityEngine;

public class Cube : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("If you press the up arrow you'lll jump!");
        Debug.Log("If you press the down arrow you'lll crouch!");

        Debug.LogWarning("if you press space, nothing happens");
        Debug.LogError("If you smash the keyboard nothing happens, you just cry");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
