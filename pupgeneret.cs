using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pupgeneret : MonoBehaviour
{
    public GameObject pipe;
    public float height;
    public float maxTime = 1;
    private float timer = 0;


    // Start is called before the first frame update
    void Start()
    {
        GameObject newpire = Instantiate(pipe);
        newpire.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);

    }

    // Update is called once per frame
    void Update()
    {
        if (timer > maxTime)
        {


            GameObject newpire = Instantiate(pipe);
            newpire.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            Destroy(newpire, 8);
            timer = 0;


        }

        timer += Time.deltaTime;
    }



}
