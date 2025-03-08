using UnityEngine;

public class CubeScore : MonoBehaviour
{
    public int ScoreValue = 10; // Set this in the Inspector
    private bool hasScored = false; // Flag to check if the score has been updated

    void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<GET_FirstPersonController>() && !hasScored) // If the player enters and hasn’t scored yet
        {
            ScoreKeep.Instance.AddScore(ScoreValue);
            hasScored = true; // Prevent further scoring until exit
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<GET_FirstPersonController>()) // When player exits the trigger
        {
            hasScored = false; // Allow scoring again when the player re-enters
        }
    }
}