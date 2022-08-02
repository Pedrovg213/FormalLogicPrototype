using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ListenerOperator : MonoBehaviour {

	[SerializeField] List<GameObject> checks;
	[SerializeField] OperatorScript Operator;
	[SerializeField] int order;
	private OperationEnum operatorEnum;
	private List<ICheck> iChecks;


	private bool CheckAnd( ) {

		return ( !( iChecks.Any( c => c.Check() == false ) ) );

	}
	public void CheckArguments( ) {

		switch ( operatorEnum ) {

			case OperationEnum.And:
			case OperationEnum.Conclusion:
				Operator.ChangeValue( CheckAnd() );
				break;

			case OperationEnum.Or:
				Operator.ChangeValue( CheckOr() );
				break;

			case OperationEnum.Implie:
				Operator.ChangeValue( CheckImplies() );
				break;
			case OperationEnum.BiImplie:
				Operator.ChangeValue( CheckBiImplies() );
				break;

			case OperationEnum.Xor:
				Operator.ChangeValue( CheckXor() );
				break;

			case OperationEnum.Falsifiable:
				Operator.ChangeValue( CheckFalsifiable() );
				break;

		}
	}
	private bool CheckBiImplies( ) {

		return ( iChecks[ 0 ].Check() == iChecks[ 1 ].Check() );

	}
	public bool CheckFalsifiable( ) {

		return ( iChecks[ 0 ].Check() == true && iChecks[ 1 ].Check() == false );

	}
	private bool CheckImplies( ) {

		return ( !( iChecks[ 0 ].Check() == false && iChecks[ 1 ].Check() == true ) );

	}
	private bool CheckOr( ) {

		return ( iChecks.Any( c => c.Check() == true ) );

	}
	private bool CheckXor( ) {

		return ( CheckOr() && !CheckBiImplies() );

	}
	public int GetOrder( ) {

		return ( order );

	}
	private void Start( ) {

		iChecks = checks.Select( c => c.GetComponent<ICheck>() ).ToList();
		operatorEnum = Operator.GetOperatorEnum();

	}
}
