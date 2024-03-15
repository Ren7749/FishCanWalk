using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeliveryPoint2 : MonoBehaviour
{
    public DeliveryPoint2 deliveryPoint2;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Item2"))
        {
            this.gameObject.SetActive(false);
        }
    }
}
