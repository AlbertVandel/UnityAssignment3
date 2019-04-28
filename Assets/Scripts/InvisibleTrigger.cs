using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InvisibleTrigger : MonoBehaviour
{
    public Text timer;
    public float time;
    // Start is called before the first frame update
    void Start()
    {
        timer.text = time.ToString();
        InvokeRepeating("CountDown", 1, 1);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "InvisibleTrigger")
        {
            time += 30f;
            Destroy(other);
        }
    }

    void CountDown()
    {
        time--;
        if (time >= 0)
        {
            timer.text = time.ToString();
        }
        if (time <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
