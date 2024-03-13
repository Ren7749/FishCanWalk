using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeliveryPoint1 : MonoBehaviour
{
    public DeliveryPoint1 deliveryPoint1;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Item1"))
        {
            deliveryPoint1.enabled = false;
        }
    }
}
