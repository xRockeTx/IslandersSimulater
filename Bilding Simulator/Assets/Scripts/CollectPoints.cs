using UnityEngine;

public class CollectPoints : MonoBehaviour
{
    [SerializeField] private string[] increasePointTag, decreasePointTag; // Два массива с текстом для тегов
    [SerializeField] private int[] increasePoint, decreasePoint; // Два массива чисел для тегов
    private void OnTriggerEnter(Collider other)
    {
        CheckTag(other.tag, 1, increasePointTag, increasePoint);
        CheckTag(other.tag, 2, decreasePointTag, decreasePoint);
    }
    private void OnTriggerExit(Collider other)
    {
        CheckTag(other.tag,2 , increasePointTag, increasePoint);
        CheckTag(other.tag,1 , decreasePointTag, decreasePoint);
    }
    private void CheckTag(string otherTag,int option,string[] PointTag,int[] Point)
    {
        if (option == 1) // Проверка на вариант событий " + "
        {
            int index = 0; // Индекс проверяемого элемента
            foreach (string pointTag in PointTag) // Пересматривает полученный массив на наличие тега
            {
                if (otherTag == pointTag) // Если наш тег не входит то метод заканчивает свою работу и ничего не происходит
                {
                    BuildScr.bonusScore += Point[index]; // Изменяем получаемые очки в другом скрипте
                    break; // Если наш тег есть в массиве то эктренно завершаем оперицию foreach 
                }
                index++; // После проверки прошлого индекса делаем проверку следующего
            }
        }
        else if (option == 2) // Проверка на вариант событий " - "
        {
            int index = 0;
            foreach (string pointTag in PointTag)
            {
                if (otherTag == pointTag)
                {
                    BuildScr.bonusScore -= Point[index];
                    break;
                }
                index++;
            }
        }   
    }
}
