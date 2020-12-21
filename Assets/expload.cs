using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class expload : MonoBehaviour
{
    [SerializeField] GameObject exploadBomb;
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Scene scene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(scene.name);
        }
   
   
        Debug.Log("boom!!!!!!!!!!!!!!11");
        GameObject hitMarker =(GameObject)Instantiate(exploadBomb, collision.transform.position, collision.transform.rotation);
        Destroy(collision.gameObject);
    }
}
