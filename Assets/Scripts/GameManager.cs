using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System;

public class GameManager : MonoBehaviour
{
    static List<IRed> redObjects = new List<IRed>();
    static List<IGreen> greenObjects = new List<IGreen>();
    static List<IBlue> blueObjects = new List<IBlue>();
    [SerializeField]Color red;
    [SerializeField]Color blue;
    [SerializeField]Color green;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public static void RegisterRed(IRed red)
    {
        redObjects.Add(red);
    }
    public static void RegisterGreen(IGreen green)
    {
        greenObjects.Add(green);
    }
    public static void RegisterBlue(IBlue blue)
    {
        blueObjects.Add(blue);
    }
}
