using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class frogNoLove : MonoBehaviour

{

    public GameObject frog;
    public GameObject heart;
    public GameObject frog2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnMouseDown()
    {
        frog.SetActive(false);
        heart.SetActive(false);
        frog2.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
