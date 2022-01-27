using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFocus : MonoBehaviour
{
    float zoomDistance;
    GameObject lasthit;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 10000))
            {
                zoomDistance = hit.transform.localScale.x * 2;

                Vector3 newPosition = hit.transform.position + new Vector3(0, 0, +zoomDistance);
                Camera.main.transform.position = newPosition;
                Camera.main.transform.LookAt(hit.transform.gameObject.transform);
                
                lasthit = hit.transform.GetChild(0).gameObject;
                lasthit.SetActive(true);
                StartCoroutine(hide());
            }

        }
           
        
    }
    
    IEnumerator hide()
    {
        yield return new WaitForSeconds(2f);
        if (lasthit != null && lasthit.active)
        {
            lasthit.SetActive(false);
        }
    }
}
