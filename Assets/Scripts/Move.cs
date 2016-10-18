using UnityEngine;

public class Move : MonoBehaviour {

    public float Speed;

	void Start () {
        GetComponent<Rigidbody>().velocity = transform.forward * Speed;
	}
}
