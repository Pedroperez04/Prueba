using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float playerSpeed = 2f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var m_Horizontal = Input.GetAxis("Horizontal");
        var m_Vertical = Input.GetAxis("Vertical");
        var m_direction = new Vector3(m_Horizontal, 0, m_Vertical);

        Move(m_direction);
    }
    private void Move(Vector3 mov_direction)
    {
        transform.position += mov_direction * (playerSpeed * Time.deltaTime);
    }
}
