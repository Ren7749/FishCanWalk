using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Navigate : MonoBehaviour
{
    [SerializeField]
    private Transform m_Target;
    public Transform LookAtTarget { get { return m_Target; } }

    [SerializeField]
    private Transform m_Spinner;
    public Transform Spinner { get { return m_Spinner; } }

    [SerializeField]
    private Transform m_Scaler;
    public Transform Scaler { get { return m_Spinner; } }

    public float Speed;

    public GameObject myObject;

    private void SetTarget(Transform target = null)
    {
        m_Target = target;
    }

    private void Start()
    {
        this.gameObject.SetActive(false);
    }

    private void Update()
    {
        if (LookAtTarget)
        {
            transform.LookAt(LookAtTarget);
        }
        if (Spinner)
        {
            Spinner.transform.Rotate(0,0,Speed * Time.deltaTime);
        }

    }


}
