using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int MaxHealth;
    private int currentHealth;

    private Vector3 InitialPosition;

    private void Start()
    {
        InitialPosition = transform.position;
        currentHealth = MaxHealth;
    }

    public void TakeDamage(int damageTaken)
    {
        currentHealth -= damageTaken;

        if (currentHealth <= 0)
        {
            Debug.Log("Estoy muerto");
            transform.position = InitialPosition;
            currentHealth = MaxHealth;
        }
        else
        {
            Debug.Log("He recibido daño, me quedan " + currentHealth + " puntos de vida.");
        }
    }
}