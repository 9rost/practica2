using UnityEngine;

public class Door : MonoBehaviour
{
    public GameObject object1; // объект1 для уничтожения
    public GameObject object2; // объект2 для уничтожения

    private void OnTriggerEnter(Collider other)
    {
        // Проверяем, что это игрок и что он коснулся объекта1
        if (other.CompareTag("Player"))
        {
            // Уничтожаем объект1 и объект2
            Destroy(object1);
            Destroy(object2);
        }
    }
}