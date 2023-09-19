using UnityEngine;
using UnityEngine.SceneManagement;

public class scene_changer: MonoBehaviour
{
    public int sceneNumber; // имя сцены, на которую нужно перейти

    public void Transition()
    {
        SceneManager.LoadScene(sceneNumber); // загружаем указанную сцену при нажатии
    }
}
