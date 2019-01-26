using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
    public int sanity = 100;
    public bool vivo = true;
    public bool win = false;
    public Collider2D safe_space;
    public Slider sanity_bar;
    // Start is called before the first frame update

    void Start()
    {
    }

    private void Update()
    {
        sanity_bar.value = sanity;
    }
}
