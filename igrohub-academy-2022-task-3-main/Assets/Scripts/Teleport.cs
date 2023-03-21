using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform target; // объект, куда будет телепортироваться игрок

     void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // если игрок соприкасается с объектом телепортации
        {
            other.transform.position = target.position; // перемещаем игрока на позицию объекта телепортации
        }
    }




}
