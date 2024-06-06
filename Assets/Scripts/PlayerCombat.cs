using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    [SerializeField] private BaseWeapon meleWeapon;
    [SerializeField] private BaseWeapon hitScanWeapon;

    private BaseWeapon currentWeapon;

    private void Start()
    {
        currentWeapon = meleWeapon;
    }

    private void OnAttack()
    {
        currentWeapon.Fire();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1)) currentWeapon = meleWeapon;
        if (Input.GetKeyDown(KeyCode.Alpha2)) currentWeapon = hitScanWeapon;
        
        if (Input.GetMouseButtonDown(0)) OnAttack();
    }
}
