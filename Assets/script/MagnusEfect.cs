using UnityEngine;

public class MaxnusEfect : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] Vector3 velocity, spin;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

            // Kick
            kick();

        }
        //apply magnus effect
        ApplyMagnusEffect();
    }

    void kick()
    {
        //แรงเตะบอลตรง
        rb.linearVelocity = velocity;

        //แรงหมุนบอล
        rb.angularVelocity = spin;
    }

    void ApplyMagnusEffect()
    {
        Vector3 magnusForce = Vector3.Cross(rb.linearVelocity, rb.angularVelocity);

        rb.AddForce( magnusForce );

    }

}
