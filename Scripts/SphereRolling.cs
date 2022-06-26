using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereRolling : MonoBehaviour
{

    public bool sphereFall = false;
    private AudioSource playerAudio;
    public AudioClip ballGround;
    public AudioClip ballRolling;
    private GameObject sphere;
    private Rigidbody rigid;
    private float volumn = 0.1f;
    private float speed;
    public float sphereFallTime = 0.0f;

    public AudioSource ballSoundSource;

    // Start is called before the first frame update
    void Start()
    {
        sphere = GameObject.Find("Sphere");
        playerAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (sphere.transform.position.y < -20)
        {
            //Destroy(sphere);
            ballSoundSource.Pause();
            sphereFall = true;
            sphereFallTime = Time.time;
        }
    }
    void FixedUpdate()
    {
        rigid = GetComponent<Rigidbody>();
        speed = rigid.velocity.magnitude;
    }
    void OnCollisionStay(Collision collision)
    {
        if (ballSoundSource.isPlaying == false && speed >= 0.1f && collision.gameObject.tag == "Ground")
        {
            ballSoundSource.Play();
        }
        else if (ballSoundSource.isPlaying == true && speed < 0.1f && collision.gameObject.tag == "Ground")
        {
            ballSoundSource.Pause();
        }
    }

    /*
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            playerAudio.PlayOneShot(ballRolling, 0.05f); 
        }
    }
    */

    private void OnCollisionEnter(Collision other)
    {
        
        if (other.gameObject.CompareTag("Ground")) {
            playerAudio.PlayOneShot(ballGround, volumn);
            volumn = 0f;
        }

        if (other.gameObject.CompareTag("Shape"))
        {
            playerAudio.PlayOneShot(ballGround, 0.01f);
        }
    }
}
