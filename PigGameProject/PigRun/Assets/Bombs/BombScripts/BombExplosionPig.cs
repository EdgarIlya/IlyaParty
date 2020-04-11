using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombExplosionPig : MonoBehaviour  

{
    public bool IsExplosive;
    private Animator anim;

    void Start()
    {
        //Подключаю компонент аниматор
        anim = GetComponent<Animator>();
    }

    //При соприкосновении
    void OnCollisionEnter2D(Collision2D collision)
    {
        //При соприкосновении с обЪектом "Pig" (свинкой) проиграем анимацию взрыва, затем перейдем к корутину DestroyExplosionPig
        if (collision.gameObject.name == "Pig")
        {
            //anim.SetBool("IsExplosive", true);
            StartCoroutine(DestroyExplosionPig());
            //Destroy(gameObject);
        }
        //Если бомба не столкнется со свинкой и попадет на невидимые барьеры за пределами экрана сцены, то бомба будет уничтожена
        else if ((collision.gameObject.name == "TransparentVertical") || (collision.gameObject.name == "TransparentVertical1") || (collision.gameObject.name == "TransparentHorizontal") || (collision.gameObject.name == "TransparentHorizontal1"))
        {
            Destroy(gameObject);
        }
        //Если бомба соприкоснется с объектом имеющим тег "Ground" (все имеющиеся платформы) или"
        //Если бомба соприкоснется с объектом имеющим тег "apple" (все имеющиеся яблоки) или"
        //Если бомба соприкоснется с объектом имеющим тег "Bomb" (все имеющиеся бомбы) "
        //То перейдём к корутину DestroyExplosionLifeEnd
        if ((collision.gameObject.tag == "Ground") || (collision.gameObject.tag == "apple") || (collision.gameObject.tag == "Bomb"))
        {
            StartCoroutine(DestroyExplosionLifeEnd());
        }
        //Если бомба не столкнется с землей, яблоками, другими бомбами и попадет на невидимые барьеры за пределами экрана сцены, то бомба будет уничтожена
        else if ((collision.gameObject.name == "TransparentVertical") || (collision.gameObject.name == "TransparentVertical1") || (collision.gameObject.name == "TransparentHorizontal") || (collision.gameObject.name == "TransparentHorizontal1"))
        {
            Destroy(gameObject);
        }

    }
    IEnumerator DestroyExplosionPig()
    {
        while (true)
        {
            //ждём 1 секунду, чтобы анимация взрыва проигралась и закончилась, затем удалим объект бомбу
            yield return new WaitForSeconds(0.2f);
            Destroy(gameObject);
        }
    }

    IEnumerator DestroyExplosionLifeEnd()
    {
        while (true)
        {
            //ждём 3 секунды, затем проигрываем анимацию взрыва. Ждём секунду, чтобы анимация взрыва проигралась и завершилась, удаляем объект.
            yield return new WaitForSeconds(3f);
            anim.SetBool("IsExplosive", true);
            yield return new WaitForSeconds(1f);
            Destroy(gameObject);
        }
    }
}
