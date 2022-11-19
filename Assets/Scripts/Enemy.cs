using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
 
    void Start()
    {
        
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "Player")
        {

            SceneManager.LoadScene("LoseScreen");
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {

        if (collision.tag == "Player")
        {

            SceneManager.LoadScene("LoseScreen");
        }
    }
}
