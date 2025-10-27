using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionController : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        EnterMiniGame miniGameTrigger = collision.gameObject.GetComponent<EnterMiniGame>();

        if (miniGameTrigger != null)
        {
            SceneManager.LoadScene(miniGameTrigger.sceneName);
        }
    }
}
