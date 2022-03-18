using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using  UnityEngine.SceneManagement;

public class Rock3 : MonoBehaviour {

    void OnCollisionEnter(Collision collision){
        // pregunto si en este objeto le pego o colisiono contra el objeto que tiene el tag de Carro
        if (collision.gameObject.tag=="Carro") {
	// En la consola de Unity aparece que perdí
            Debug.Log ("Game Over");
        }
    }
}
