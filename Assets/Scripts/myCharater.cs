using System.Runtime.InteropServices;
using Unity.VisualScripting;
using UnityEngine;

public class myCharater : MonoBehaviour
{
    public int HeaIth = 100;
    public float Timer = 1.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        HeaIth = HeaIth + 100;
    }

    // Update is called once per frame
    void Update()
    {
        Timer = Timer - Time.deltaTime;

        if (Timer <= 0)
        {
            Timer = 1.0f;
            HeaIth = HeaIth - 20;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            HeaIth = HeaIth + 2;
        }

        if (HeaIth <= 0)
        {
            Destroy(this.gameObject);
        }





    }



    






}

