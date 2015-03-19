using UnityEngine;
using System.Collections;

public class MoveTo : MonoBehaviour {

	public Transform[] Points;
	private int destPoint = 0;
	private NavMeshAgent agent;

	void Start()
	{
		agent = GetComponent<NavMeshAgent>();
		agent.autoBraking = false;

		GotoNextPoint ();
	}

	void GotoNextPoint()
	{
		if (Points.Length == 0)
			return;

		agent.destination = Points [destPoint].position;

		destPoint = (destPoint + 1) % Points.Length;
	}

	void Update()
	{
		if (agent.remainingDistance < 0.5f)
			GotoNextPoint ();
	}
}
