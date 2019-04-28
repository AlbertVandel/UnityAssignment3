using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Vehicles.Aeroplane;
using DG.Tweening;

    public class PowerUpScript : MonoBehaviour
    {
        public AeroplaneController airCraft;
        public Text textArea;
        public AudioSource sound;
        public float stopTimer;
        private int power = 0;
        private bool triggered = false;
        private bool start = false;

        // Start is called before the first frame update
        void Start()
        {
            start = true;
            StartCoroutine(WaitStart());
        }

        // Update is called once per frame
        void Update()
        {

        }

        void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag == "PowerUp")
            {
                other.gameObject.SetActive(false);
                power++;
                textArea.DOText(power.ToString(), 1,true, ScrambleMode.Numerals);
                //textArea.text = power.ToString();
                sound.Play();
                airCraft.Reset();
                triggered = true;
                StartCoroutine(Wait());
            }
        }

        IEnumerator Wait()
        {
            if (power >= 1 && triggered)
            {
                yield return new WaitForSeconds(stopTimer);
                power--;
                textArea.text = power.ToString();
                triggered = false;
                if (power == 0)
                {
                    airCraft.Immobilize();
                }
            }
        }
        IEnumerator WaitStart()
        {
            if (power == 0 && start)
            {
                yield return new WaitForSeconds(stopTimer);
                textArea.text = power.ToString();
                start = false;
                if (power == 0)
                {
                    airCraft.Immobilize();
                }
            }
        }
}

