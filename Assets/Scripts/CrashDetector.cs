using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float sceneDelay = 0.75f;
    [SerializeField] ParticleSystem deathEffect;
    [SerializeField] AudioClip deathSound;
    bool hasCrashed = false;
    private void OnCollisionEnter2D(Collision2D other) {
        if(!hasCrashed) 
        {
        Debug.Log("CRUNCH!");
        hasCrashed = true;
        GetComponent<AudioSource>().PlayOneShot(deathSound);
        FindObjectOfType<PlayerController>().KillMovement();
        deathEffect.Play();
        Invoke("ChangeScene", sceneDelay);
        }
    }
       private void ChangeScene()
   {
        SceneManager.LoadScene(0);
   } 
    void Update()
    {
        
    }
}