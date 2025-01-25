using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPlayerOnKeyPress : MonoBehaviour
{
    public Transform player;
    public Vector3 startPosition = new Vector3(0, 0 , 0);
    void Start()
    {
        
    }

    private void ResetToStart()
    {
        if (player != null)
        {
            player.position = startPosition;

            Rigidbody rb = player.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.velocity = Vector3.zero;
                rb.angularVelocity = Vector3.zero;
            }

            Debug.Log("Зареспавнился");
        }
    }

    private void RotatePlayer()
    {
        if (player != null)
        {
            player.rotation = Quaternion.Euler(0f, 0f, 0f);
            

            Rigidbody rb = player.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.velocity = Vector3.zero;
                rb.angularVelocity = Vector3.zero;
            }

            Debug.Log("Перевернулся");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            ResetToStart();
        }
        else if (Input.GetKeyDown(KeyCode.CapsLock))
        {
            RotatePlayer();
        }
    }
}
