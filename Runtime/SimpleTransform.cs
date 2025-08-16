using UnityEngine;

namespace SimpleTools
{
    public class SimpleTransform : MonoBehaviour
    {
        [SerializeField]
        private bool active = true;

        [SerializeField]
        private Vector3 constantTranslate = Vector3.zero;

        private void Update()
        {
            if(active)
            {
                transform.Translate(constantTranslate * Time.deltaTime);
            }
        }

        public void SetActive(bool _active)
        {
            active = _active;
        }
    }
}