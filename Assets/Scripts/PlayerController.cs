using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject bulletPrefab;
    float speed = 30.0f;
    float delay = 0.3f;
    float timeElasped = 0.0f;

    // Update is called once per frame
    void Update()
    {
        // allow player to move side to side
        float input = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.forward * speed * Time.deltaTime * input, Space.World);

        Shoot();
    }

    // allow player to shoot bullets
    void Shoot()
    {
        timeElasped += Time.deltaTime;

        if (timeElasped > delay & Input.GetKeyDown(KeyCode.Space))
        {
            // On spacebar press, shoot bullet
            Vector3 bulletSpawnPos = new Vector3(0, transform.position.y + 1, transform.position.z);
            Instantiate(bulletPrefab, bulletSpawnPos, bulletPrefab.transform.rotation);
            timeElasped = 0;
        }
    }

    private void OnBecameInvisible()
    {
        float zRange = 24.0f;

        if (transform.position.z < 0)
            transform.position = new Vector3(transform.position.x, transform.position.y, zRange);

        else if (transform.position.z > 0)
            transform.position = new Vector3(transform.position.x, transform.position.y, -zRange);
    }
}
