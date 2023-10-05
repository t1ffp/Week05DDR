using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DetectCollision : MonoBehaviour
{
    public GameObject canvas;

    private void Start()
    {
        canvas.SetActive(false);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Wall"))
        {
        
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        if (other.gameObject.CompareTag("Goal"))
        {
            canvas.SetActive(true);

        }

        if (Input.GetKeyDown(KeyCode.R) || DDR.Pad.Start)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
