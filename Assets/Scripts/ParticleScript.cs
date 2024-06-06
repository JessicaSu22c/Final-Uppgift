using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleScript : MonoBehaviour
{
    [SerializeField] private float timeBeforeDeletion;

    private void Start()
    {
        StartCoroutine(DeleteAfterSeconds()); 
    }

    IEnumerator DeleteAfterSeconds()
    {
        yield return new WaitForSeconds(timeBeforeDeletion);

        Destroy(this.gameObject);
    }
}
