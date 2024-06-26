using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [Header("Health Values")]
    public float currentHealth;
    public float maxHealth;

    private void Start()
    {
        // Set object's current health to max health at the start of the game
        currentHealth = maxHealth;
    }

    // Function that can be called to take a certain amount of damage away from the current health
    public void TakeDamage(float amount, Pawn source)
    {
        currentHealth -= amount;
        Debug.Log($"{source.name} did {amount} damage to {gameObject.name}.");
        ClampingHealth();

        // Checks to see if our health is equal to or less than zero, if so calls the Die() function
        if (currentHealth <= 0)
        {
            Die(source);
        }
    }

    // Function that can be called to heal a certain amount of health
    public void Heal(float amount, Pawn source)
    {
        currentHealth += amount;
        Debug.Log($"{source.name} healed {amount} health to {gameObject.name}.");
        ClampingHealth();
    }

    // Function that will destroy the game object when called
    public void Die(Pawn source)
    {
        Destroy(gameObject);
    }

    // This function is going to be called after we adjust our currentHealth variable to ensure it is not below 0 or above the maxHealth variable value
    private void ClampingHealth()
    {
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);
    }
}
