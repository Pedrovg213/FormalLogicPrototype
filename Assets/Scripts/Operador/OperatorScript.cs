using UnityEngine;

public class OperatorScript : MonoBehaviour, ICheck {

	[SerializeField] Sprite[ ] operatorSprites;
	[SerializeField] SpriteRenderer spriteRender;
	[SerializeField] OperationEnum operationEnum;
	public bool isTrue = false;


	public bool Check( ) {
		return ( isTrue );
	}
	public ICheck GetICheck( ) {

		return ( this );

	}
	public OperationEnum GetOperatorEnum( ) {

		return ( operationEnum );

	}
	public void ChangeValue( bool _value ) {

		isTrue = _value;

	}
	public void SetOperatorSprite( ) {

		switch ( operationEnum ) {

			case ( OperationEnum.Or ):
				SetSprite( 0 , true , Vector3.one * .5f );
				break;

			case ( OperationEnum.And ):
				SetSprite( 0 , false , Vector3.one * .5f );
				break;

			case ( OperationEnum.Implie ):
				SetSprite( 1 , false , Vector3.one * .5f );
				break;

			case ( OperationEnum.BiImplie ):
				SetSprite( 2 , false , Vector3.one * .5f );
				break;

			case ( OperationEnum.Xor ):
				SetSprite( 3 , true , Vector3.one * .5f );
				break;

			case ( OperationEnum.Conclusion ):
			case ( OperationEnum.Falsifiable ):
				SetSprite( 4 , false , Vector3.one );
				break;

#if UNITY_EDITOR
			case ( OperationEnum.Default ):
				SetSprite( -1 , false , Vector3.one );
				break;
#endif

		}

	}
	private void SetSprite( int _sprite , bool _flipY , Vector3 _scale ) {

		spriteRender.sprite = _sprite < 0 ? null : operatorSprites[ _sprite ];
		spriteRender.flipY = _flipY;
		transform.localScale = _scale;

	}
	private void Start( ) {

		SetOperatorSprite();

	}
}

public enum OperationEnum {

	Default,
	And,
	BiImplie,
	Conclusion,
	Falsifiable,
	Implie,
	Or,
	Xor

}
