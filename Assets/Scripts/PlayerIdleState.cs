using UnityEngine;

public class PlayerIdleState : PlayerBaseState
{
    public override void EnterState(PlayerStateManager player)
    {
        Debug.Log("Entering Idle State");
    }
             
    public override void UpdateState(PlayerStateManager player)
    {
        player.SwitchState(player.RunState);
    }
                      
    public override void OnCollisionEnter(PlayerStateManager player)
    {

    }
           

           

}
