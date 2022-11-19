using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PickUp : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)

    {
        if (collision.tag == "Player")
        {
            Destroy(gameObject);
        }
        else if (collision.tag == "Player")
        {
            SceneManager.LoadScene("WinScreen");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)

    {
        if (collision.tag == "Player")
        {
            Destroy(gameObject);
        }
        else  if (collision.tag == "Player")
        {
                SceneManager.LoadScene("WinScreen");
        }
    }

}
