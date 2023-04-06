using UnityEngine;

[ExecuteInEditMode]
public class CNJoystick : CNAbstractController
{
	[SerializeField]
	[HideInInspector]
	private float _dragRadius = 1.5f;

	[SerializeField]
	[HideInInspector]
	private bool _snapsToFinger = true;

	[SerializeField]
	[HideInInspector]
	private bool _isHiddenIfNotTweaking;

	private Transform _stickTransform;

	private Transform _baseTransform;

	private GameObject _stickGameObject;

	private GameObject _baseGameObject;

	public float DragRadius
	{
		get
		{
			return _dragRadius;
		}
		set
		{
			_dragRadius = value;
		}
	}

	public bool SnapsToFinger
	{
		get
		{
			return _snapsToFinger;
		}
		set
		{
			_snapsToFinger = value;
		}
	}

	public bool IsHiddenIfNotTweaking
	{
		get
		{
			return _isHiddenIfNotTweaking;
		}
		set
		{
			_isHiddenIfNotTweaking = value;
		}
	}

	public override void OnEnable()
	{
		base.OnEnable();
		_stickTransform = base.TransformCache.Find("Stick").GetComponent<Transform>();
		_baseTransform = base.TransformCache.Find("Base").GetComponent<Transform>();
		_stickGameObject = _stickTransform.gameObject;
		_baseGameObject = _baseTransform.gameObject;
		if (IsHiddenIfNotTweaking)
		{
			_baseGameObject.gameObject.SetActive(value: false);
			_stickGameObject.gameObject.SetActive(value: false);
		}
		else
		{
			_baseGameObject.gameObject.SetActive(value: true);
			_stickGameObject.gameObject.SetActive(value: true);
		}
	}

	protected override void ResetControlState()
	{
		base.ResetControlState();
		Transform stickTransform = _stickTransform;
		Vector3 localPosition = (_baseTransform.localPosition = Vector3.zero);
		stickTransform.localPosition = localPosition;
	}

	protected override void OnFingerLifted()
	{
		base.OnFingerLifted();
		if (IsHiddenIfNotTweaking)
		{
			_baseGameObject.gameObject.SetActive(value: false);
			_stickGameObject.gameObject.SetActive(value: false);
		}
	}

	protected override void OnFingerTouched()
	{
		base.OnFingerTouched();
		if (IsHiddenIfNotTweaking)
		{
			_baseGameObject.gameObject.SetActive(value: true);
			_stickGameObject.gameObject.SetActive(value: true);
		}
	}

	protected virtual void Update()
	{
		if (!TweakIfNeeded() && IsTouchCaptured(out var capturedTouch))
		{
			PlaceJoystickBaseUnderTheFinger(capturedTouch);
		}
	}

	protected override void TweakControl(Vector2 touchPosition)
	{
		Vector3 vector = base.ParentCamera.ScreenToWorldPoint(touchPosition);
		Vector3 vector2 = vector - _baseTransform.position;
		if (vector2.sqrMagnitude > DragRadius * DragRadius)
		{
			vector2.Normalize();
			_stickTransform.position = _baseTransform.position + vector2 * DragRadius;
		}
		else
		{
			_stickTransform.position = vector;
		}
		base.CurrentAxisValues = vector2;
		OnControllerMoved(vector2);
	}

	protected virtual void PlaceJoystickBaseUnderTheFinger(Touch touch)
	{
		if (_snapsToFinger)
		{
			Transform stickTransform = _stickTransform;
			Vector3 position = (_baseTransform.position = base.ParentCamera.ScreenToWorldPoint(touch.position));
			stickTransform.position = position;
		}
	}
}
