using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyEnemy : MonoBehaviour
{

    public int health = 100;
    public int Damage = 20; 
    public Image heart;
    public PlayerHP playerHP;

    // Start is called before the first frame update
    void Start()
    {
        heart = GameObject.Find("Heart").GetComponent<Image>();
        playerHP = GameObject.Find("GameController").GetComponent<PlayerHP>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.tag);
        switch (collision.tag)
        {
            // Coin tag, dicates what happens after player touches coins 
            case "Destroy":
                {
                    playerHP.LowerHP();
                    
                    Destroy(gameObject);
                    break;
                }
            case "Bullet":
                {
                    Destroy(gameObject);
                    break;
                }
            case "Player":
                {
                    playerHP.LowerHP();
                    break;
                }
        }
    }
}
