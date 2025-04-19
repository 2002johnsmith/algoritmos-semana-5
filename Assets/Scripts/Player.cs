using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    #region Privates
    private Stack<int> movHistory = new(); // Inicializaci�n moderna
    private int position = 0;
    private const int moveStep = 1; // Hacer el paso constante y m�s claro
    #endregion

    public int Position => position;

    void Start()
    {
        RecordPosition(); // M�todo reutilizable para registrar la posici�n inicial
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

        movHistory.Pop(); // Elimina la �ltima posici�n guardada
        position = movHistory.Peek(); // Recupera la posici�n anterior
        Debug.Log("Movimiento eliminado. Nueva posici�n: " + position);
    }

    public void ShowPosition()
    {
        if (movHistory.Count == 0)
        {
            Debug.Log("No hay posiciones registradas.");
            return;
        }

        Debug.Log("La posici�n del jugador es: " + movHistory.Peek());
    }

    private void RecordPosition()
    {
        movHistory.Push(position);
    }
    #endregion
}
