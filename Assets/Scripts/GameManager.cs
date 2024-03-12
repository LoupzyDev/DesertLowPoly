using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject greatPrefab;
    public GameObject badPrefab;

    public int badAmulet = 3;

    void Start() {
        SpawnPrefabRandomly();
        SpawnBadPrefabsRandomly(badAmulet);
    }

    void SpawnPrefabRandomly() {
        float randomX = Random.Range(68f, 135f);
        float randomZ = Random.Range(59f, 144f);

        Vector3 spawnPosition = new Vector3(randomX, -7f, randomZ);

        Instantiate(greatPrefab, spawnPosition, Quaternion.identity);
    }
    void SpawnBadPrefabsRandomly(int count) {
        for (int i = 0; i < count; i++) {
            float randomX = Random.Range(68f, 135f);
            float randomZ = Random.Range(59f, 144f);

            Vector3 spawnPosition = new Vector3(randomX, -7f, randomZ);

            Instantiate(badPrefab, spawnPosition, Quaternion.identity);
        }
    }

    public void Restart() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
