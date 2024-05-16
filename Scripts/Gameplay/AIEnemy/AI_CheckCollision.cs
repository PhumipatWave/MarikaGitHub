using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI_CheckCollision : MonoBehaviour
{
    public Transform player;

    private string detectionTag = "Player";
    public bool isPlayer;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(detectionTag))
        {
            Debug.Log("Player There");

            isPlayer = true;
            player = collision.gameObject.transform;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag(detectionTag))
        {
            Debug.Log("No Player");

            isPlayer = false;
            player = null;
        }
    }
}