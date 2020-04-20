using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Destroy : MonoBehaviour
{
  
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            SceneManager.LoadScene("GameOver");

        }
        if (other.gameObject.CompareTag("eagle"))
        {
            SceneManager.LoadScene("GameOver");

        }
        if (other.gameObject.CompareTag("platform-longg"))
        {
            SceneManager.LoadScene("Win");

        }
    }

}
