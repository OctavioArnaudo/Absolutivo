// Copyright Epic Games, Inc. All Rights Reserved.
/*===========================================================================
	Generated code exported from UnrealHeaderTool.
	DO NOT modify this manually! Edit the corresponding .h files instead!
===========================================================================*/

// IWYU pragma: private, include "Variant_Shooter/ShooterWeapon.h"

#ifdef APP_ShooterWeapon_generated_h
#error "ShooterWeapon.generated.h already included, missing '#pragma once' in ShooterWeapon.h"
#endif
#define APP_ShooterWeapon_generated_h

#include "UObject/ObjectMacros.h"
#include "UObject/ScriptMacros.h"

PRAGMA_DISABLE_DEPRECATION_WARNINGS

class AActor;
class USkeletalMeshComponent;

// ********** Begin Class AShooterWeapon ***********************************************************
#define FID_Users_octav_Unreal_Projects_App_Source_App_Variant_Shooter_ShooterWeapon_h_26_RPC_WRAPPERS_NO_PURE_DECLS \
	DECLARE_FUNCTION(execGetThirdPersonMesh); \
	DECLARE_FUNCTION(execGetFirstPersonMesh); \
	DECLARE_FUNCTION(execOnOwnerDestroyed);


APP_API UClass* Z_Construct_UClass_AShooterWeapon_NoRegister();

#define FID_Users_octav_Unreal_Projects_App_Source_App_Variant_Shooter_ShooterWeapon_h_26_INCLASS_NO_PURE_DECLS \
private: \
	static void StaticRegisterNativesAShooterWeapon(); \
	friend struct Z_Construct_UClass_AShooterWeapon_Statics; \
	static UClass* GetPrivateStaticClass(); \
	friend APP_API UClass* Z_Construct_UClass_AShooterWeapon_NoRegister(); \
public: \
	DECLARE_CLASS2(AShooterWeapon, AActor, COMPILED_IN_FLAGS(CLASS_Abstract | CLASS_Config), CASTCLASS_None, TEXT("/Script/App"), Z_Construct_UClass_AShooterWeapon_NoRegister) \
	DECLARE_SERIALIZER(AShooterWeapon)


#define FID_Users_octav_Unreal_Projects_App_Source_App_Variant_Shooter_ShooterWeapon_h_26_ENHANCED_CONSTRUCTORS \
	/** Deleted move- and copy-constructors, should never be used */ \
	AShooterWeapon(AShooterWeapon&&) = delete; \
	AShooterWeapon(const AShooterWeapon&) = delete; \
	DECLARE_VTABLE_PTR_HELPER_CTOR(NO_API, AShooterWeapon); \
	DEFINE_VTABLE_PTR_HELPER_CTOR_CALLER(AShooterWeapon); \
	DEFINE_ABSTRACT_DEFAULT_CONSTRUCTOR_CALL(AShooterWeapon) \
	NO_API virtual ~AShooterWeapon();


#define FID_Users_octav_Unreal_Projects_App_Source_App_Variant_Shooter_ShooterWeapon_h_23_PROLOG
#define FID_Users_octav_Unreal_Projects_App_Source_App_Variant_Shooter_ShooterWeapon_h_26_GENERATED_BODY \
PRAGMA_DISABLE_DEPRECATION_WARNINGS \
public: \
	FID_Users_octav_Unreal_Projects_App_Source_App_Variant_Shooter_ShooterWeapon_h_26_RPC_WRAPPERS_NO_PURE_DECLS \
	FID_Users_octav_Unreal_Projects_App_Source_App_Variant_Shooter_ShooterWeapon_h_26_INCLASS_NO_PURE_DECLS \
	FID_Users_octav_Unreal_Projects_App_Source_App_Variant_Shooter_ShooterWeapon_h_26_ENHANCED_CONSTRUCTORS \
private: \
PRAGMA_ENABLE_DEPRECATION_WARNINGS


class AShooterWeapon;

// ********** End Class AShooterWeapon *************************************************************

#undef CURRENT_FILE_ID
#define CURRENT_FILE_ID FID_Users_octav_Unreal_Projects_App_Source_App_Variant_Shooter_ShooterWeapon_h

PRAGMA_ENABLE_DEPRECATION_WARNINGS
