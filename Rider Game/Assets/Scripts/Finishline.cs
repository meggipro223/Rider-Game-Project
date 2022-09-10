using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finishline : MonoBehaviour {

    public GameObject img;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "car")
        {
            img.SetActive(true);
            Time.timeScale = 0;

        }
    }

    private void Update()
    {
        if (img.active == true && Input.GetMouseButtonDown(0))
        {
            Time.timeScale = 1;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }


}
