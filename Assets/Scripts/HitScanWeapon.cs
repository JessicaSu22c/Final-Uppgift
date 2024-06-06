using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitScanWeapon : BaseWeapon
{
    [SerializeField] private Transform firePoint;
    [SerializeField] private ParticleSystem hitPoint;
    
    public override void Fire()
    {
        Debug.Log("UvU");
        Shoot();
    }

    private void Shoot()
    {
        Vector3 targetDir = Camera.main.transform.forward;

        bool didHit = Physics.Raycast(firePoint.position, targetDir, out RaycastHit hit);
        if (!didHit) return;

        Instantiate(hitPoint, hit.point, Quaternion.identity);

        bool foundDamageable = hit.collider.gameObject.TryGetComponent(out Damageable damageHit);
        if (!foundDamageable) return;

        damageHit.TakeDamage(damage);
    }
}
