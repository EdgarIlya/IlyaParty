using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleDis : MonoBehaviour
{
    //Устанавливаем цену очков, которые получаем за сбор яблок
    public int price;

    void OnCollisionEnter2D(Collision2D collision)
    {
        //При соприкосновении с объектом "Pig" (свинка)
        if (collision.gameObject.name == "Pig")
        {
          //Насчитываем число очков, полученных за сбор яблок, и выводим это на экран (канвас, расположенный на сцене). После удаляем объект
          ApplePlayer.apple += price;
          GameObject.FindGameObjectWithTag("Pig").GetComponent<ApplePlayer>().TextApple.text = ApplePlayer.apple.ToString();
          Destroy(gameObject);
        }
        //Если яблоки попадут на невидимые барьеры за пределами экрана сцены, то яблоки будет уничтожены
        else if ((collision.gameObject.name == "TransparentVertical") || (collision.gameObject.name == "TransparentVertical1") || (collision.gameObject.name == "TransparentHorizontal") || (collision.gameObject.name == "TransparentHorizontal1"))
        {
            Destroy(gameObject);
        }
    }
}
