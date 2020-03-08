/// <summary>
			/// Works with a Humanoid Animator on the root gameobject only.
			/// </summary>
			public static bool AutoDetectReferences(Transform root, out References references) {
				references = new References();

				var animator = root.GetComponentInChildren<Animator>();
				if (animator == null || !animator.isHuman) {
					Debug.LogWarning("needs a Humanoid Animator to auto-detect biped references. Please assign references manually.");
					return false;
				}

				references.root = root;
				references.leftShoulder = animator.GetBoneTransform(HumanBodyBones.LeftShoulder);
				references.leftUpperArm = animator.GetBoneTransform(HumanBodyBones.LeftUpperArm);
				references.leftForearm = animator.GetBoneTransform(HumanBodyBones.LeftLowerArm);
				references.leftHand = animator.GetBoneTransform(HumanBodyBones.LeftHand);
				references.rightShoulder = animator.GetBoneTransform(HumanBodyBones.RightShoulder);
				references.rightUpperArm = animator.GetBoneTransform(HumanBodyBones.RightUpperArm);
				references.rightForearm = animator.GetBoneTransform(HumanBodyBones.RightLowerArm);
				references.rightHand = animator.GetBoneTransform(HumanBodyBones.RightHand);
				return true;
			}
