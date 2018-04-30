using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPurpleOrb : MonoBehaviour {

    public GameObject Orbprefab;
    public float time;

    public Vector3 center;
    public Vector3 size;

    // Use this for initialization
    void Start()
    {
        time = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (time % 205 == 0)
            SpawnOrb();
        time += 1;
    }

    public void SpawnOrb()
    {
        Vector3 pos = center + new Vector3(Random.Range(-size.x / 2, size.x / 2), Random.Range(-size.y / 2, size.y / 2), Random.Range(-size.z / 2, size.z / 2));

        Instantiate(Orbprefab, pos, Quaternion.identity);
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = new Color(1, 0, 0, 0.5f);
        Gizmos.DrawCube(center, size);
    }
}
