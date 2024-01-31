using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snakebehavior : MonoBehaviour
{
    public GameObject roche;
    public float timeToShoot = 1;
    public float randomRange = 0.5f;

    float chrono = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        chrono += Time.deltaTime;
        if (chrono > timeToShoot)
        {
            Instantiate(roche, transform.localPosition, Quaternion.identity);
            chrono = Random.Range(-randomRange, randomRange);
        }
    }
}
