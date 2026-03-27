using UnityEngine;

public class Platform : MonoBehaviour
{
    int valueToPrint = 3;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string stringFromOutside = FindObjectOfType<Cube>().PrintingFromOutside(valueToPrint);
        Debug.Log(stringFromOutside);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
