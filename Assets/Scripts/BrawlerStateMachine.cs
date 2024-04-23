using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SuperPupSystems.StateMachine;

public class BrawlerStateMachine : SimpleStateMachine
{
    public ChaseState chaseState;
    public HammerTimeState hammerTimeState;
    void Awake()
    {
        states.Add(chaseState);
        states.Add(hammerTimeState);

        ChangeState(nameof(chaseState));
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
