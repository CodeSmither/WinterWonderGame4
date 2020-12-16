using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class DestroySelf : MonoBehaviour
{
    public float time;

    void Start()
    {
        Destroy(gameObject, time);
    }

}
