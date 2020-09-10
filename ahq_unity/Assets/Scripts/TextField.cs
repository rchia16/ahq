using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextField : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public string stringToEdit = "Tell me a story";

    void OnGUI()
    {
        // Make a text field that modifies stringToEdit.
        stringToEdit = GUI.TextField(new Rect(10, 10, 200, 20), stringToEdit, 25);
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
