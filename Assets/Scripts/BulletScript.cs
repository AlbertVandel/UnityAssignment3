using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public GameObject gunpoint;
    public GameObject bullet;
    public float speed;
    public float destroyTimer;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject newBullet = Instantiate(bullet, gunpoint.transform.position, gunpoint.transform.rotation);
            rb = newBullet.GetComponent<Rigidbody>();
            rb.AddForce(transform.forward * speed);
            Destroy(newBullet, destroyTimer);
        }
    }

}
