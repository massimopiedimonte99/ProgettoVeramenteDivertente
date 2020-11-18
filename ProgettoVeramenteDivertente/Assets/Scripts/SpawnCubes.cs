using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCubes : MonoBehaviour
{
    [SerializeField] GameObject cube;

    private int cubeIdx = 0;
    private Color[] colors = { Color.red, Color.yellow, Color.white, Color.cyan, Color.blue };

    float spawnTime = 1f;

    void Start()
    {
        InvokeRepeating("SpawnOneCube", 0f, 1f);
    }

    private void SpawnOneCube()
    {
        float posX = Random.Range(-8f, 6f);
        float posZ = Random.Range(-3f, 3f);

        GameObject cubeObj = Instantiate(cube, new Vector3(posX, 10f, posZ), Quaternion.identity);
        cubeObj.name = "cube" + cubeIdx;
        cubeObj.GetComponent<Renderer>().material.color = colors[Random.Range(0, 5)];
        cubeObj.transform.localScale = new Vector3(Random.Range(1, 3), Random.Range(1, 3), Random.Range(1, 3));
        cubeIdx++;
    }

    void Update()
    {
    }
}
