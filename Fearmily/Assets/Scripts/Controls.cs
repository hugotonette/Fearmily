using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour
{
    [Header("Movement")]
    public KeyCode MoveUp = KeyCode.W;
    public KeyCode MoveDown = KeyCode.S;
    public KeyCode MoveLeft = KeyCode.A;
    public KeyCode MoveRight = KeyCode.D;
    
    [Header("Alternative Movement")]
    public KeyCode MoveUpAlt = KeyCode.UpArrow;
    public KeyCode MoveDownAlt = KeyCode.DownArrow;
    public KeyCode MoveLeftAlt = KeyCode.LeftArrow;
    public KeyCode MoveRightAlt = KeyCode.RightArrow;


}
