using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SummonMagicBall : MonoBehaviour
{
    public GameObject spellPrefab;
    public Transform firePoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ShootPrefab()
    {
        GameObject spell = Instantiate(spellPrefab, firePoint.position, transform.rotation);
        //spell.GetComponent<MagicBall>().target = this.GetComponentInParent<MageStateMachine>().chaseState.target;
    }
}
