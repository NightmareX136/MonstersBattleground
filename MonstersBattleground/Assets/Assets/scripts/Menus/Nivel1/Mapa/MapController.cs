using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapController : MonoBehaviour
{
    // Referência ao GameObject que você quer mostrar/ocultar
    public GameObject mapObject;

    // Variável para controlar se o mapa está sendo mostrado ou não
    private bool isMapShown = false;

    // Update é chamado uma vez por frame
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
