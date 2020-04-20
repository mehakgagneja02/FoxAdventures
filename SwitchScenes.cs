using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SwitchScenes : MonoBehaviour
{
    public GameObject go;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene("Level2");
            SceneManager.MoveGameObjectToScene(go, SceneManager.GetSceneByName("Level2"));
        }
    }
}
