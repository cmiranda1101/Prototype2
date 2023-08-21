using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float inputDelay;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) & inputDelay < 0)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            inputDelay = 0.5f;
        }
        inputDelay -= Time.deltaTime;
    }
}
