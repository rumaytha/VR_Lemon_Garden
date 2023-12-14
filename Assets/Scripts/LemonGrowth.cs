using UnityEngine;
using System.Collections;

public class LemonGrowth : MonoBehaviour
{
    // Flag to track whether the lemon is currently growing
    private bool isGrowing = false;

    // The original scale of the lemon
    private Vector3 originalScale;

    // Cooldown duration after the lemons have shrunk
    public float cooldownDuration = 10.0f;
    private bool isCooldown = false;

    // Start is called when the script is enabled
    private void OnEnable()
    {
        // Save the original scale of the lemon
        originalScale = transform.localScale;

        // Reset the scale of the lemon to its original size when the script is enabled
        transform.localScale = Vector3.zero;
    }

    // OnTriggerEnter is called when another collider enters the trigger zone
    private void OnTriggerEnter(Collider other)
    {
        // Check if the entering collider has the tag "HoseWater"
        if (other.CompareTag("HoseWater'") && !isCooldown)
        {
            // Check if the lemon is not already growing to avoid multiple triggers
            if (!isGrowing)
            {
                // Start the growth coroutine
                StartCoroutine(GrowLemon());
            }
            else
            {
                // Lemon is already growing, reset to original size and start cooldown
                ResetLemon();
            }
        }
    }

    // Coroutine to gradually grow the lemon
    private IEnumerator GrowLemon()
    {
        isGrowing = true;

        float elapsedTime = 0f;

        while (elapsedTime <= 100f)
        {
            transform.localScale = Vector3.Lerp(Vector3.zero, originalScale * 1.3f, elapsedTime);
            elapsedTime += Time.deltaTime;

            yield return null;
        }

        // Lemon is no longer growing
        isGrowing = false;

        // Set cooldown active
        isCooldown = true;

        // Start cooldown timer
        yield return new WaitForSeconds(cooldownDuration);

        // Cooldown is over, reset flag
        isCooldown = false;
    }

    // Function to reset the lemon to its original size
    private void ResetLemon()
    {
        StopAllCoroutines(); // Stop any ongoing growth coroutine
        transform.localScale = Vector3.zero; // Reset scale to zero
        isGrowing = false; // Lemon is no longer growing
        isCooldown = true; // Set cooldown active
        StartCoroutine(CooldownTimer()); // Start cooldown timer
    }

    // Coroutine for the cooldown timer
    private IEnumerator CooldownTimer()
    {
        yield return new WaitForSeconds(cooldownDuration);
        isCooldown = false; // Cooldown is over, reset flag
    }
}