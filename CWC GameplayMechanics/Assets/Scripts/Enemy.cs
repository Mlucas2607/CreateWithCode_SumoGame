using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [Header("Variables")]
    public float speed;
    private Rigidbody enemyRb;
    private GameObject player;
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }

    void Update()
    {
        if (transform.position.y < -10)
            Destroy(gameObject);

        Vector3 lookDir = (player.transform.position - transform.position).normalized;
        enemyRb.AddForce(lookDir * speed);
    }
}
