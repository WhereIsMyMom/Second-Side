using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject PreFab;
    public GameObject PreFab2;
    public Transform spawnpoint;
    // Timer 
    public const float Timer = 2f;
    public float _currentTime = 2f;
    public const float Timer2 = 3f;
    public float _currentTime2 = 3f;
    private bool _canShoot = true;
    private bool _canShoot2 = true;

    private void Update()
    {
        BulletSpawnTimer();
    }

    // Counts down until the player can shoot agian 
    private void BulletSpawnTimer()
    {

        // If can't shoot count down till you can 
        _currentTime -= Time.deltaTime;
        _currentTime2 -= Time.deltaTime;

        // If the time is larnger than zero don't do anyhting 
        if (_currentTime > 0) { return; }
        else
        {
            SpawnBullet();
            _currentTime = Timer;
        }
        // If it's less than 0 reset the timer and allow player to shoot 
        if (_currentTime2 > 0) { return; }
        else
        {
            SpawnEnemy2();
            _currentTime = Timer;
        }


    }

    // Creates the bullet 
    private void SpawnBullet()
    {
        // If the player can't shoot or is clicking a diffrent key don't do anything 

        var bullet = Instantiate(PreFab, spawnpoint.position, Quaternion.identity);
        _canShoot = false;
        

    }
    private void SpawnEnemy2()
    {
        var bullet = Instantiate(PreFab2, spawnpoint.position, Quaternion.identity);
        _canShoot2 = false;
    }
}
