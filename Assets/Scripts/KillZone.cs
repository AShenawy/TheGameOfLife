using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This script will destroy any game object tagged with "weight" that touches the Kill Collider.

public class KillZone : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Weight") || collision.CompareTag("Balance"))
        {
            Destroy(collision.gameObject);
        }
    }
}
