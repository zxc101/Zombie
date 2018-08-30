using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour {
    
    private WeaponUse weapon;
    private AudioSource audioSource;
    private float nextShootTime;
    private float shootDistance;

    void Start()
    {
        weapon = GetComponent<WeaponUse>();
        weapon.Tracer = GetComponent<LineRenderer>();
        audioSource = GetComponent<AudioSource>();
        shootDistance = weapon.ShootDistance;
    }

    public void Shoot()
    {
        if (CanShoot())
        {
            Ray ray = new Ray(weapon.FireParticle.transform.position, weapon.FireParticle.transform.forward);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, shootDistance))
            {
                Debug.Log(hit.transform.tag);
                weapon.ShootDistance = hit.distance;
            }

            nextShootTime = Time.time + weapon.Interval;

            audioSource.Play();
            weapon.FireParticle.Emit(1);

            if (weapon.Tracer)
            {
                StartCoroutine("RenderTracer", ray.direction * weapon.ShootDistance);
            }
        }
    }

    public void SetAudioClip(AudioClip clip)
    {
        audioSource.clip = clip;
    }

    private bool CanShoot()
    {
        bool canShoot = true;

        if(Time.time < nextShootTime)
        {
            canShoot = false;
        }

        return canShoot;
    }

    private IEnumerator RenderTracer(Vector3 hitPoint)
    {
        weapon.Tracer.enabled = true;
        weapon.Tracer.SetPosition(0, weapon.FireParticle.transform.position);
        weapon.Tracer.SetPosition(1, weapon.FireParticle.transform.position + hitPoint);

        yield return null;
        weapon.Tracer.enabled = false;
    }
}
