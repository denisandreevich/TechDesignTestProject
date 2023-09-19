using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class music_player : MonoBehaviour
{
    public AudioSource audioSource;

    private void Start()
    {
        // Получаем ссылку на компонент AudioSource
        audioSource = GetComponent<AudioSource>();
    }

    private void OnMouseDown()
    {
        // Проверяем, нажата ли правая кнопка мыши
        if (Input.GetMouseButtonDown(0))
        {
            // Проверяем, играет ли аудиофайл
            if (!audioSource.isPlaying)
            {
                // Если аудиофайл не играет, включаем его
                audioSource.Play();
            }
            else
            {
                // Если аудиофайл играет, останавливаем его
                audioSource.Stop();
            }
        }
    }
}

