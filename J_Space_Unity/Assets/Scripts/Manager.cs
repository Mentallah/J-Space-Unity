using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    public GameObject g_Chair;
    public Material[] m_Chair_Materials;
    public Slider s_RotateChair_Chair;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //g_Chair.transform.Rotate(0, 0, s_RotateChair_Chair.value);
        g_Chair.transform.localScale = new Vector3(s_RotateChair_Chair.value, s_RotateChair_Chair.value, s_RotateChair_Chair.value);
    }
    public void ChangeChairMaterial(int x)
    {
        g_Chair.GetComponent<Renderer>().material = m_Chair_Materials[x];
    }
}
