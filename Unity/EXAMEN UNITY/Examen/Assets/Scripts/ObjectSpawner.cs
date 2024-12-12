using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject objectToSpawn; // El objeto que caerá
    public Transform spawnPoint;    // Punto de generación
    public float spawnInterval = 2f; // Intervalo inicial de generación

    private float spawnTimer;

    void Update()
    {
        spawnTimer += Time.deltaTime;

        if (spawnTimer >= spawnInterval)
        {
            SpawnObject();
            spawnTimer = 0f;
        }
    }

    void SpawnObject()
    {
        Instantiate(objectToSpawn, spawnPoint.position, Quaternion.identity);
    }

    public void IncreaseSpawnSpeed()
    {
        spawnInterval = Mathf.Max(spawnInterval * 0.8f, 0.5f); // Reducir intervalo, mínimo 0.5s
    }
}
