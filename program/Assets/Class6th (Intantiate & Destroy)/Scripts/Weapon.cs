using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    [SerializeField] protected Vector3 rotation;
    [SerializeField] protected Vector3 direction;

    public abstract void Attack();

    public void Start()
    {
        transform.position = direction;
        transform.rotation = Quaternion.Euler(rotation);
    }
}