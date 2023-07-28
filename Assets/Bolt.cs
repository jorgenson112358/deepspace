using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bolt : MonoBehaviour
{
    public float speed = 1f;
    public Rigidbody2D rb;
    public int damage = 4;

    private Vector3 shootDir;
    // Start is called before the first frame update
    void Start()
    {
        this.shootDir = transform.up;

        //Debug.Log(shootDir);
        //rb.AddForce(transform.forward * speed);
    }

    void Update() {
        //Debug.Log(forward);
        //Debug.Log(Time.deltaTime);
        //Debug.Log(speed);
        transform.position += shootDir * Time.deltaTime * speed;
        //Debug.Log(transform.position);
    }

    void OnTriggerEnter2D(Collider2D hitInfo) {
        Debug.Log(hitInfo.name);

        EnemyShip enemy = hitInfo.GetComponent<EnemyShip>();
        if (enemy != null) {
            enemy.TakeDamage(damage);
        }

        Destroy(gameObject);
    }
}
