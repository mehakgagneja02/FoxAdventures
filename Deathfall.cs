using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Deathfall : MonoBehaviour
{
    void Update()
    {
        if (gameObject.transform.position.y <= -5.25)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
