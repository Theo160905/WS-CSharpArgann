using UnityEngine;

public class Plot : MonoBehaviour
{
    private bool _isempty = false;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject);
        if (collision.gameObject.tag == "Plant")
        {
            _isempty = true;
            Debug.Log("HELO");
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Plant")
        {
            _isempty = false;
        }
    }
}
