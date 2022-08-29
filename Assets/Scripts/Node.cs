using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{/// <summary>
/// Each node on the grid will be an instance of this class, with some variables to evaluate and manipulate the node.
/// </summary>
   public Rect rect;
   public GUIStyle style;

    public Node(Vector2 position, float width, float height, GUIStyle defaultStyle)
    {
        rect = new Rect(position.x, position.y, width, height);
        style = defaultStyle;
    }

    public void Drag(Vector2 delta)//Moves the rect around based on the mouse's position.
    {
        rect.position += delta;
    }

    public void Draw()
    {
        GUI.Box(rect, "", style);
    }
    
    public void SetStyle(GUIStyle nodeStyle)//Changing the variable that dictates what image should be drawn on the map.
    {
        style = nodeStyle;
    }

    
}
