using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionScript : MonoBehaviour
{
    public GameObject explosion;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);
        if (collision.gameObject.tag == "Enemy")
        {
            Debug.Log("shot enemy");
            GameObject newExplosion = Instantiate(explosion, collision.transform.position, collision.transform.rotation);
            collision.gameObject.SetActive(false);
        }
    }
}
