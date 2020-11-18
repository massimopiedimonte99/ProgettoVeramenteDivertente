using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestroy : MonoBehaviour
{
    [SerializeField] float timeBeforeDestroying = 5f;
    void Start()
    {
        Destroy(gameObject, timeBeforeDestroying);
    }
}
