using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;


[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    public Vector2 movementInput;
    public float speed = 3;
    private Rigidbody2D rigidBody;

    public Tilemap groundTilemap;
    public TileBase plowedTile;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movementInput.x = Input.GetAxis("Horizontal");
        movementInput.y = Input.GetAxis("Vertical");

        if (Input.GetMouseButtonDown(0))
        {
            Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Debug.Log("Click");
            
            var clickedTilePos = groundTilemap.WorldToCell(pos);

            groundTilemap.SetTile(clickedTilePos, plowedTile);
        }
    }

    void FixedUpdate()
    {
        rigidBody.velocity = movementInput * speed;
    }
}
