using UnityEngine;
using System.Collections;

public enum VoxelType{
	Sphere, Capsule, Cylinder, Cube, Plane, Quad
}

public class Voxel : MonoBehaviour {

	private GameObject myVoxel;
	public VoxelType voxelType;
	public Material voxelMaterial;
	public Vector3 position;
	public bool breakable = false;
	public int blockHealth = 50;
	

	void Start() {
		// Create this Voxel based on type
		if(voxelType == VoxelType.Sphere) {
			myVoxel = GameObject.CreatePrimitive(PrimitiveType.Sphere);
		}
		else if(voxelType == VoxelType.Capsule) {
			myVoxel = GameObject.CreatePrimitive(PrimitiveType.Capsule);
		}
		else if(voxelType == VoxelType.Cylinder) {
			myVoxel = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
		}
		else if(voxelType == VoxelType.Cube) {
			myVoxel = GameObject.CreatePrimitive(PrimitiveType.Cube);
		}
		else if(voxelType == VoxelType.Plane) {
			myVoxel = GameObject.CreatePrimitive(PrimitiveType.Plane);
		}
		else if(voxelType == VoxelType.Quad) {
			myVoxel = GameObject.CreatePrimitive(PrimitiveType.Quad);
		}
		myVoxel.GetComponent<Renderer>().material = voxelMaterial;
		myVoxel.transform.position = position;
	}
		
	void Update() {
	}
}
