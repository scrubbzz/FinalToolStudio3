using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartScripts : MonoBehaviour
{/// <summary>
/// This holds the data for the objects we want to spawn in on the map, i.e the type of object, its position etc...
/// </summary>
    public int row, column;
    public string partName = "Empty";
    public GameObject part;
    public GUIStyle style;
}
