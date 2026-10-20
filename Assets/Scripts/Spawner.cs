using UnityEngine;
using System.Collections; // Required for Coroutines

public class Spawner : MonoBehaviour
{
    public GameObject redPrefab;
    public GameObject bluePrefab;
    public GameObject greenPrefab;
    public int totalSpheres = 30;
    public float spawnDelay = 0.2f; // Time between each spawn

    private void Start()
    {
        // Start the timed spawning process
        StartCoroutine(SpawnSpheresOverTime());
    }

    private IEnumerator SpawnSpheresOverTime()
    {
        for (int i = 0; i < totalSpheres; i++)
        {
            int randomChoice = Random.Range(0, 3);
            GameObject selectedPrefab;

            if (randomChoice == 0) selectedPrefab = redPrefab;
            else if (randomChoice == 1) selectedPrefab = bluePrefab;
            else selectedPrefab = greenPrefab;

            Vector3 spawnOffset = Vector3.zero;

            if (Random.value > 0.5f)
            {
                spawnOffset = new Vector3(0f, 6f, Random.Range(-1.75f, 1.75f));
            }
            else
            {
                spawnOffset = new Vector3(Random.Range(-1.75f, 1.75f), 6f, -1.5f);
            }

            Vector3 spawnPos = transform.position + spawnOffset;
            Instantiate(selectedPrefab, spawnPos, Quaternion.identity);

            // Wait for the specified delay before looping again
            yield return new WaitForSeconds(spawnDelay);
        }
    }
}