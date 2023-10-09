using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static CellState;

public class MazeGenerator : MonoBehaviour
{
    [SerializeField] GameObject cellPrefab;
    [SerializeField] Vector2Int mazeSize;

    public void Start()
    {
        StartCoroutine(GenerateMaze(mazeSize));
    }

    IEnumerator GenerateMaze(Vector2Int size) {
        List<GameObject> cells = new List<GameObject>();

        for (int x = 0; x < size.x; x++) {
            for (int y = 0; y < size.y; y++){
                Vector2 cellPosition = new Vector2(x - (size.x / 2f), y - (size.y / 2f));
                GameObject mazeCell = Instantiate(cellPrefab, cellPosition, Quaternion.identity);
                var item = mazeCell.GetComponent<CellItem>();
                item.SetState(CellState.Breakable);

                cells.Add(mazeCell);

                yield return null;
            }
        }

    }

}
