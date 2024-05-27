using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapController : MonoBehaviour
{
    // Refer�ncia ao GameObject que voc� quer mostrar/ocultar
    public GameObject mapObject;

    // Vari�vel para controlar se o mapa est� sendo mostrado ou n�o
    private bool isMapShown = false;

    // Update � chamado uma vez por frame
    void Update()
    {
        // Verifica se a tecla M foi pressionada
        if (Input.GetKeyDown(KeyCode.M))
        {
            // Inverte o estado do mapa
            isMapShown = !isMapShown;

            // Mostra ou oculta o mapa com base no estado
            mapObject.SetActive(isMapShown);

        }
    }
}
