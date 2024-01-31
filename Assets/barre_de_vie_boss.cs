using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barre_de_vie_orgre : MonoBehaviour
{
    public Sprite etat0, etat1, etat2, etat3, etat4, etat5, etat6, etat7, etat8, etat9, etat10;
    public Boss orgrehealth;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (orgrehealth.currentHealth <= orgrehealth.MaxHealth*1 && orgrehealth.currentHealth >= orgrehealth.MaxHealth*0.80){
            GetComponent<SpriteRenderer>().sprite = etat0;
        }
        if (orgrehealth.currentHealth < orgrehealth.MaxHealth*0.80 && orgrehealth.currentHealth >= orgrehealth.MaxHealth*0.75){
            GetComponent<SpriteRenderer>().sprite = etat1;
        }
        if (orgrehealth.currentHealth < orgrehealth.MaxHealth*0.75 && orgrehealth.currentHealth >= orgrehealth.MaxHealth*0.70){
            GetComponent<SpriteRenderer>().sprite = etat2;
        }
        if (orgrehealth.currentHealth < orgrehealth.MaxHealth*0.70 && orgrehealth.currentHealth >= orgrehealth.MaxHealth*0.60){
            GetComponent<SpriteRenderer>().sprite = etat3;
        }
        if (orgrehealth.currentHealth < orgrehealth.MaxHealth*0.60 && orgrehealth.currentHealth >= orgrehealth.MaxHealth*0.50){
            GetComponent<SpriteRenderer>().sprite = etat4;
        }
        if (orgrehealth.currentHealth < orgrehealth.MaxHealth*0.50 && orgrehealth.currentHealth >= orgrehealth.MaxHealth*0.40){
            GetComponent<SpriteRenderer>().sprite = etat5;
        }
        if (orgrehealth.currentHealth < orgrehealth.MaxHealth*0.40 && orgrehealth.currentHealth >= orgrehealth.MaxHealth*0.30){
            GetComponent<SpriteRenderer>().sprite = etat6;
        }
        if (orgrehealth.currentHealth < orgrehealth.MaxHealth*0.30 && orgrehealth.currentHealth >= orgrehealth.MaxHealth*0.25){
            GetComponent<SpriteRenderer>().sprite = etat7;
        }
        if (orgrehealth.currentHealth < orgrehealth.MaxHealth*0.25 && orgrehealth.currentHealth >= orgrehealth.MaxHealth*0.20){
            GetComponent<SpriteRenderer>().sprite = etat8;
        }
        if (orgrehealth.currentHealth < orgrehealth.MaxHealth*0.20 && orgrehealth.currentHealth >= orgrehealth.MaxHealth*0.15){
            GetComponent<SpriteRenderer>().sprite = etat9;
        }
        if (orgrehealth.currentHealth < orgrehealth.MaxHealth*0.15 && orgrehealth.currentHealth >= orgrehealth.MaxHealth*0){
            GetComponent<SpriteRenderer>().sprite = etat10;
        }

    }
}