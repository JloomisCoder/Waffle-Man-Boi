using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLogic : MonoBehaviour
{
    public GameObject bullet;
    GameObject player;
    float fireRate, lastFireTime;
    // Use this for initialization
    void Start()
    {
        fireRate = 0.5f;
        lastFireTime = Time.time;
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 deltaVector = player.transform.position - transform.position;
        float angle = Mathf.Atan2(deltaVector.y, deltaVector.x);
        transform.eulerAngles = new Vector3(0.0f, 0.0f, angle * 180.0f / Mathf.PI);

        float currentTime = Time.time;
        if (currentTime - lastFireTime >= fireRate)
        {
            //Fire a bullet
            GameObject newBullet = GameObject.Instantiate(bullet);
            projectile bulletScript = newBullet.GetComponent<projectile>();


            float shiftMagnitude = 0.5f;
            Vector3 positionShift = new Vector3(shiftMagnitude * Mathf.Cos(angle), shiftMagnitude * Mathf.Sin(angle), 0.0f);
            newBullet.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z) + positionShift;

            bulletScript.direction = angle * 180.0f / Mathf.PI;
            bulletScript.velocityMagnitude = 0.1f;
            bulletScript.calculateVelocity();
            lastFireTime = currentTime;
        }
    }
}
