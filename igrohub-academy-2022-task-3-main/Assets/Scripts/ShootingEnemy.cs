using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingEnemy : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float fireInterval = 3f;
    public LayerMask collisionLayer;

    private Transform target;
    private bool canFire = true;

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        if (canFire)
        {
            StartCoroutine(Fire());
        }
    }

    IEnumerator Fire()
    {
        canFire = false;
        GameObject bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
        yield return new WaitForSeconds(fireInterval);
        canFire = true;
    }

    void OnTriggerEnter(Collider other)
    {
        if (collisionLayer == (collisionLayer | (1 << other.gameObject.layer)))
        {
            Destroy(other.gameObject);
        }
    }
}
