using System.Collections;
using System.Collections.Generic; //These 2 were already here, I do not know what they do

using UnityEngine;

public class LemonTree : MonoBehaviour
{
    public Transform lemonParent; // Reference to the LemonParent GameObject
    public float growthTime = 30f;
    public ParticleSystem waterParticles;

    private float elapsedTime = 0f;
    private bool isBeingWatered = false;

    private void Update()
    {
        if (isBeingWatered)
        {
            GrowLemons();
        }
    }

    private void GrowLemons()
    {
        elapsedTime += Time.deltaTime;

        float t = Mathf.Clamp01(elapsedTime / growthTime);

        // Loop through each lemon and scale it based on the growth stage
        foreach (Transform lemon in lemonParent)
        {
            lemon.localScale = Vector3.Lerp(Vector3.zero, Vector3.one, t);
        }

        if (t >= 1.0f)
        {
            isBeingWatered = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("HoseWater"))
        {
            isBeingWatered = true;
            elapsedTime = 0f;
            waterParticles.Play();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("HoseWater"))
        {
            isBeingWatered = false;
            waterParticles.Stop();
        }
    }
}

