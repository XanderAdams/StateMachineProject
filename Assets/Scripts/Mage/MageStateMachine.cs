using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SuperPupSystems.StateMachine;

public class MageStateMachine : SimpleStateMachine
{
    public IdleState idleState;
    public ChaseState chaseState;
    public ChargeState chargeState;
    public FireballState fireballState;
    void Awake()
    {
        states.Add(idleState);
        states.Add(chaseState);
        states.Add(chargeState);
        states.Add(fireballState);

        ChangeState(nameof(idleState));
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
