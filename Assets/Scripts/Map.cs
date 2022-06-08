using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

// 0.5
// 0.8660254

public class Map : MonoBehaviour
{
    // public MapState mapState;
    public Camera cam;
    public Cell cell;
    public Unit unit;

    void Start()
    {
        // unit = null;
        // mapState.grid = new Cell[10, 10];
        for (var i = 0; i < 10; i++)
        {
            for (var j = 0; j < 10; j++)
            {
                var zShift = 0f;
                if (j % 2 == 0)
                {
                    zShift = 0.8660254f;
                }
                cell.InitPoss(i, j);
                //  cell;
                // mapState.grid[j, i] = Instantiate(cell, new Vector3((i * 1.732051f) + zShift, 0, j * 1.5f), Quaternion.identity, gameObject.transform);
                Instantiate(cell, new Vector3((i * 1.732051f) + zShift, 0, j * 1.5f), Quaternion.identity, gameObject.transform);
            }
        }
    }

    void Update()
    {

    }

    public void SetUnit(Vector3 mousePos)
    {
        print(mousePos);
        Ray ray = cam.ScreenPointToRay(mousePos);
        RaycastHit hit;


        if (!Physics.Raycast(ray, out hit))
        {
            return;
        }

        if (!hit.transform.gameObject.GetComponent<Cell>())
        {
            return;
        }


        if (!unit)
        {
            unit = Instantiate(unit, hit.transform);
        }
        else
        {
            unit.transform.position = hit.transform.position;
        }

    }
}

