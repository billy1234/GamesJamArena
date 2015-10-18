using UnityEngine;
using System.Collections;
[System.Serializable]
public struct shakeCamera
{
    public bool active;
    public Camera myCam;
    public int frameDuration;
}

public class FireProjectile : MonoBehaviour 
{
    public GameObject projectile;
    public float fireSpeed;
    public Transform hand;
    protected bool canFire = true;
    public float fireRate =3f;
    public shakeCamera camShakeSettings;
    private Quaternion oldRoataion;
	protected BaseMove.AnimationEvent onFire;
    void Awake()
    {
        if(camShakeSettings.active)
        {
            oldRoataion = camShakeSettings.myCam.transform.localRotation;
        }
    }
    public void fire()
    {
        if(canFire)
        {
			if(onFire != null)
			{
				onFire();
			}
            GameObject bulletInstance = Instantiate(projectile, hand.position, transform.rotation) as GameObject;
            bulletInstance.GetComponent<ProjectileMove>().speed += fireSpeed;
            StartCoroutine(coolDown());
            StartCoroutine(shakeCam());
        }
    }
	
    private IEnumerator coolDown()
    {
        canFire = false;
        yield return new WaitForSeconds(fireRate);
        canFire = true;
        restoreCamera();
    }

    void shakeCamera()
    {
        if(!camShakeSettings.active)
            return;
        StopCoroutine("shakeCam()");
        StartCoroutine("shakeCam()");
            
    }

    private IEnumerator shakeCam()
    {

        for(int i =0; i < camShakeSettings.frameDuration; i++)
        {
            camShakeSettings.myCam.transform.Rotate(Random.insideUnitSphere);
            yield return 0;
        }
        restoreCamera();

    }

    void restoreCamera()
    {
        if(camShakeSettings.active)
        {
            camShakeSettings.myCam.transform.localRotation = oldRoataion;
        }
    }
}
