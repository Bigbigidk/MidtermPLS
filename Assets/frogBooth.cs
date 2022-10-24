using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class frogBooth : MonoBehaviour

{

    public GameObject plate;
    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnMouseDown()
    {
        plate.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
