using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public int sanity = 100;
    public bool vivo = true;
    public bool win = false;
    public Collider2D safe_space;
    // Start is called before the first frame update

    void Start()
    {
        
    }

    //private void OnTriggerEnter2D(Collider2D safe_space)
    //{
    //    win = true;
    //}
}
