using UnityEngine;

public class WeaponController : MonoBehaviour {

    public GameObject Shot;
    public Transform ShotSpawn;
    public float Delay;
    public float FireRate;

	void Start ()
    {
        InvokeRepeating("Fire", Delay, FireRate);
	}
    
    void Fire()
    {
        Instantiate(Shot, ShotSpawn.position, ShotSpawn.rotation);
        GetComponent<AudioSource>().Play();
    }
}
