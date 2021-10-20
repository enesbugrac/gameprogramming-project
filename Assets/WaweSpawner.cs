using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class WaweSpawner : MonoBehaviour
{
    public Transform enemyPrefab;
    public Transform spawnPoint;
    public float timeBetweenWawes = 5f;
    private float countdown = 2f;
    private int waveIndex = 0;

    public Text waveCountdownText;

    void Update()
    {
        if(countdown <= 0f)
        {
            StartCoroutine(SpawnWawe());
            countdown = timeBetweenWawes;
        }
        countdown -= Time.deltaTime;
        waveCountdownText.text = Mathf.Round(countdown).ToString();
    }

    IEnumerator SpawnWawe()
    {
        waveIndex++;
        for (int i = 0; i < waveIndex; i++)
        {
            SpawnEnemy();
            yield return new WaitForSeconds(0.5f);
        } 
    }
    void SpawnEnemy()
    {
        Instantiate(enemyPrefab,spawnPoint.position,spawnPoint.rotation);
    }


}
