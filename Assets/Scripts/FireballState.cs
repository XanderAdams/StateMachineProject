using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SuperPupSystems.StateMachine;
using Unity.VisualScripting;

[System.Serializable]
public class FireballState : SimpleState
{
    public GameObject staff;
    private GameObject gameObject;
    private Vector3 targetRotation;
    private Vector3 beginningRotation;
    private float time;
    public override void OnStart()
    {
        time = 0.0f;
        gameObject = stateMachine.gameObject;

        if (staff == false)
            return;
        
        staff.GetComponent<Animator>().Play("Charge");
    }

    public override void UpdateState(float _dt)
    {
        if (staff == false)
            return;
        
        time += _dt;

        if (time > 2.0f)
            stateMachine.ChangeState("ChaseState");
    }

    public override void OnExit()
    {
        if (staff == false)
            return;
        
        staff.GetComponent<Animator>().Play("Cast");
    }
}
