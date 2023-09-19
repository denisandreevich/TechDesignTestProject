using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animation_activator : MonoBehaviour
{
    private Animator animator;

    private void Start()
    {
        // Получаем компонент Animator для управления анимацией
        animator = GetComponent<Animator>();
    }

    private void OnMouseOver()
    {
        // Проверяем, нажата ли правая кнопка мыши
        if (Input.GetMouseButtonDown(0))
        {
            // Включаем триггер анимации
            animator.SetTrigger("play");
        }
    }
}
