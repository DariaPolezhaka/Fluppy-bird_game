using System.Diagnostics;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class Player_Controller : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Jump();
        }
    }
    void Jump()
    {
        GetComponent<Rigidbody2D>().AddForce(Vector2.up * 200);
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Enemy")
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
}
