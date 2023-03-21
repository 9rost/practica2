using UnityEngine;

public class Door : MonoBehaviour
{
    public GameObject object1; // ������1 ��� �����������
    public GameObject object2; // ������2 ��� �����������

    private void OnTriggerEnter(Collider other)
    {
        // ���������, ��� ��� ����� � ��� �� �������� �������1
        if (other.CompareTag("Player"))
        {
            // ���������� ������1 � ������2
            Destroy(object1);
            Destroy(object2);
        }
    }
}