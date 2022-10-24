using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class frogFight : MonoBehaviour

{

    public GameObject frog;
    public GameObject frog2;
    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnMouseDown()
    {
        frog.SetActive(false);
        frog2.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
