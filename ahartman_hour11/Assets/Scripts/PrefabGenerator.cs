using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabGenerator : MonoBehaviour
{
    public GameObject prefab;
    public GameObject lamp;
    new Vector3 position;
    // Start is called before the first frame update
    void Start()
    {
        position = lamp.transform.position;
        int number = 0;
        while (number < 10)
        {
            position.x += 5;
            Instantiate(prefab, new Vector3(position.x, position.y, position.z), transform.rotation);
            number++;
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            Instantiate(prefab);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(prefab, transform.position, transform.rotation);
        }
    }
}
