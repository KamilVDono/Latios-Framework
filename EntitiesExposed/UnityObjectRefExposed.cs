using UnityEngine;

namespace Unity.Entities.Exposed
{
	public static class UnityObjectRefExposed
	{
		public static int InstanceId<T>(this UnityObjectRef<T> unityObjectRef) where T : Object
		{
			return unityObjectRef.Id.instanceId;
		}
	}
}
