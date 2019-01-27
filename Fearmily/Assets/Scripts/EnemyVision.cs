using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyVision : MonoBehaviour
{
    private GameObject player;
    private PlayerStats pl_stats;
    private int sanity_damage = 2;
    private int invicibility_timer = 10000;
    private bool invencibility = false;
    private Collider2D pl_col;
    private GameObject esporro;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        pl_stats = player.transform.GetComponent<PlayerStats>();
        pl_col = player.GetComponent<Collider2D>();
        //esporro = GameObject.Find("BrotherFound");
        //esporro.SetActive(true);


    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (invencibility == true)
        {
            //Debug.Log("invencivel");
            return;
        }
        pl_stats.sanity = pl_stats.sanity - sanity_damage;
        Debug.Log("dano " + sanity_damage);
        //Debug.Log("vida " + pl_stats.sanity);
        if (pl_stats.sanity <= 0)
        {
            pl_stats.vivo = false;
        }
        invencibility = true;
        Time.timeScale = 0f;
        //esporro.SetActive(true);
        StartCoroutine(Wait(2));
        //esporro.SetActive(false);
        Time.timeScale = 1f;

    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        invencibility = false;
        //Debug.Log("vencivel");
    }

    IEnumerator Wait(int tempo)
    {
        yield return new WaitForSeconds(tempo);
    }


}
