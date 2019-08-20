using UnityEngine;

public class gunControl : MonoBehaviour
{
    public int damage = 1000;
    public int range = 100;

    public Camera fpsCam;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }

    }
    void Shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            
            GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            sphere.transform.localScale = new Vector3(0.25f, 0.25f, 0.25f);
            sphere.transform.position = hit.point;
            GameObject.Destroy(sphere.GetComponent<SphereCollider>());
            

            Debug.Log(hit.transform.name);
            if (hit.transform.tag == "Zombie")
            {
                ZombieBehaviour Behaviour = hit.transform.gameObject.GetComponent<ZombieBehaviour>();
                Debug.Log("Hit a zombie");
                Behaviour.TakeDamage(damage);
            }
        }
    }
}
