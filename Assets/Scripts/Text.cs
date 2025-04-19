using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class SystemText : MonoBehaviour
{
    [SerializeField] private TMP_Text text;
    [SerializeField] private Player playerMov;

    void Update()
    {
        text.text = "Posición del jugador: " + playerMov.Position;
    }
}
