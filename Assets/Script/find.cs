using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class find : MonoBehaviour
{
    public static find instance;
    public bool Touch;
    public bool Tp_pea;
    public bool Tp;
    // Start is called before the first frame update

    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    void Start()
    {
        Touch = false;
        Tp_pea = false;
        Tp = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "tp")
        {
            Tp = true;
        }
        if (other.gameObject.tag == "tp_pea")
        {
            Tp_pea = true;
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "tp")
        {
            Tp = false;
        }
        if (other.gameObject.tag == "tp_pea")
        {
            Tp_pea = false;
        }

    }
}
