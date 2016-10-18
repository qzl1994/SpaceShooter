using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

    public GameObject[] Hazards;//小行星数组
    public Vector3 SpawnValues; //小行星生成位置
    public int HazardCount;     //每一波小行星生成数量
    public float StartWait;
    public float SpawnWait;
    public float WaveWait;

	void Start ()
    {
        //协程
        StartCoroutine(SpawnWave());
    }

    IEnumerator SpawnWave()
    {
        yield return new WaitForSeconds(StartWait);

        while(true)
        {
            for(int i=0;i<HazardCount;i++)
            {
                GameObject hazard = Hazards[Random.Range(0, Hazards.Length)];
                Vector3 spawnPosition = new Vector3(Random.Range(-SpawnValues.x, SpawnValues.x), SpawnValues.y, SpawnValues.z);
                Instantiate(hazard, spawnPosition, Quaternion.identity);

                yield return new WaitForSeconds(SpawnWait);
            }

            yield return new WaitForSeconds(WaveWait);
        }

    }
}
