using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DropDownMenu : MonoBehaviour
{
    private float zoomDistance;
    public GameObject[] planets;
    
    public void zoomIntoPlanet(int val)
    {    
        Camera.main.transform.parent = null;
        zoomDistance = planets[val].transform.localScale.x * 2;
        Vector3 newPosition = planets[val].transform.position + new Vector3(0, 0, +zoomDistance);
        Camera.main.transform.position = newPosition;
        Camera.main.transform.LookAt(planets[val].transform);
        
    }

}
