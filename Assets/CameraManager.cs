using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public Camera mainCamera = default;
    public Camera subCamera1 = default;
    public Camera subCamera2 = default;

    // Start is called before the first frame update
    void Start()
    {
        //メインカメラを設定
        mainCamera = Camera.main;
        //メインカメラを有効化する
        ActiveMainCamera();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //関数:メインカメラを有効化
    public void ActiveMainCamera()
    {
        subCamera1.gameObject.SetActive(false);
        subCamera2.gameObject.SetActive(false);
        mainCamera.gameObject.SetActive(true);
    }
    //関数:サブカメラ1を有効化
    public void ActiveSubCamera1()
    {
        subCamera1.gameObject.SetActive(true);
        subCamera2.gameObject.SetActive(false);
        mainCamera.gameObject.SetActive(false);
    }
    //関数:サブカメラ2を有効化
    public void ActiveSubCamera2()
    {
        subCamera1.gameObject.SetActive(false);
        subCamera2.gameObject.SetActive(true);
        mainCamera.gameObject.SetActive(false);
    }
}
