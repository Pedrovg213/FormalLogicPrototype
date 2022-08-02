using UnityEngine;

#if UNITY_EDITOR
[ExecuteInEditMode]
internal class SeeOperator : MonoBehaviour {

	[SerializeField] OperatorScript operador;

	private void Update( ) {
		operador.SetOperatorSprite();
	}
}
#endif