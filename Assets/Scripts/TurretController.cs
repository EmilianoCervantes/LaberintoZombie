using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretController : MonoBehaviour {

    public BulletController bala;
    public Transform puntoDisparo;
    public float tiempoDeEspera;
    private float contador;

	// Use this for initialization
	void Start () {
        contador = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if(contador == 0)
        {
            BulletController nuevaBala = Instantiate(bala, puntoDisparo.position, puntoDisparo.rotation) as BulletController;
            contador = tiempoDeEspera;
            Debug.Log("Disparo");
            Debug.Log(contador);
        }
        else
        {
            contador--;
        }
	}
}
