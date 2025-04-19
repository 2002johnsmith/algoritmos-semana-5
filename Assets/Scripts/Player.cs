using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    #region Privates
    private Stack<int> movHistory = new(); // Inicialización moderna
    private int position = 0;
    private const int moveStep = 1; // Hacer el paso constante y más claro
    #endregion

    public int Position => position;

    void Start()
    {
        RecordPosition(); // Método reutilizable para registrar la posición inicial
    }

    #region Voids
    public void AddMovemet()
    {
        position += moveStep;
        RecordPosition();
        ShowPosition();
    }

    public void RemovePosition()
    {
        if (movHistory.Count <= 1)
        {
            Debug.Log("No hay movimientos anteriores para eliminar.");
            return;
        }

        movHistory.Pop(); // Elimina la última posición guardada
        position = movHistory.Peek(); // Recupera la posición anterior
        Debug.Log("Movimiento eliminado. Nueva posición: " + position);
    }

    public void ShowPosition()
    {
        if (movHistory.Count == 0)
        {
            Debug.Log("No hay posiciones registradas.");
            return;
        }

        Debug.Log("La posición del jugador es: " + movHistory.Peek());
    }

    private void RecordPosition()
    {
        movHistory.Push(position);
    }
    #endregion
}
