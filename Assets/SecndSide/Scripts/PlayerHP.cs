using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHP : MonoBehaviour
{
    public int health = 100;
    public int Damage = 20;
    public Image heart;
    private MainMenu menu;

    // Start is called before the first frame update
    void Start()
    {
        menu = GetComponent<MainMenu>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LowerHP()
    {
        health -= Damage;
        heart.fillAmount = (float)health / (float)100;
        if (health <= 0)
        {
            menu.StartButton();
        }
    }
}
