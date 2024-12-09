using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject PreFab;
    public Transform spawnpoint;
    // Timer 
    private const float Timer = 2f;
    private float _currentTime = 2f;
    private bool _canShoot = true;

    private void Update()
    {
        BulletSpawnTimer();
    }

    // Counts down until the player can shoot agian 
    private void BulletSpawnTimer()
    {

        // If can't shoot count down till you can 
        _currentTime -= Time.deltaTime;

        // If the time is larnger than zero don't do anyhting 
        if (_currentTime > 0) { return; }
        else
        {
            SpawnBullet();
            _currentTime = Timer;
        }
        // If it's less than 0 reset the timer and allow player to shoot 
        
        
    }

    // Creates the bullet 
    private void SpawnBullet()
    {
        // If the player can't shoot or is clicking a diffrent key don't do anything 

        var bullet = Instantiate(PreFab, spawnpoint.position, Quaternion.identity);
        _canShoot = false;

        // Create a copy of 
        // Connect the bullet to a trash collector object 
        // Stop player from being able to shoot 
        

    }
}
