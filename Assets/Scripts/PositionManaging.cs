using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionManaging : MonoBehaviour
{
    [SerializeField] private Transform leftBorder, rightBorder, leftBasket, rightBasket;
    public Camera Camera;
    void Awake()
    {
        Camera = Camera.main;
        leftBorder = Camera.transform;
        print(Camera.pixelHeight);
        print(Camera.pixelWidth);
    }

    
}
