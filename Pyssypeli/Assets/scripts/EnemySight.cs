using UnityEngine;
using System.Collections;

public class EnemySight : MonoBehaviour {

	public float fieldOfViewAngle = 115f;
	public bool playerInSight;
	public Vector3 personalLastSighting;

	private NavMeshAgent nav;
	private CircleCollider2D col;
	private LastPlayerSighting lastPlayerSightning;
	private GameObject player;
	private HashIDs hash;
	private Vector3 previousSighting;

	void Awake()
	{
		nav = GetComponent<NavMeshAgent> ();
		col = GetComponent<CircleCollider2D> ();
		lastPlayerSightning = GameObject.FindGameObjectWithTag (Tags.gameController).GetComponent<LastPlayerSighting> ();
		player = GameObject.FindGameObjectWithTag (Tags.player);
		hash = GameObject.FindGameObjectWithTag (Tags.gameController).GetComponent<HashIDs> ();

		personalLastSighting = lastPlayerSightning.resetPosition;
		previousSighting = lastPlayerSightning.resetPosition;
	}

	void Update()
	{
		if (lastPlayerSightning.position != previousSighting)
			personalLastSighting = lastPlayerSightning.position;
		previousSighting = lastPlayerSightning.position;

	}

	void OnTriggerStay(Collider other)
	{
		if (other.gameObject == player) {
			playerInSight = false;

			Vector3 direction = other.transform.position - transform.position;
			float angle = Vector3.Angle (direction, transform.forward);

			if(angle < fieldOfViewAngle * 0.5f)
			{
				RaycastHit hit;

				if(Physics.Raycast(transform.position + transform.up, direction.normalized, out hit, col.radius))
				{
					if(hit.collider.gameObject == player)
					{
						playerInSight = true;

						lastPlayerSightning.position = player.transform.position;
					}
				}
			}

		}
	}

	void OnTriggerExit(Collider other)
	{
		if (other.gameObject == player)
			playerInSight = false;

	}

	float CalculatePathLength(Vector3 targetPosition)
	{
		NavMeshPath path = new NavMeshPath ();
		if (nav.enabled)
			nav.CalculatePath (targetPosition, path);

		Vector3[] allWayPoints = new Vector3[path.corners.Length + 2];

		allWayPoints [0] = transform.position;

		allWayPoints [allWayPoints.Length - 1] = targetPosition;

		for (int i = 0; i < path.corners.Length; i++) {
			allWayPoints[i + 1] = path.corners[i];
		}

		float pathLenght = 0;

		for (int i = 0; i < allWayPoints.Length - 1; i++) {
			pathLenght += Vector3.Distance (allWayPoints[i], allWayPoints[i + 1]);
		}

		return pathLenght;

	}
}
