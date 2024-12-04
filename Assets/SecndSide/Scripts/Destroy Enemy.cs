using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Timeline.TimelinePlaybackControls;

public class DestroyEnemy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.tag)
        {
            // Coin tag, dicates what happens after player touches coins 
            case "Destroy":
                {

                    // Destroys the coins
                    Destroy(collision.gameObject);
                    break;
                }
        }
    }
}
