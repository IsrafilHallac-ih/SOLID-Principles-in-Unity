using UnityEngine;

public class HeavyTankEngine : TankEngine
{
    public override void StartEngine()
    {
        base.StartEngine();
        tankMovement.enabled = true;
        tankAim.enabled = true;
        tankFire.enabled = true;
    }

    public override void StopEngine()
    {
        base.StopEngine();
        tankMovement.enabled = false;
        tankAim.enabled = false;
        tankFire.enabled = false;
    }
}
