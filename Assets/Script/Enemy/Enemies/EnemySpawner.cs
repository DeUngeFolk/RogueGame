using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject swarmerPrefab; // Enemy prefab to spawn

    [SerializeField]
    private float swarmerInterval = 3.5f; // spawn interval

    [SerializeField]
    private GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnEnemy(swarmerInterval, swarmerPrefab));
        
    }

    private IEnumerator spawnEnemy(float interval, GameObject enemy)
    {
        yield return new WaitForSeconds(interval);
        GameObject newEnemy =
            Instantiate(enemy,
            new Vector3(Random.Range(-5f, 5), Random.Range(-6f, 6f), -1),
            Quaternion.identity);
        

        StartCoroutine(spawnEnemy(interval, enemy));
    }
}
