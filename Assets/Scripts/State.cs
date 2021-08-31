using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Create scripable objects in the inspector
[CreateAssetMenu(menuName = "State")]

//Creating Class State inheariting from scriptable object
public class State : ScriptableObject
{
    /*Create a text area 
    Sertialize field makes variable avalible in inspector
    [TextArea(10,14)] (Minimum Size in Inspector, Amount of lines before scrolling)*/
    [TextArea(10, 14)] [SerializeField] string storyText;
    [SerializeField] State[] nextStates;
    public string GetStateStory()
    {
        return storyText;
    }

    public State[] GetNextState()
    {
        return nextStates;
    }
}
