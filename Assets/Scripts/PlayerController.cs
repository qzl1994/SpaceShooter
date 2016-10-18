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
    public GameObject Shot;         //子弹预设体
    public Transform ShotSpawn;    //子弹出生位置
    public float fireRate;          //子弹发射率

    private float nextFire;

    void Update()
    {
        if(Input.GetButton("Fire1") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(Shot, ShotSpawn.position, ShotSpawn.rotation);
        }
    }

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
