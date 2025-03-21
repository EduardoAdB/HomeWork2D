using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FCamera : MonoBehaviour
{
    public Transform target; // O personagem a ser seguido
    public float smoothSpeed = 10f; // Velocidade de suaviza��o
    public Vector3 offset = new Vector3(0, 2, -10); // Posi��o da c�mera em rela��o ao personagem

    void FixedUpdate() // Usar FixedUpdate para suavizar melhor o movimento da c�mera
    {
        if (target == null) return;

        // Define a posi��o desejada com o offset
        Vector3 desiredPosition = target.position + offset;

        // Suaviza o movimento da c�mera para evitar travamentos
        transform.position = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.fixedDeltaTime);
    }

}
