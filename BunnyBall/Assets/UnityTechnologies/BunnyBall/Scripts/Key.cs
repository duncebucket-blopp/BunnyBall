using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    // This is a variable for the shockwave Prefab
    [SerializeField] GameObject shockwavePrefab;
    [SerializeField] GameManager gameManager;

    private void Start()
        //This function runs once at the beginning of the game
    {
        gameManager = FindObjectOfType<GameManager>();
    }
    private void OnTriggerEnter(Collider other)
    {

        //This function runs when we collide with the trigger
        if (other.CompareTag("Player")) 
        {
            // checks if we collide with something tagged as "Player"

            // gameover is true
            gameManager.gameOver = true;
            // creates a shockwave
            Instantiate(shockwavePrefab, transform.position, Quaternion.identity);
            // destroys this gameobject
            Destroy(gameObject, 0.1f);
        }
    }
}
