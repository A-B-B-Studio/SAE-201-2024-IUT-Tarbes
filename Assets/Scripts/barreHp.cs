
using UnityEngine;
using UnityEngine.UI;

/*Tuto Unity Fr*/
public class barreHp : MonoBehaviour
{
    public Slider slider;

    public void SetMaxHealth(int sante)
    {
        slider.maxValue = sante;
        slider.value = sante;  
        
    }

    public void SetHealth(int sante)
    {
        slider.value = sante;
    }





}
