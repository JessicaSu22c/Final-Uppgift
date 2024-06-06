using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damageable : MonoBehaviour
{
    [SerializeField] float healthPoints;

    public void TakeDamage(float damage)
    {
        healthPoints = healthPoints - damage;
    }

    private void Update()
    {
        if (healthPoints <= 0f)
        {
            gameObject.SetActive(false);
        }
    }
}
