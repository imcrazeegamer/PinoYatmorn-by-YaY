using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class TeleportToNewArea : MonoBehaviour {
    public string LevelToLoad;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
            SceneManager.LoadScene(LevelToLoad);
        
    }
}
