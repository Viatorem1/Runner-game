using UnityEngine;
using UnityEngine.UI;


public class DistanceBar : MonoBehaviour
{
    public Slider distanceBar;
    public float gametime;
    private bool stopBar;
    public GameObject Spawners;
    void Start()
    {
        
        stopBar = false;
        distanceBar.maxValue = gametime;
        distanceBar.value = gametime;
    }

    void Update()
    {

        float distance = gametime -Time.timeSinceLevelLoad ;

        if (distance <= 0)
        {
            stopBar = true;
            Spawners.SetActive(false);
        }
        if(stopBar == false)
        {
            distanceBar.value = distance;
        }
    }


}
