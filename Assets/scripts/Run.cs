using TMPro;
using UnityEngine;

public class Run : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI Speed;
    public Fishnish Linetrigga;
    private Rigidbody rb;

    private float movespeed = 2f;
    private float maxSpeed = 2000f;
    private float speedIncreaseRate = 5f;
    private float speed = 0f;
    private float newSpeed = 0f;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Linetrigga = GetComponent<Fishnish>();
    }
    void Update()
    {
        if (Linetrigga.finish == false)
        {
            speed = rb.velocity.magnitude;
            newSpeed = Mathf.Min(speed + speedIncreaseRate, maxSpeed);

            Speed.text = rb.velocity.ToString();

            if (Input.GetKeyUp(KeyCode.Space))
            {
                rb.velocity = new Vector3(-transform.position.x * movespeed + newSpeed * Time.deltaTime, 0, 0);
            }
        }
        else
        {
            Debug.Log("win");
        }
    }
}