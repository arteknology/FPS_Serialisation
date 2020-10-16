using UnityEngine;

namespace Monobehaviours
{
    public class GunAnimController : MonoBehaviour
    {
        private Animator _anim;

        // Start is called before the first frame update
        void Start()
        {
            _anim = GetComponent<Animator>();
        }

        // Update is called once per frame
        void Update()
        {
            float y = Input.GetAxis("Vertical");
            float x = Input.GetAxis("Horizontal");

            Move(y, x);
        }

        private void Move(float y, float x)
        {
            _anim.SetFloat("VelY", y);
            _anim.SetFloat("VelX", x);

            if (Input.GetKey(KeyCode.LeftShift))
            {
                _anim.SetBool("Run", true);
            }
            else
            {
                _anim.SetBool("Run", false);
            }

            if (Input.GetKey(KeyCode.LeftShift) && x == 0 && y == 0)
            {
                _anim.SetBool("Run", false);
            }
        }
    }
}
