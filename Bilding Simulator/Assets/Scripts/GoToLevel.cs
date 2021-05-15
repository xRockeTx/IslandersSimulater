using UnityEngine;

public class GoToLevel : MonoBehaviour
{
    [SerializeField] private BuildScr buildScr;
    [SerializeField] private int[] costNextLevel; // Массив чисел , нужного количества очков
    private int levelIndex=0; // Уровень
    public void GoToNextLevel() // Вызывается через кнопку
    {
        if (BuildScr.allPoint >= costNextLevel[levelIndex]) // Если количество очков >= нужное количество для этого уровня
        {
            buildScr.DestroyChild(); // Метод в скрипте BuildScr , удаляет все дочерные объекты
            levelIndex++; // Переход на след уровень 
        }
    }
}
