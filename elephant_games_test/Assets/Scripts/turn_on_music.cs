using UnityEngine;

public class turn_on_music : MonoBehaviour
{
    public AudioSource music; // ссылка на музыку

    private void OnMouseDown()
    {
        music.Play(); // включаем музыку при нажатии на объект
    }
}
