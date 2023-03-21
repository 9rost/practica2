using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform target; // ������, ���� ����� ����������������� �����

     void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // ���� ����� ������������� � �������� ������������
        {
            other.transform.position = target.position; // ���������� ������ �� ������� ������� ������������
        }
    }




}
