using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyEnemy : MonoBehaviour
{

    public int health = 100;
    public int Damage = 20; 
    public Image heart;

    // Start is called before the first frame update
    void Start()
    {
        heart = GameObject.Find("Heart").GetComponent<Image>(); 
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.tag);
        switch (collision.tag)
        {
            // Coin tag, dicates what happens after player touches coins 
            case "Destroy":
                {
                    health -= Damage;
                    heart.fillAmount = (float) health / (float) 100;
                    // Destroys the coins
                    Destroy(gameObject);
                    break;
                }
        }
    }
}
