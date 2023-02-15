using UnityEngine;

namespace _Source
{
    [RequireComponent(typeof(ConfigurableJoint))]
    public class Physical : MonoBehaviour
    {
        [SerializeField] private Transform target;

        private ConfigurableJoint _joint;
        
        void Start()
        {
            _joint = GetComponent<ConfigurableJoint>();
        }

        void FixedUpdate()
        {
            _joint.targetRotation = Quaternion.Inverse(target.localRotation) * transform.localRotation;
        }
    }
}
