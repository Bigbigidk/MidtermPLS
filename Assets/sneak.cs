using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sneak : MonoBehaviour
{

    Animator myAnim;

    // Start is called before the first frame update
    void Start()
    {
        myAnim = GetComponent<Animator>();
    }

    private void OnMouseDown()
    {
        //Destroy(this.gameObject);
        myAnim.SetBool("isClick", true);

    }

    private void OnMouseExit()
    {
        myAnim.SetBool("isClick", false);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
