using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowTrail : MonoBehaviour
{
    [SerializeField] ParticleSystem trailEffect;
    [SerializeField] AudioClip snowSound;
    private void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("Board Down!");
        GetComponent<AudioSource>().PlayOneShot(snowSound);
        trailEffect.Play();
    }
    private void OnCollisionExit2D(Collision2D other) {
        Debug.Log("Board Up!");
        GetComponent<AudioSource>().Stop();
        trailEffect.Stop();
    }
}
