using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] ball = new GameObject[1];
    [SerializeField] private float frequency = 3f;
    [SerializeField] private Transform[] spawnPoints = new Transform[1];

    IEnumerator Spawner()
    {
        while (true)
        {
            int randValue = Random.Range(0, spawnPoints.Length);
            Instantiate(ball[0], spawnPoints[randValue].transform.position, Quaternion.identity);
            yield return new WaitForSeconds(frequency);
        }
    }
}
