using UnityEngine;

public class TankSelector : MonoBehaviour
{
    [SerializeField] TankEngine lightTankEngine;
    [SerializeField] TankEngine mediumTankEngine;
    [SerializeField] TankEngine heavyTankEngine;

    private void Start()
    {
        DisableAllTankEngine();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            DisableAllTankEngine();
          lightTankEngine.StartEngine();
        }
           
        else if (Input.GetKeyDown(KeyCode.M))
        {
            DisableAllTankEngine();
          mediumTankEngine.StartEngine();
        }
            
        else if (Input.GetKeyDown(KeyCode.H))
        {
            DisableAllTankEngine();
            heavyTankEngine.StartEngine();
        }
            
    }

    void DisableAllTankEngine()
    {
        lightTankEngine.StopEngine();
        mediumTankEngine.StopEngine();
        heavyTankEngine.StopEngine();
    }
}
