using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10.0f;
    public float positionLimit = 15;
    public GameObject projectilePrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);

        if(transform.position.x < -positionLimit) {
            transform.position = new Vector3(-positionLimit,transform.position.y,transform.position.z);
        } else if(transform.position.x > positionLimit) {
            transform.position = new Vector3(positionLimit,transform.position.y,transform.position.z);
        }

        if(Input.GetKeyDown(KeyCode.Space)) {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
            //Instantiate(projectilePrefab, transform); 
        }
    }
}
