using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextField : MonoBehaviour
{
    public string stringToEdit = "Tell me a story";


    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnGUI()
    {
        // Make a text field that modifies stringToEdit.
        stringToEdit = GUI.TextField(new Rect(312, 100, 400, 200), stringToEdit, 250000);
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
