using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float topBounds = 30.0f;
    public float lowerBounds = -10.0f;


    void Awake()
    {
        Time.timeScale = 1;
    }

     void Update()
     {
        if (transform.position.z > topBounds)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBounds)
        {
			GameManager manager = GameObject.Find("GameManager").GetComponent<GameManager>();
            manager.isGameOver = true;
			Debug.Log("Game Over!");
            Destroy(gameObject);
            Time.timeScale = 0;
        }
    }
}
