using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FCamera : MonoBehaviour
{
    public Transform target; // O personagem a ser seguido
    public float smoothSpeed = 10f; // Velocidade de suavização
    public Vector3 offset = new Vector3(0, 2, -10); // Posição da câmera em relação ao personagem

    void FixedUpdate() // Usar FixedUpdate para suavizar melhor o movimento da câmera
    {
        if (target == null) return;

        // Define a posição desejada com o offset
        Vector3 desiredPosition = target.position + offset;

        // Suaviza o movimento da câmera para evitar travamentos
        transform.position = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.fixedDeltaTime);
    }

}
