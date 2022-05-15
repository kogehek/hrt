using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Cell : MonoBehaviour
{
    public Material def;
    public Material canAction;
    public int x;
    public int y;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Select() {
        gameObject.GetComponent<MeshRenderer> ().material = canAction;
    }

    public void  InitPoss(int x , int y) {
        this.x = x;
        this.y = y;
    }

}
