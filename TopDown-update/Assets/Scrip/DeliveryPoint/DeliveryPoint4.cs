using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeliveryPoint4 : MonoBehaviour
{
    public DeliveryPoint4 deliveryPoint4;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Item4"))
        {
            deliveryPoint4.enabled = false;
        }
    }
}
