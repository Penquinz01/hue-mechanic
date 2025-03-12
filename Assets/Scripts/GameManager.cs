using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System;
using UnityEngine.InputSystem;

public class GameManager : MonoBehaviour
{
    List<RedObjects> redObjects = new List<RedObjects>();
    List<GreenObjects> greenObjects = new List<GreenObjects>();
    List<BlueObjects> blueObjects = new List<BlueObjects>();
    [SerializeField]Color red;
    [SerializeField]Color blue;
    [SerializeField]Color green;
    public static GameManager Instance { get; private set; }
    private Hue control;
    private void Awake()
    {
        Instance = this;
        control = new Hue();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        control.Enable();
        control.HueMaps.Red.started += SetRed;
        control.HueMaps.Green.started += SetGreen;
        control.HueMaps.Blue.started += SetBlue;
    }

    private void SetBlue(InputAction.CallbackContext context)
    {
        Camera.main.backgroundColor = blue;
        if (blueObjects.Count > 0)
        {
            foreach (BlueObjects item in blueObjects)
            {
                item.gameObject.SetActive(false);
            }
        }
        if (greenObjects.Count > 0)
        {
            foreach (GreenObjects item in greenObjects)
            {
                item.gameObject.SetActive(true);
            }
        }
        if (greenObjects.Count > 0)
        {
            foreach (var item in redObjects)
            {
                item.gameObject.SetActive(true);
            }
        }
    }

       

    private void SetGreen(InputAction.CallbackContext context)
    {
        Camera.main.backgroundColor = green;
        if (blueObjects.Count > 0)
        {
            foreach (BlueObjects item in blueObjects)
            {
                item.gameObject.SetActive(true);
            }
        }
        if (greenObjects.Count > 0)
        {
            foreach (GreenObjects item in greenObjects)
            {
                item.gameObject.SetActive(false);
            }
        }
        if (greenObjects.Count > 0)
        {
            foreach (var item in redObjects)
            {
                item.gameObject.SetActive(true);
            }
        }
    }


    private void SetRed(InputAction.CallbackContext context)
    {
        Camera.main.backgroundColor = red;
        if (blueObjects.Count > 0)
        {
            foreach (BlueObjects item in blueObjects)
            {
                item.gameObject.SetActive(true);
            }
        }
        if (greenObjects.Count > 0)
        {
            foreach (GreenObjects item in greenObjects)
            {
                item.gameObject.SetActive(true);
            }
        }
        if (greenObjects.Count > 0)
        {
            foreach (var item in redObjects)
            {
                item.gameObject.SetActive(false);
            }
        }
    }


    // Update is called once per frame
    void Update()
    {

    }
    public  void RegisterRed(RedObjects red)
    {
        redObjects.Add(red);
    }
    public  void RegisterGreen(GreenObjects green)
    {
        greenObjects.Add(green);
    }
    public  void RegisterBlue(BlueObjects blue)
    {
        blueObjects.Add(blue);
    }
}
