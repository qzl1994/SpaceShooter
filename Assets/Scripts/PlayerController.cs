using UnityEngine;

public class PlayerController : MonoBehaviour {

    [System.Serializable]
    public class Boundary
    {
        public float xMax;
        public float xMin;
        public float zMax;
        public float zMin;
    }

    public float Speed;
    public Boundary boundray;

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        GetComponent<Rigidbody>().velocity = movement * Speed;
        GetComponent<Rigidbody>().position = new Vector3(
            Mathf.Clamp(GetComponent<Rigidbody>().position.x,boundray.xMin,boundray.xMax),
            0.0f,
            Mathf.Clamp(GetComponent<Rigidbody>().position.z,boundray.zMin,boundray.zMax)
            );
    }
}
