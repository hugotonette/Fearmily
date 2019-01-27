using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SafeZone : MonoBehaviour
{
    public GameObject SystemManager;
    private GameManager _manager;

    void Awake(){
        _manager = SystemManager.transform.GetComponent<GameManager>();

    }
     void OnTriggerEnter2D(Collider2D obj)
    { 
        if(obj.name == "Player"){
            Debug.Log("Entrou trigger");
            _manager.safezone(true);
        }
    }

    void OnTriggerExit2D(Collider2D obj){
        if(obj.name == "Player"){
            Debug.Log("Saiu trigger");
            _manager.safezone(false);
        }
    }
}
