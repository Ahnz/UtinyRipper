namespace uTinyRipper
{
	// Since some output is based on string representation renamed values has negative index
	public enum ClassIDType
	{
		Object							= 0,
		
		// =====================================
		// Runetime section
		// =====================================

		GameObject						= 1,
		Component						= 2,
		LevelGameManager				= 3,
		Transform						= 4,
		TimeManager						= 5,
		GlobalGameManager				= 6,
		BehaviourManager				= 7,
		Behaviour						= 8,
		GameManager						= 9,
		AudioManager					= 11,
		ParticleAnimator				= 12,
		InputManager					= 13,
		EllipsoidParticleEmitter		= 15,
		Filter							= 16,
		Pipeline						= 17,
		EditorExtension					= 18,
		Physics2DSettings				= 19,
		Camera							= 20,
		Material						= 21,
		MeshRenderer					= 23,
		Renderer						= 25,
		ParticleRenderer				= 26,
		Texture							= 27,
		Texture2D						= 28,
		Scene							= -29,
		SceneSettings					= -29,
		OcclusionCullingSettings		= 29,
		RenderManager					= -30,
		GraphicsSettings				= 30,
		PipelineManager					= 31,
		MeshFilter						= 33,
		BaseBehaviourManager			= 34,
		LateBehaviourManager			= 35,
		OcclusionPortal					= 41,
		Mesh							= 43,
		Skybox							= 45,
		FixedBehaviourManager			= 46,
		QualitySettings					= 47,
		Shader							= 48,
		Script							= -49,
		TextAsset						= 49,
		Rigidbody2D						= 50,
		Physics2DManager				= 51,
		NotificationManager				= 52,
		Collider2D						= 53,
		Rigidbody						= 54,
		PhysicsManager					= 55,
		Collider						= 56,
		Joint							= 57,
		CircleCollider2D				= 58,
		HingeJoint						= 59,
		PolygonCollider2D				= 60,
		BoxCollider2D					= 61,
		PhysicsMaterial2D				= 62,
		UpdateManager					= 63,
		MeshCollider					= 64,
		BoxCollider						= 65,
		SpriteCollider2D				= -66,
		CompositeCollider2D				= 66,
		RenderLayer						= 67,
		EdgeCollider2D					= 68,
		CapsuleCollider2D				= 70,
		AnimationManager				= 71,
		ComputeShader					= 72,
		AnimationClip					= 74,
		ConstantForce					= 75,
		WorldParticleCollider			= 76,
		TagManager						= 78,
		AudioListener					= 81,
		AudioSource						= 82,
		AudioClip						= 83,
		RenderTexture					= 84,
		CustomRenderTexture				= 86,
		MeshParticleEmitter				= 87,
		ParticleEmitter					= 88,
		Cubemap							= 89,
		Avatar							= 90,
		AnimatorController				= 91,
		GUILayer						= 92,
		RuntimeAnimatorController		= 93,
		ScriptMapper					= 94,
		Animator						= 95,
		TrailRenderer					= 96,
		DelayedCallManager				= 98,
		TextMesh						= 102,
		RenderSettings					= 104,
		Light							= 108,
		CGProgram						= 109,
		BaseAnimationTrack				= 110,
		Animation						= 111,
		MonoBehaviour					= 114,
		MonoScript						= 115,
		MonoManager						= 116,
		Texture3D						= 117,
		NewAnimationTrack				= 118,
		Projector						= 119,
		LineRenderer					= 120,
		Flare							= 121,
		Halo							= 122,
		LensFlare						= 123,
		FlareLayer						= 124,
		HaloLayer						= 125,
		NavMeshLayers					= -126,
		NavMeshAreas					= -126,
		NavMeshProjectSettings			= 126,
		HaloManager						= 127,
		Font							= 128,
		PlayerSettings					= 129,
		NamedObject						= 130,
		GUITexture						= 131,
		GUIText							= 132,
		GUIElement						= 133,
		PhysicMaterial					= 134,
		SphereCollider					= 135,
		CapsuleCollider					= 136,
		SkinnedMeshFilter				= -137,
		SkinnedMeshRenderer				= 137,
		FixedJoint						= 138,
		RaycastCollider					= 140,
		BuildSettings					= 141,
		AssetBundle						= 142,
		CharacterController				= 143,
		CharacterJoint					= 144,
		SpringJoint						= 145,
		WheelCollider					= 146,
		ResourceManager					= 147,
		NetworkView						= 148,
		NetworkManager					= 149,
		PreloadData						= 150,
		MovieTexture					= 152,
		ConfigurableJoint				= 153,
		TerrainCollider					= 154,
		MasterServerInterface			= 155,
		TerrainData						= 156,
		LightmapSettings				= 157,
		WebCamTexture					= 158,
		EditorSettings					= 159,
		InteractiveCloth				= 160,
		ClothRenderer					= 161,
		EditorUserSettings				= 162,
		SkinnedCloth					= 163,
		AudioReverbFilter				= 164,
		AudioHighPassFilter				= 165,
		AudioChorusFilter				= 166,
		AudioReverbZone					= 167,
		AudioEchoFilter					= 168,
		AudioLowPassFilter				= 169,
		AudioDistortionFilter			= 170,
		SparseTexture					= 171,
		AudioBehaviour					= 180,
		AudioFilter						= 181,
		WindZone						= 182,
		Cloth							= 183,
		SubstanceArchive				= 184,
		ProceduralMaterial				= 185,
		ProceduralTexture				= 186,
		Texture2DArray					= 187,
		CubemapArray					= 188,
		OffMeshLink						= 191,
		OcclusionArea					= 192,
		Tree							= 193,
		NavMesh							= -194,
		NavMeshObsolete					= 194,
		NavMeshAgent					= 195,
		NavMeshSettings					= 196,
		LightProbesLegacy				= 197,
		ParticleSystem					= 198,
		ParticleSystemRenderer			= 199,
		ShaderVariantCollection			= 200,
		LODGroup						= 205,
		BlendTree						= 206,
		Motion							= 207,
		NavMeshObstacle					= 208,
		SortingGroup					= 210,
		//TerrainInstance				= 210,
		SpriteRenderer					= 212,
		Sprite							= 213,
		CachedSpriteAtlas				= 214,
		ReflectionProbe					= 215,
		ReflectionProbes				= 216,
		Terrain							= 218,
		LightProbeGroup					= 220,
		AnimatorOverrideController		= 221,
		CanvasRenderer					= 222,
		Canvas							= 223,
		RectTransform					= 224,
		CanvasGroup						= 225,
		BillboardAsset					= 226,
		BillboardRenderer				= 227,
		SpeedTreeWindAsset				= 228,
		AnchoredJoint2D					= 229,
		Joint2D							= 230,
		SpringJoint2D					= 231,
		DistanceJoint2D					= 232,
		HingeJoint2D					= 233,
		SliderJoint2D					= 234,
		WheelJoint2D					= 235,
		ClusterInputManager				= 236,
		BaseVideoTexture				= 237,
		NavMeshData						= 238,
		AudioMixer						= 240,
		AudioMixerController			= 241,
		AudioMixerGroupController		= 243,
		AudioMixerEffectController		= 244,
		AudioMixerSnapshotController	= 245,
		PhysicsUpdateBehaviour2D		= 246,
		ConstantForce2D					= 247,
		Effector2D						= 248,
		AreaEffector2D					= 249,
		PointEffector2D					= 250,
		PlatformEffector2D				= 251,
		SurfaceEffector2D				= 252,
		BuoyancyEffector2D				= 253,
		RelativeJoint2D					= 254,
		FixedJoint2D					= 255,
		FrictionJoint2D					= 256,
		TargetJoint2D					= 257,
		LightProbes						= 258,
		LightProbeProxyVolume			= 259,
		SampleClip						= 271,
		AudioMixerSnapshot				= 272,
		AudioMixerGroup					= 273,
		NScreenBridge					= 280,
		AssetBundleManifest				= 290,
		UnityAdsManager					= 292,
		RuntimeInitializeOnLoadManager	= 300,
		CloudWebServicesManager			= 301,
		UnityAnalyticsManager			= 303,
		CrashReportManager				= 304,
		PerformanceReportingManager		= 305,
		UnityConnectSettings			= 310,
#warning TODO: merge with AvatarMask
		AvatarMask1						= 319,
		PlayableDirector				= 320,
		VideoPlayer						= 328,
		VideoClip						= 329,
		ParticleSystemForceField		= 330,
		SpriteMask						= 331,
		WorldAnchor						= 362,
		OcclusionCullingData			= 363,

		// =====================================
		// Editor section
		// =====================================

		DataTemplate					= -1001,
		Prefab							= 1001,
		EditorExtensionImpl				= 1002,
		AssetImporter					= 1003,
		AssetDatabase					= 1004,
		Mesh3DSImporter					= 1005,
		TextureImporter					= 1006,
		ShaderImporter					= 1007,
		ComputeShaderImporter			= 1008,
		AvatarMask						= 1011,
		AudioImporter					= 1020,
		HierarchyState					= 1026,
		GUIDSerializer					= 1027,
		AssetMetaData					= 1028,
		DefaultAsset					= 1029,
		DefaultImporter					= 1030,
		TextScriptImporter				= 1031,
		SceneAsset						= 1032,
		NativeFormatImporter			= 1034,
		MonoImporter					= 1035,
		AssetServerCache				= 1037,
		LibraryAssetImporter			= 1038,
		ModelImporter					= 1040,
		FBXImporter						= 1041,
		TrueTypeFontImporter			= 1042,
		MovieImporter					= 1044,
		EditorBuildSettings				= 1045,
		DDSImporter						= 1046,
		InspectorExpandedState			= 1048,
		AnnotationManager				= 1049,
		MonoAssemblyImporter			= -1050,
		PluginImporter					= 1050,
		EditorUserBuildSettings			= 1051,
		PVRImporter						= 1052,
		ASTCImporter					= 1053,
		KTXImporter						= 1054,
		IHVImageFormatImporter			= 1055,
		AnimatorStateTransition			= 1101,
		AnimatorState					= 1102,
		HumanTemplate					= 1105,
		AnimatorStateMachine			= 1107,
		PreviewAssetType				= 1108,
		AnimatorTransition				= 1109,
		SpeedTreeImporter				= 1110,
		AnimatorTransitionBase			= 1111,
		SubstanceImporter				= 1112,
		EnlightenSystemBuildParameters	= -1113,
		LightmapParameters				= 1113,
		LightmapSnapshot				= -1120,
		LightingDataAsset				= 1120,
		GISRaster						= 1121,
		GISRasterImporter				= 1122,
		CadImporter						= 1123,
		SketchUpImporter				= 1124,
		BuildReport						= 1125,
		PackedAssets					= 1126,
		VideoClipImporter				= 1127,
		/// <summary>
		/// ???
		/// </summary>
		ActivationLogComponent			= 2000,
		
		// =====================================
		// Custom section
		// =====================================

		@int							= 100000,
		@bool							= 100001,
		@float							= 100002,
		MonoObject						= 100003,
		Collision						= 100004,
		Vector3f						= 100005,
		RootMotionData					= 100006,
		Collision2D						= 100007,
		AudioMixerLiveUpdateFloat		= 100008,
		AudioMixerLiveUpdateBool		= 100009,
		Polygon2D						= 100010,
		@void							= 100011,

		// =====================================
		// New editor section
		// =====================================

		TilemapCollider2D				= 19719996,
		AssetImporterLog				= 41386430,
		Grid							= 156049354,
		Preset							= 181963792,
		IConstraint						= 285090594,
		SiblingDerived					= 334799969,
		SubDerived						= 367388927,
		AssetImportInProgressProxy		= 369655926,
		EditorProjectAccess				= 426301858,
		TilemapRenderer					= 483693784,
		SpriteAtlasDatabase				= 638013454,
		CachedSpriteAtlasRuntimeData	= 644342135,
		BuiltAssetBundleInfoSet			= 668709126,
		SpriteAtlas						= 687078895,
		PlatformModuleSetup				= 877146078,
		AimConstraint					= 895512359,
		LocalizationImporter			= 1027052791,
		Derived							= 1091556383,
		AssemblyDefinitionAsset			= 1152215463,
		LookAtConstraint				= 1183024399,
		GameObjectRecorder				= 1268269756,
		LightingDataAssetParent			= 1325145578,
		PresetManager					= 1386491679,
		StreamingManager				= 1403656975,
		LowerResBlitTexture				= 1480428607,
		StreamingController				= 1542919678,
		RenderPassAttachment			= 1571458007,
		GridLayout						= 1742807556,
		AssemblyDefinitionImporter		= 1766753193,
		ParentConstraint				= 1773428102,
		PositionConstraint				= 1818360608,
		RotationConstraint				= 1818360609,
		ScaleConstraint					= 1818360610,
		Tilemap							= 1839735485,
		TerrainLayer					= 1953259897,
		SpriteShapeRenderer				= 1971053207,
		LocalizationAsset				= 2083778819,
		ScriptedImporter				= 2089858483,
		TilemapEditorUserSettings		= 2126867596,
	}

	public static class ClassIDTypeExtention
	{
		public static int ToInt(this ClassIDType _this)
		{
			return (int)_this;
		}

		public static bool IsTransform(this ClassIDType _this)
		{
			return _this == ClassIDType.Transform || _this == ClassIDType.RectTransform;
		}

		public static bool IsSceneSettings(this ClassIDType _this)
		{
			switch (_this)
			{
				case ClassIDType.OcclusionCullingSettings:
				case ClassIDType.RenderSettings:
				case ClassIDType.LightmapSettings:
				case ClassIDType.NavMeshSettings:
					return true;
			}
			return false;
		}
	}
}
