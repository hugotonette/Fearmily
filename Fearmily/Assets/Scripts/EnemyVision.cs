using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyVision : MonoBehaviour
{
    GameObject player;
    Collider2D pl_col;
    int sanity_danos=0;

    // Start is called before the first frame update
    void Start()
    {
        //player = GameObject.Find("Player");
        //pl_col = player.GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D enemy)
    {
        sanity_danos++;
        Debug.Log("dano " + sanity_danos);
    }
}
