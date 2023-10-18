using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float sceneDelay = 2f;
    [SerializeField] ParticleSystem finishEffect;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            GetComponent<AudioSource>().Play();
            finishEffect.Play();
            Debug.Log("Finish Line Crossed!");
            this.gameObject.transform.localScale = new Vector3(0, 0, 0);
            Invoke("ChangeScene", sceneDelay);
        }
    }
   private void ChangeScene()
   {
        SceneManager.LoadScene(0);
   } 
}