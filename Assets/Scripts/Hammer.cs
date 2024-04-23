using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SuperPupSystems.Helper;

public class Hammer : MonoBehaviour
{
    public string tagToDamage;
    public int damage = 10;
    void OnTriggerEnter(Collider _other)
    {
        Health health = _other.GetComponent<Health>();

        if (health && _other.tag == tagToDamage)
        {
            health.Damage(damage);
        }
    }
}
