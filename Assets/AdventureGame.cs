using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    
    //SerializeField makes var available in inspector.
    [SerializeField] Text textComponent;
    
    // Start is called before the first frame update
    void Start()
    {
        //.text sets the text field for the Text object.
        textComponent.text = ("This is text set from the script.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
