using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class DoorOpeningScene1 : MonoBehaviour
{
    public GameObject Door;
    public GameObject BlackCanvas;
    public AudioSource Birds;
    public AudioSource DoorSound;

    private void Awake()
    {
        BlackCanvas.SetActive(false);
    }

    void Update()
    {
        if (Vector3.Distance(gameObject.transform.position, Door.transform.position) < 3 &&
            Input.GetKeyDown(KeyCode.T))
        {
            BlackCanvas.SetActive(true);
            Birds.Stop();
            DoorSound.Play();

            //Timer
            IEnumerator ExecuteAfterTime1(float time)
            {
                yield return new WaitForSeconds(time);

                SceneManager.LoadScene("Scene 2");
            }

            StartCoroutine(ExecuteAfterTime1(5));
        }
    }
}
