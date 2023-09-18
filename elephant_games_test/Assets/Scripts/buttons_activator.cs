using UnityEngine;
using UnityEngine.UI;

public class buttons_activator : MonoBehaviour
{
    public GameObject button; // ссылка на кнопку

    private void OnMouseDown()
    {
        button.SetActive(true); // делаем кнопку активной при нажатии на объект
    }
}
