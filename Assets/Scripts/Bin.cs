using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Bin : MonoBehaviour
{

private bool somebool;
public string[] Tips =
    {
        "Спирайте водата , докато си миете зъбите или си сапунисвате ръцете, тъй като водата е ограничен ресурс ние трябва да я пестим възможно най-много.",
        "Гасете огньовете в гората и не изхърляйте фасове, както и други неща които могат да причинят горски пожар. Много дървета вече биват отсичани за индустрията няма нужда да губим още от източниците ни на кислород, също така чрез горските пожари много животински видове губят хабитатите си.",
        "Винаги изхвърляйте боклуците си в кош за отпадъци, по възможност такъв за разделни отпадъци, причината за това е ,че  една пластмасова бутилка например може да се разгражда до 450 години.",
        "Загасяйте лампите когато не сте в стаят, причината за това е ефекта , който пройзводството на електричество има върху нашата планета.",
        "По същата причина както и за лампите, изключвайте електроните уреди от контактите ако не ги ползвате.",
        "Засаждането на дърво ще помогне в дълго срочен план в борбата със горските пожари , като едно дърво след време не само ще фотосинтезира , но ще бъде и дом на различни животински видове.",
        "Използването на продукти изработени локално създава пазар за тези продукти , което намаля пазара за продуктите направени на други край на света и така предпазваме атмосферата от излишно замърсяване.",
        "Смяната на транспорт , емисиите от автомобилите са един от основните замърсители на природата, това може да бъде променено ако хората започнат да се предвиждат повече с градски транспорт, колело или пеша.",
        "Преработването на стари електронни уреди е от голяма полза , защото така стари матеряли ще бъдат използвани на ново и така поне малко ще забавим процеса на изчерпване на матерялите."


    };
public Text Message;
    public GameObject MessageTip;
    private Collider2D othercol;
    private float starttime;
    private bool SetDelay = false;
    
    private void Update()
    {
        Emptying();
    }


    public void OnTriggerEnter2D(Collider2D other)
    {
        somebool = true;
        othercol = other;
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        somebool = false;
        othercol = null;
    }

    void Emptying()
    {
        if (somebool)
        {
            
            if (othercol.CompareTag("Player"))
            {
                if(Input.GetKeyDown(KeyCode.E))
                {
                 if (othercol.GetComponent<PlayerCounter>().CanCount != 0 || othercol.GetComponent<PlayerCounter>().PaperCount != 0)
                  {
                     starttime = 3f;
                     MessageTip.SetActive(true);
                     int randomnumber = Random.Range(0, 10);
                     Message.text = Tips[randomnumber];
                     SetDelay = true;
                      othercol.GetComponent<PlayerCounter>().PaperCount=0;
                      othercol.GetComponent<PlayerCounter>().CanCount=0;
              
                  } 
                }
            }
        }
    }
    private void LateUpdate()
    {
        if (SetDelay)
        {
            if (starttime <= 0f)
            {
                MessageTip.SetActive(false);
                SetDelay = false;
            }
            else if(starttime > 0f)
            {
                starttime -= Time.deltaTime;
            }
        }

    }

}
