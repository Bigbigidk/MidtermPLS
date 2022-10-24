using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bread : MonoBehaviour

{

    public GameObject frog;
    public GameObject frogbread;
    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnMouseDown()
    {
        frog.SetActive(false);
        frogbread.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
