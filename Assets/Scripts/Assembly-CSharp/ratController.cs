using UnityEngine;
using UnityEngine.AI;

public class ratController : MonoBehaviour
{
	public float wanderRadius;

	public float wanderTimer;

	public float waitingTimer;

	public Animator ratAnim;

	private Transform target;

	private NavMeshAgent agent;

	public float timer;

	public float Waittimer;

	public bool wait;

	public float distanceWaypoint;

	public bool ratS;

	public bool ratR;

	public AudioClip ratNoise;

	public BoxCollider boxCol;

	public virtual void Start()
	{
		ratAnim.Play("Idle");
		agent.speed = 4.5f;
		wanderTimer = Random.Range(10, 30);
		ratAnim = ratAnim.gameObject.GetComponent<Animator>();
		ratR = false;
		ratS = false;
	}

	private void OnEnable()
	{
		agent = GetComponent<NavMeshAgent>();
		timer = wanderTimer;
	}

	private void Update()
	{
		if (!wait)
		{
			timer += Time.deltaTime;
		}
		if (wait)
		{
			Waittimer += Time.deltaTime;
			agent.speed = 0f;
			if (Waittimer >= waitingTimer)
			{
				wait = false;
				Waittimer = 0f;
				agent.speed = 4.5f;
			}
		}
		if (timer >= wanderTimer)
		{
			Vector3 destination = RandomNavSphere(base.transform.position, wanderRadius, -1);
			agent.SetDestination(destination);
			timer = 0f;
			wait = true;
			wanderTimer = Random.Range(10, 30);
		}
		if (agent.velocity != Vector3.zero)
		{
			if (!ratR)
			{
				ratR = true;
				ratS = false;
				ratRunning();
			}
		}
		else if (!ratS)
		{
			ratS = true;
			ratR = false;
			ratStopped();
		}
	}

	public virtual void ratStopped()
	{
		agent.speed = 0f;
		ratAnim.Play("Idle");
		timer = 50f;
		boxCol.enabled = true;
	}

	public virtual void ratRunning()
	{
		agent.speed = 4.5f;
		ratAnim.Play("Run");
		boxCol.enabled = false;
	}

	public virtual void getShoot()
	{
		GetComponent<AudioSource>().PlayOneShot(ratNoise);
	}

	public static Vector3 RandomNavSphere(Vector3 origin, float dist, int layermask)
	{
		NavMesh.SamplePosition(Random.insideUnitSphere * dist + origin, out var hit, dist, layermask);
		return hit.position;
	}
}
