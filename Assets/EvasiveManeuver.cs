using UnityEngine;
using System.Collections;

public class EvasiveManeuver : MonoBehaviour {

    public Boundary boundary;
    public float tilt;              //倾斜
    public float dodge;             //躲闪
    public float smoothing;         //
    public Vector2 startWait;       //开始机动等待时间
    public Vector2 maneuverTime;    //机动时间
    public Vector2 maneuverWait;    //机动间隔时间

    private float currentSpeed;
    private float targetManeuver;

	void Start ()
    {
        currentSpeed = GetComponent<Rigidbody>().velocity.z;
        StartCoroutine(Evade());
	}


    IEnumerator Evade()
    {
        yield return new WaitForSeconds(Random.Range(startWait.x, startWait.y));

        while (true)
        {

        }
    }
}
