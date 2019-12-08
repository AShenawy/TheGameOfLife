using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This script will destroy any game object tagged with "Weight" or "Balance" that touches the Kill Collider
// Used for scene clean up
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
