using System.Collections;
using System.Collections.Generic;
using TreeEditor;
using UnityEngine;

public class PlayerCharacter : MonoBehaviour
{
    [SerializeField] Cube blockingCube;

    private Vector3 velocity;
    private float speed = 6f;
    private float gravity = -9.8f;
    private bool onGround = true;
    public bool isAlive = true;

    private Cube previousCube;

    void Update()
    {
        if (!isAlive) return;

        Move();

        if (previousCube) previousCube.Dettach();

        if (Input.GetAxis("Fire1") == 1)
        {
            GameObject camera = GameObject.FindWithTag("MainCamera");
            Vector3 rotation = new(camera.transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, 0);
            Vector3 direction = Quaternion.Euler(rotation) * Vector3.forward;
            Vector3 startPos = transform.position;
            RaycastHit hitcube;
            RaycastHit hit;

            Physics.Raycast(startPos, direction, out hit, 3.5f);

            if (Physics.Raycast(startPos, direction, out hitcube, 2, LayerMask.GetMask("Ignore Raycast")))
            {
                Cube cube = hitcube.collider.gameObject.GetComponent<Cube>();
                cube.Attach(hit.point, startPos, direction);
                previousCube = cube;
            }
        }
    }

    private void Move()
    {
        CharacterController charCon = GetComponent<CharacterController>();
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        float jump = Input.GetAxis("Jump");
        Vector3 moveAmount = new(0, 0, 0);

        if (onGround != charCon.isGrounded && charCon.isGrounded == false)
        {
            velocity.x = 0.5f * charCon.velocity.x;
            velocity.z = 0.5f * charCon.velocity.z;
        }
        onGround = charCon.isGrounded;

        moveAmount.x = horizontal;
        moveAmount.z = vertical;
        moveAmount = Vector3.ClampMagnitude(moveAmount * speed, speed);
        moveAmount = transform.TransformDirection(moveAmount);
        if (!onGround) moveAmount *= 0.5f;

        velocity.y += gravity * Time.deltaTime;
        if (onGround) velocity = new Vector3(0, -1f, 0);
        if (onGround && jump == 1) velocity.y = 4f;
        moveAmount += velocity;
        charCon.Move(moveAmount * Time.deltaTime);
    }
    public void Shot()
    {
        AudioSource audio = GetComponent<AudioSource>();
        audio.Play();
        CharacterController charCon = GetComponent<CharacterController>();
        GameObject camera = GameObject.FindWithTag("MainCamera");
        charCon.enabled = false;
        transform.position = new Vector3(-100, 14, 42);
        charCon.enabled = true;
        blockingCube.transform.position = new Vector3(-98, 13, 42);
    }
}
