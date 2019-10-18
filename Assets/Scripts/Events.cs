using UnityEngine;


// Template for Events in game.
public class Events : ScriptableObject
{
    public string EventName;
    public string EventDescription;

    public Sprite sprite;

    public int Money; // For both cost and gain
}
