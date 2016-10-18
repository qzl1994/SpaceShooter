using UnityEngine;

public class DestoryByContact : MonoBehaviour
{

    public GameObject explosion;
    public GameObject playerExplosion;

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Boundary" || other.tag == "Enemy")
        {
            return;
        }

        if(explosion != null)
        {
            Instantiate(explosion, transform.position, transform.rotation);
        }

        if(other.tag == "Player")
        {
            Instantiate(playerExplosion, other.transform.position, other.transform.rotation);
        }

        Destroy(other.gameObject);  //销毁碰撞物体
        Destroy(gameObject);        //销毁小行星
    }
}