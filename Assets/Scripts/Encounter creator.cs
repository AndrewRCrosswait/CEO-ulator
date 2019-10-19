using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Encounter", menuName = "Encounter")]
public class EventMaker : ScriptableObject
{
    public new string name;
    public string description;


    public Sprite artwork;

    // Hidden values for change of industry rates
    //So we (James) dont forget what the last parts stand for here we go: 
    public int deltaMD;  //Mcdoogles
    public int deltaPol; //politics
    public int deltaWC;  //Wreakage company
    public int deltaMC;  //Mining company
    public int deltaRE;  //Real estate


    // Goodwill modifier
    public int deltaGW;
    // test comment
}
