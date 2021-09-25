using ScriptableVariables;
using UnityEngine;

namespace Example
{
    public class ExampleSetFloatVarToSinOverTime : MonoBehaviour
    {
        [SerializeField] private FloatVariable FloatVar;

        private void Update()
        {
            FloatVar.Value = Mathf.Sin(Time.time);
        }
    }
}
