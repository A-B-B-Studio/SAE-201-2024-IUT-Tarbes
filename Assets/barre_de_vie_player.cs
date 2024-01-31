using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barre_de_vie_player : MonoBehaviour
{
    public Sprite etat0, etat1, etat2, etat3, etat4, etat5, etat6, etat7, etat8, etat9, etat10; 
    public playerbehaviour playerhealth;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (playerhealth.currentHealth <= playerhealth.MaxHealth*1 && playerhealth.currentHealth >= playerhealth.MaxHealth*0.80){
            GetComponent<SpriteRenderer>().sprite = etat0;
        }
        if (playerhealth.currentHealth < playerhealth.MaxHealth*0.80 && playerhealth.currentHealth >= playerhealth.MaxHealth*0.75){
            GetComponent<SpriteRenderer>().sprite = etat1;
        }
        if (playerhealth.currentHealth < playerhealth.MaxHealth*0.75 && playerhealth.currentHealth >= playerhealth.MaxHealth*0.70){
            GetComponent<SpriteRenderer>().sprite = etat2;
        }
        if (playerhealth.currentHealth < playerhealth.MaxHealth*0.70 && playerhealth.currentHealth >= playerhealth.MaxHealth*0.60){
            GetComponent<SpriteRenderer>().sprite = etat3;
        }
        if (playerhealth.currentHealth < playerhealth.MaxHealth*0.60 && playerhealth.currentHealth >= playerhealth.MaxHealth*0.50){
            GetComponent<SpriteRenderer>().sprite = etat4;
        }
        if (playerhealth.currentHealth < playerhealth.MaxHealth*0.50 && playerhealth.currentHealth >= playerhealth.MaxHealth*0.40){
            GetComponent<SpriteRenderer>().sprite = etat5;
        }
        if (playerhealth.currentHealth < playerhealth.MaxHealth*0.40 && playerhealth.currentHealth >= playerhealth.MaxHealth*0.30){
            GetComponent<SpriteRenderer>().sprite = etat6;
        }
        if (playerhealth.currentHealth < playerhealth.MaxHealth*0.30 && playerhealth.currentHealth >= playerhealth.MaxHealth*0.25){
            GetComponent<SpriteRenderer>().sprite = etat7;
        }
        if (playerhealth.currentHealth < playerhealth.MaxHealth*0.25 && playerhealth.currentHealth >= playerhealth.MaxHealth*0.20){
            GetComponent<SpriteRenderer>().sprite = etat8;
        }
        if (playerhealth.currentHealth < playerhealth.MaxHealth*0.20 && playerhealth.currentHealth >= playerhealth.MaxHealth*0.15){
            GetComponent<SpriteRenderer>().sprite = etat9;
        }
        if (playerhealth.currentHealth < playerhealth.MaxHealth*0.15 && playerhealth.currentHealth >= playerhealth.MaxHealth*0){
            GetComponent<SpriteRenderer>().sprite = etat10;
        }

    }
}
