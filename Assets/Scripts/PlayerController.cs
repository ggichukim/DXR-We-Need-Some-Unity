using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    public float speed = 20f;
    private float horizontal, vertical;
    public float xMax = 13f;
    public float yMax = 7f;
    public GameObject explosionFx;

    private bool isControllable = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isControllable)
        {
            Move();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        // isControllable = false;
        // Instantiate(explosionFx, transform.position, Quaternion.identity);
        // FindObjectOfType<GameUI>().GameOver();
    }

    private void Move()
    {
        horizontal = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        vertical = Input.GetAxis("Vertical") * speed * Time.deltaTime;

        float xPos = transform.localPosition.x + horizontal;
        float clampedXPos = Mathf.Clamp(xPos, -xMax, +xMax);
        float yPos = transform.localPosition.y + vertical;
        float clampedYPos = Mathf.Clamp(yPos, -yMax, +yMax);

        transform.localPosition = new Vector3(clampedXPos, clampedYPos, transform.localPosition.z);
        
    }
}
