using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyVision : MonoBehaviour
{
    GameObject player;
    Collider2D pl_col;
    PlayerStats pl_stats;
    public int sanity_damage = 50;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        pl_stats = player.GetComponent<PlayerStats>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D enemy)
    {
        pl_stats.sanity = pl_stats.sanity-sanity_damage;
        Debug.Log("dano " + sanity_damage);
    }
}
