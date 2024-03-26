using System.Diagnostics.Tracing;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerPlant : MonoBehaviour
{
    PlayerInput _input;

    InputAction _plant;

    private bool OnPlot = false;

    public GameObject Plants;

    private GameObject Plot;
    private GameObject Plot2;

    private void Start()
    {
        _input = GetComponent<PlayerInput>();
        _plant = _input.actions.FindAction("Plant");
    }

    void OnPlant()
    {
        if (OnPlot == true)
        {
            Instantiate(Plants, Plot.transform);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Plot")
        {
            OnPlot = true;
            Plot = collision.gameObject;
            Debug.Log(Plot);
        };
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Plot")
        {
            OnPlot = false;
            Plot = Plot2;
            Debug.Log(Plot);
        }
    }
}
