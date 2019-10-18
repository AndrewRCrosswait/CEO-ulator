using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="New Event", menuName ="Event")]
public class EventMaker : ScriptableObject
{
    public new string name;
    public string description;


    public Sprite artwork;

    // Hidden values for change of industry rates
    public int deltaMD;
    public int deltaPol;
    public int deltaWC;
    public int deltaMC;
    public int deltaRE;


    // Goodwill modifier
    public int deltaGW;
    // test comment
}