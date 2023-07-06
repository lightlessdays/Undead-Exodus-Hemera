using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    [SerializeField] private GameObject MainCamera1;
    [SerializeField] private GameObject MainCamera2;
    [SerializeField] private GameObject MainCamera3;
    [SerializeField] private GameObject MainCamera4;
    [SerializeField] private GameObject TopCamera;
    [SerializeField] private GameObject ShoulderCamera;
    [SerializeField] private GameObject FirstPersonCamera;
    [SerializeField] private GameObject AimCanvas;
    private bool shoulderCameraActive=true;


    private void toggleAimCanvas()
    {
       // Debug.Log(AimCanvas.activeSelf);
        AimCanvas.SetActive(!AimCanvas.activeSelf);
    }
    private void Awake()
    {
        activateShoulderCamera();
    }

    private void FixedUpdate()
    {

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            activateMainCamera1();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            activateMainCamera2();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            activateMainCamera3();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            activateMainCamera4();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            activateTopCamera();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            activateShoulderCamera();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            activateFirstPersonCamera();
        }

        if (shoulderCameraActive && Input.GetKeyDown(KeyCode.M))
        {
            toggleAimCanvas();
        }
    }


    //functions
    public void activateMainCamera1()
    {
        AimCanvas.SetActive(false);
        MainCamera1.SetActive(true);
        MainCamera2.SetActive(false);
        MainCamera3.SetActive(false);
        MainCamera4.SetActive(false);
        TopCamera.SetActive(false);
        ShoulderCamera.SetActive(false);
        FirstPersonCamera.SetActive(false);
        shoulderCameraActive = false;
    }
    public void activateComputerCamera()
    {
        AimCanvas.SetActive(false);
        MainCamera1.SetActive(false);
        MainCamera2.SetActive(false);
        MainCamera3.SetActive(false);
        MainCamera4.SetActive(false);
        TopCamera.SetActive(false);
        ShoulderCamera.SetActive(false);
        FirstPersonCamera.SetActive(false);
        shoulderCameraActive = false;
    }

    public void activateMainCamera2()
    {
        AimCanvas.SetActive(false);
        MainCamera1.SetActive(false);
        MainCamera2.SetActive(true);
        MainCamera3.SetActive(false);
        MainCamera4.SetActive(false);
        TopCamera.SetActive(false);
        ShoulderCamera.SetActive(false);
        FirstPersonCamera.SetActive(false);
        shoulderCameraActive = false;
    }

    public void activateMainCamera3()
    {
        AimCanvas.SetActive(false);
        MainCamera1.SetActive(false);
        MainCamera2.SetActive(false);
        MainCamera3.SetActive(true);
        MainCamera4.SetActive(false);
        TopCamera.SetActive(false);
        ShoulderCamera.SetActive(false);
        FirstPersonCamera.SetActive(false);
        shoulderCameraActive = false;
    }

    public void activateMainCamera4()
    {
        AimCanvas.SetActive(false);
        MainCamera1.SetActive(false);
        MainCamera2.SetActive(false);
        MainCamera3.SetActive(false);
        MainCamera4.SetActive(true);
        TopCamera.SetActive(false);
        ShoulderCamera.SetActive(false);
        FirstPersonCamera.SetActive(false);
        shoulderCameraActive = false;
    }

    public void activateTopCamera()
    {
        AimCanvas.SetActive(false);
        MainCamera1.SetActive(false);
        MainCamera2.SetActive(false);
        MainCamera3.SetActive(false);
        MainCamera4.SetActive(false);
        TopCamera.SetActive(true);
        ShoulderCamera.SetActive(false);
        FirstPersonCamera.SetActive(false);
        shoulderCameraActive = false;
    }

    public void activateShoulderCamera()
    {
        AimCanvas.SetActive(true);
        MainCamera1.SetActive(false);
        MainCamera2.SetActive(false);
        MainCamera3.SetActive(false);
        MainCamera4.SetActive(false);
        TopCamera.SetActive(false);
        ShoulderCamera.SetActive(true);
        FirstPersonCamera.SetActive(false);
        shoulderCameraActive = true;


    }

    public void activateFirstPersonCamera()
    {
        AimCanvas.SetActive(false);
        MainCamera1.SetActive(false);
        MainCamera2.SetActive(false);
        MainCamera3.SetActive(false);
        MainCamera4.SetActive(false);
        TopCamera.SetActive(false);
        ShoulderCamera.SetActive(false);
        FirstPersonCamera.SetActive(true);
        shoulderCameraActive = false;
    }

}