using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePowerUpScript : MonoBehaviour
{
    private float movementVal = 100;
    private float speed = 50;
    private Vector3 startPos;
    private Vector3 endPos;
    float startTime;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        endPos = new Vector3(startPos.x + movementVal, startPos.y, startPos.z);
        startTime = Time.time;
        StartCoroutine(Move());
    }

    // Update is called once per frame
    void Update()
    {
     
    }

    IEnumerator Move()
    {
        while (true)
        {
            float distCovered = ((Time.time - startTime) * speed);
            yield return new WaitForSeconds(2);
            transform.Translate(new Vector3(Random.Range(-1, 1), Random.Range(-1, 1), Random.Range(-1, 1)));
            //if (transform.position.x < startPos.x + movementVal)
            //{
            //    float journeyLength1 = Vector3.Distance(startPos, endPos);
            //    transform.position = Vector3.Lerp(transform.position, endPos, (Time.time - startTime) * speed / journeyLength1);
            //}
            //else
            //{
            //    float journeyLength2 = Vector3.Distance(endPos, startPos);
            //    transform.position = Vector3.Lerp(transform.position, startPos, (Time.time - startTime) * speed / journeyLength2);
            //}
            yield return null;
        }
    }
}
