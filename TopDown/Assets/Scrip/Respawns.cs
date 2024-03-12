using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawns : MonoBehaviour
{
    //[SerializeField]
    //private Transform player;
    //[SerializeField]
    //private Transform respawn_point;

    public bool OnHit;

    //public GameObject playerPoint;

    public GameObject spawnPoint;

    private void OnTriggerEnter (Collider collision)
    {
        if(collision.CompareTag("Obtacle"))
        {
            OnHit = true;
            Respawn();
        }
    }

    public void Respawn()
    {
        transform.position = spawnPoint.transform.position;
    }

    private void OnTriggerExit(Collider collision)
    {
        if (collision.CompareTag("Obtacle"))
        {
            OnHit = false;
        }
    }
}

    //private void OnTriggerEnter(Collider player)
    //{
    //        player.transform.position = respawn_point.transform.position;
    //}
//}