using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeliveryPoint3 : MonoBehaviour
{
    public DeliveryPoint3 deliveryPoint3;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Item3"))
        {
            this.gameObject.SetActive(false);
        }
    }
}
