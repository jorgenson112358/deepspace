using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShip : MonoBehaviour
{
    public int Health = 30;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(int dmg) {
        Debug.Log("Enemy hit for damage!");
        Health -= dmg;
        if (Health <= 0) {
            Destroy(gameObject);
        }
    }
}
