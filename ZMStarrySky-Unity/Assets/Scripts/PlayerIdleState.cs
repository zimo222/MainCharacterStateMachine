using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerIdleState : PlayerGroundedState
{
    public PlayerIdleState(Player _player, PlayerStateMachine _stateMachine, string _animBoolName) : base(_player, _stateMachine, _animBoolName)
    {

    }

    public override void Enter()
    {
        base.Enter();

        player.ZeroVelocity();
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void Update()
    {
        base.Update();
        //����� && (!player.IsWallDetected() || xInput != player.facingDir) ���֣���֤��ǽ�����ǽ�����ߣ�����ǽ����ǽ������
        if (xInput != 0 && !player.isBusy && (!player.IsWallDetected() || xInput != player.facingDir))
        {
            stateMachine.ChangeState(player.moveState);
        }
    }
}
