using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnPlayer : MonoBehaviour
{
    public PlayerControl playerControl;

    public bool OnHit;

    public GameObject spawnPoint;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Obtacle"))
        {
            OnHit = true;
            Respawn();
            playerControl.enabled = false;
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
            playerControl.enabled = true;
        }
    }
}