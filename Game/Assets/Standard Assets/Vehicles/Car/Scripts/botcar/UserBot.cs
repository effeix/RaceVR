using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

namespace UnityStandardAssets.Vehicles.botCar
{
	[RequireComponent(typeof (BotController))]
	public class UserBot : MonoBehaviour
	{
		private BotController b_Car; // the car controller we want to use


		private void Awake()
		{
			// get the car controller
			b_Car = GetComponent<BotController>();
		}


		private void FixedUpdate()
		{
			// pass the input to the car!
			float h = 10;
			float v = 10;
#if !MOBILE_INPUT
			float handbrake = 0;
			b_Car.Move(h, v, v, handbrake);
#endif

		}
	}
}