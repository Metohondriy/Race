using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static System.Net.WebRequestMethods;

public class PlayerControler : MonoBehaviour
{
    public float speed = 20;
    public float horisontal;
    public float vertical;
    public float rotationSpeed = 100;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horisontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * speed * vertical);
        transform.Rotate(Vector3.up * Time.deltaTime * rotationSpeed * horisontal);
    }


    private void OnTriggerEnter(Collider trigger)
    {
        if (trigger.gameObject.CompareTag("Finish"))
        {
            Destroy(trigger.gameObject);
        }

        if (trigger.gameObject.CompareTag("Coins"))
        {
            Destroy(trigger.gameObject);
        }
    }
}

