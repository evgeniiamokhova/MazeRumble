using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CellState
{
    Available,
    Breakable,
    Unbreakable
}

public class CellItem : MonoBehaviour
{
     [SerializeField] SpriteRenderer cell;

    public void SetState(CellState state)
    {
        switch (state) {
            case CellState.Available:
                cell.color = new Color(255f, 255f, 255f, 1f); // White 
                break;
            case CellState.Breakable:
                cell.color = new Color(0.737f, 0.737f, 0.737f, 1f); // Light gray 
                break;
            case CellState.Unbreakable:
                cell.color = new Color(0f, 0f, 0f, 1f); // Black
                break;
        }
    }

}
