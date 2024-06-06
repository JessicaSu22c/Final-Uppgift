using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Third : MonoBehaviour
{
    [Header("Refrences")]
    public Transform Orientation;
    public Transform Player;
    public Transform PlayerObjekt;
    public Rigidbody rb;

    public float rotationSpeed;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void Update()
    {
        // rotate orientation
        Vector3 ViewDir = Player.position - new Vector3(transform.position.x, Player.position.y, transform.position.z);
        Orientation.forward = ViewDir.normalized;

        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 inputDir = Orientation.forward * verticalInput + Orientation.right * horizontalInput;

        if (inputDir != Vector3.zero)
            PlayerObjekt.forward = Vector3.Slerp(PlayerObjekt.forward, inputDir.normalized, Time.deltaTime * rotationSpeed);
    }
}