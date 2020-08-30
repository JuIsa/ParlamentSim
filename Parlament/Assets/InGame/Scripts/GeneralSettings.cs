using System.Collections;
using System.Collections.Generic;
using System.Security.Policy;
using UnityEngine;

[CreateAssetMenu(fileName = "GeneralSettings", menuName = "Settings/GeneralSettings")]
public class GeneralSettings : ScriptableObject
{
    public float charactersSpeedOfRotation;
    public float playerSpeed;
    public float playerSpeedOffice;
    public bool isMan;
}
