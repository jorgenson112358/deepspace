using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserGuns : MonoBehaviour
{
    public Transform firePointRight;
    public Transform firePointLeft;
    public GameObject bulletPrefab;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1")) {
            Shoot();
        }
    }

    void Shoot() {
        Instantiate(bulletPrefab, firePointLeft.position, firePointLeft.rotation);
        Instantiate(bulletPrefab, firePointRight.position, firePointRight.rotation);
    }
}
