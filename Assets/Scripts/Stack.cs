using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Simular movimientos en un juego y poder deshacerlos.

public class Stack : MonoBehaviour
{
    #region Privates
    Stack<int> MovPlayers = new Stack<int>();
    private int position = 0;
    private int mov = 1;
    #endregion

    void Start()
    {
        MovPlayers.Push(position);
    }
    #region Voids
    public void AddMovemet()//Añade un elemento
    {
        position = position + mov;
        MovPlayers.Push(position);
        ShowPosition();
    }
    public void RemovePosition()//Elimina el ultimo elemento
    {
        if (MovPlayers.Count <= 0)
        {
            print("No hay movimientos realizados");
            return;
        }
        print("Se elimino el movimiento: " + MovPlayers.Pop());
        position = position - 1;
        position = MovPlayers.Peek();
    }
    public void ShowPosition()//Muestra la posicion actual
    {
        if (MovPlayers.Count <= 0)
        {
            print("No hay posiciones guardadas en el stack.");
            return;
        }
        print("La posición del jugador es: " + MovPlayers.Peek());
    }
    #endregion
}
