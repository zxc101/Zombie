using IK.Humanoid.Hand;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IKHanding : MonoBehaviour {
    
    private Animator anim;

    [SerializeField] private float rightHandWeight = 1;
    [SerializeField] private float leftHandWeight = 1;
    
    //[SerializeField] private Transform rightHand;
    //[SerializeField] private Transform leftHand;

    [SerializeField] private GameObject Weapon;
    [SerializeField] private Transform lookPos;

    //private Transform rightHand;
    //private Transform leftHand;
    private WeaponUse weaponUse;
    private Transform RightHand;
    private Transform LeftHand;

    private void OnValidate()
    {
        anim = GetComponent<Animator>();

        #region Right

        #region Hand
        //rightHand = anim.GetBoneTransform(HumanBodyBones.RightHand);
        #endregion

        //#region Little
        //RightHand.LittleProximal.Transform = anim.GetBoneTransform(HumanBodyBones.RightLittleProximal);
        //RightHand.LittleProximal.LittleIntermediate.Transform = anim.GetBoneTransform(HumanBodyBones.RightLittleIntermediate);
        //RightHand.LittleProximal.LittleIntermediate.LittleDistal.Transform = anim.GetBoneTransform(HumanBodyBones.RightLittleDistal);
        //#endregion

        //#region Ring
        //RightHand.RingProximal.Transform = anim.GetBoneTransform(HumanBodyBones.RightRingProximal);
        //RightHand.RingProximal.RingIntermediate.Transform = anim.GetBoneTransform(HumanBodyBones.RightRingIntermediate);
        //RightHand.RingProximal.RingIntermediate.RingDistal.Transform = anim.GetBoneTransform(HumanBodyBones.RightRingDistal);
        //#endregion

        //#region Middle
        //RightHand.MiddleProximal.Transform = anim.GetBoneTransform(HumanBodyBones.RightMiddleProximal);
        //RightHand.MiddleProximal.MiddleIntermediate.Transform = anim.GetBoneTransform(HumanBodyBones.RightMiddleIntermediate);
        //RightHand.MiddleProximal.MiddleIntermediate.MiddleDistal.Transform = anim.GetBoneTransform(HumanBodyBones.RightMiddleDistal);
        //#endregion

        //#region Index
        //RightHand.IndexProximal.Transform = anim.GetBoneTransform(HumanBodyBones.RightIndexProximal);
        //RightHand.IndexProximal.IndexIntermediate.Transform = anim.GetBoneTransform(HumanBodyBones.RightIndexIntermediate);
        //RightHand.IndexProximal.IndexIntermediate.IndexDistal.Transform = anim.GetBoneTransform(HumanBodyBones.RightIndexDistal);
        //#endregion

        //#region Thumb
        //RightHand.ThumbProximal.Transform = anim.GetBoneTransform(HumanBodyBones.RightThumbProximal);
        //RightHand.ThumbProximal.ThumbIntermediate.Transform = anim.GetBoneTransform(HumanBodyBones.RightThumbIntermediate);
        //RightHand.ThumbProximal.ThumbIntermediate.ThumbDistal.Transform = anim.GetBoneTransform(HumanBodyBones.RightThumbDistal);
        //#endregion

        #endregion

        #region Left

        #region Hand
        //leftHand = anim.GetBoneTransform(HumanBodyBones.LeftHand);
        #endregion

        //#region Little
        //LeftHand.LittleProximal.Transform = anim.GetBoneTransform(HumanBodyBones.LeftLittleProximal);
        //LeftHand.LittleProximal.LittleIntermediate.Transform = anim.GetBoneTransform(HumanBodyBones.LeftLittleIntermediate);
        //LeftHand.LittleProximal.LittleIntermediate.LittleDistal.Transform = anim.GetBoneTransform(HumanBodyBones.LeftLittleDistal);
        //#endregion

        //#region Ring
        //LeftHand.RingProximal.Transform = anim.GetBoneTransform(HumanBodyBones.LeftRingProximal);
        //LeftHand.RingProximal.RingIntermediate.Transform = anim.GetBoneTransform(HumanBodyBones.LeftRingIntermediate);
        //LeftHand.RingProximal.RingIntermediate.RingDistal.Transform = anim.GetBoneTransform(HumanBodyBones.LeftRingDistal);
        //#endregion

        //#region Middle
        //LeftHand.MiddleProximal.Transform = anim.GetBoneTransform(HumanBodyBones.LeftMiddleProximal);
        //LeftHand.MiddleProximal.MiddleIntermediate.Transform = anim.GetBoneTransform(HumanBodyBones.LeftMiddleIntermediate);
        //LeftHand.MiddleProximal.MiddleIntermediate.MiddleDistal.Transform = anim.GetBoneTransform(HumanBodyBones.LeftMiddleDistal);
        //#endregion

        //#region Index
        //LeftHand.IndexProximal.Transform = anim.GetBoneTransform(HumanBodyBones.LeftIndexProximal);
        //LeftHand.IndexProximal.IndexIntermediate.Transform = anim.GetBoneTransform(HumanBodyBones.LeftIndexIntermediate);
        //LeftHand.IndexProximal.IndexIntermediate.IndexDistal.Transform = anim.GetBoneTransform(HumanBodyBones.LeftIndexDistal);
        //#endregion

        //#region Thumb
        //LeftHand.ThumbProximal.Transform = anim.GetBoneTransform(HumanBodyBones.LeftThumbProximal);
        //LeftHand.ThumbProximal.ThumbIntermediate.Transform = anim.GetBoneTransform(HumanBodyBones.LeftThumbIntermediate);
        //LeftHand.ThumbProximal.ThumbIntermediate.ThumbDistal.Transform = anim.GetBoneTransform(HumanBodyBones.LeftThumbDistal);
        //#endregion

        #endregion
    }

    private void Start () {
        Init();
        //RightHand.Transform.position = weaponUse.RightHand.Transform.position;
        //LeftHand.Transform.position = weaponUse.LeftHand.Transform.position;
    }

    private void Init()
    {
        weaponUse = GetComponent<PlayerUse>().Weapon.GetComponent<WeaponUse>();
    }

    //private void Update()
    //{
    //    LeftHand.Transform.position = weaponUse.LeftHand.Transform.position;
    //    RightHand.Transform.position = weaponUse.RightHand.Transform.position;
    //}

    private void OnAnimatorIK()
    {
        RightHand = weaponUse.RightHand;
        LeftHand = weaponUse.LeftHand;

        #region RightHand
        anim.SetIKPositionWeight(AvatarIKGoal.RightHand, rightHandWeight);
        anim.SetIKPosition(AvatarIKGoal.RightHand, RightHand.position);
        anim.SetIKRotationWeight(AvatarIKGoal.RightHand, rightHandWeight);
        anim.SetIKRotation(AvatarIKGoal.RightHand, RightHand.rotation);
        #endregion

        #region LeftHand
        anim.SetIKPositionWeight(AvatarIKGoal.LeftHand, leftHandWeight);
        anim.SetIKPosition(AvatarIKGoal.LeftHand, LeftHand.position);
        anim.SetIKRotationWeight(AvatarIKGoal.LeftHand, leftHandWeight);
        anim.SetIKRotation(AvatarIKGoal.LeftHand, LeftHand.rotation);
        #endregion
    }
}
