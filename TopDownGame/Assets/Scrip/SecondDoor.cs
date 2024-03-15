using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondDoor : MonoBehaviour
{
    public GameObject gameObjectToMove;

    public Collider Door;

    public DeliveryPoint1 deliveryPoint1;
    public DeliveryPoint2 deliveryPoint2;
    public DeliveryPoint3 deliveryPoint3;
    public DeliveryPoint4 deliveryPoint4;

    public void MoveGameObject()
    {
        Door.isTrigger = true;
        gameObjectToMove.transform.position = new Vector3(17, -3, -32);
    }

    public void Update()
    {
        if (deliveryPoint1.enabled == false)
        {
            if (deliveryPoint2.enabled == false)
            {
                if (deliveryPoint3.enabled == false)
                {
                    if (deliveryPoint4.enabled == false)
                    {
                        MoveGameObject();
                    }
                }
            }
        }
    }
}
