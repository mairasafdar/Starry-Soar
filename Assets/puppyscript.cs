using UnityEngine;

public class puppyscript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float jumpStrength;
    public LogicScript logic;
    public bool puppyAlive = true;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {   

        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<LogicScript>();
        logic.titleScene();


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && puppyAlive)
            {
                logic.startGame();
                myRigidbody.linearVelocity = Vector2.up * jumpStrength;
            }
        if (myRigidbody.position.y < -19)
            {
                logic.gameOver();
                puppyAlive = false;
            }
        
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        puppyAlive = false;
    }
}
