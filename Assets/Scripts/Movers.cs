
using UnityEngine;

public class Movers : MonoBehaviour
{
    [SerializeField] float MoveSpeed = 8f;
    void Start()
    {
        GameInstruction();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void GameInstruction()
    {
        Debug.Log("Welcome to the game");
        Debug.Log("Use Arrow Keys or WASD for player movement");
    }

    void MovePlayer()
    {
        float xValue=Input.GetAxis("Horizontal") * Time.deltaTime * MoveSpeed;
        float yValue=Input.GetAxis("Vertical") * Time.deltaTime * MoveSpeed;
        transform.Translate(xValue,0,yValue);
    }
}
