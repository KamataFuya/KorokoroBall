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
        //���C���J������ݒ�
        mainCamera = Camera.main;
        //���C���J������L��������
        ActiveMainCamera();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //�֐�:���C���J������L����
    public void ActiveMainCamera()
    {
        subCamera1.gameObject.SetActive(false);
        subCamera2.gameObject.SetActive(false);
        mainCamera.gameObject.SetActive(true);
    }
    //�֐�:�T�u�J����1��L����
    public void ActiveSubCamera1()
    {
        subCamera1.gameObject.SetActive(true);
        subCamera2.gameObject.SetActive(false);
        mainCamera.gameObject.SetActive(false);
    }
    //�֐�:�T�u�J����2��L����
    public void ActiveSubCamera2()
    {
        subCamera1.gameObject.SetActive(false);
        subCamera2.gameObject.SetActive(true);
        mainCamera.gameObject.SetActive(false);
    }
}
