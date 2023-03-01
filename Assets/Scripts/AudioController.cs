using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
public AudioClip musicClipOne;

public AudioClip musicClipTwo;

public AudioSource musicSource;

private Animator anim;

void Start() 
{
  anim = GetComponent<Animator>();
}

// Update is called once per frame
void Update()
{
    // play clip 1
    if (Input.GetKeyDown(KeyCode.W))
    {
      musicSource.clip = musicClipOne;
      musicSource.Play();
      anim.SetInteger("State", 1);
    }

    // stop clip 1
    if (Input.GetKeyUp(KeyCode.W))
    {
      musicSource.Stop();
      anim.SetInteger("State", 0);
    }

    // play clip 2
    if (Input.GetKeyDown(KeyCode.R))
    {
      musicSource.clip = musicClipTwo;
      musicSource.Play();
      anim.SetInteger("State", 2);
    }

    // stop clip 2
    if (Input.GetKeyUp(KeyCode.R))
    {
      musicSource.Stop();
      anim.SetInteger("State", 0);
    }

    if (Input.GetKeyDown(KeyCode.L))
    {
      musicSource.loop = true;
    }
    if (Input.GetKeyUp(KeyCode.L))
    {
      musicSource.loop = false;
    }
  }
  
}
