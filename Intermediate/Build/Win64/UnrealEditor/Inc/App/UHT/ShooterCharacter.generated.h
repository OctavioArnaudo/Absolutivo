// Copyright Epic Games, Inc. All Rights Reserved.
/*===========================================================================
	Generated code exported from UnrealHeaderTool.
	DO NOT modify this manually! Edit the corresponding .h files instead!
===========================================================================*/

// IWYU pragma: private, include "Variant_Shooter/ShooterCharacter.h"

#ifdef APP_ShooterCharacter_generated_h
#error "ShooterCharacter.generated.h already included, missing '#pragma once' in ShooterCharacter.h"
#endif
#define APP_ShooterCharacter_generated_h

#include "UObject/ObjectMacros.h"
#include "UObject/ScriptMacros.h"

PRAGMA_DISABLE_DEPRECATION_WARNINGS

// ********** Begin Delegate FBulletCountUpdatedDelegate *******************************************
#define FID_Users_octav_Unreal_Projects_App_Source_App_Variant_Shooter_ShooterCharacter_h_15_DELEGATE \
APP_API void FBulletCountUpdatedDelegate_DelegateWrapper(const FMulticastScriptDelegate& BulletCountUpdatedDelegate, int32 MagazineSize, int32 Bullets);


// ********** End Delegate FBulletCountUpdatedDelegate *********************************************

// ********** Begin Class AShooterCharacter ********************************************************
#define FID_Users_octav_Unreal_Projects_App_Source_App_Variant_Shooter_ShooterCharacter_h_25_RPC_WRAPPERS_NO_PURE_DECLS \
	DECLARE_FUNCTION(execDoSwitchWeapon); \
	DECLARE_FUNCTION(execDoStopFiring); \
	DECLARE_FUNCTION(execDoStartFiring);


APP_API UClass* Z_Construct_UClass_AShooterCharacter_NoRegister();

#define FID_Users_octav_Unreal_Projects_App_Source_App_Variant_Shooter_ShooterCharacter_h_25_INCLASS_NO_PURE_DECLS \
private: \
	static void StaticRegisterNativesAShooterCharacter(); \
	friend struct Z_Construct_UClass_AShooterCharacter_Statics; \
	static UClass* GetPrivateStaticClass(); \
	friend APP_API UClass* Z_Construct_UClass_AShooterCharacter_NoRegister(); \
public: \
	DECLARE_CLASS2(AShooterCharacter, AAppCharacter, COMPILED_IN_FLAGS(CLASS_Abstract | CLASS_Config), CASTCLASS_None, TEXT("/Script/App"), Z_Construct_UClass_AShooterCharacter_NoRegister) \
	DECLARE_SERIALIZER(AShooterCharacter) \
	virtual UObject* _getUObject() const override { return const_cast<AShooterCharacter*>(this); }


#define FID_Users_octav_Unreal_Projects_App_Source_App_Variant_Shooter_ShooterCharacter_h_25_ENHANCED_CONSTRUCTORS \
	/** Deleted move- and copy-constructors, should never be used */ \
	AShooterCharacter(AShooterCharacter&&) = delete; \
	AShooterCharacter(const AShooterCharacter&) = delete; \
	DECLARE_VTABLE_PTR_HELPER_CTOR(NO_API, AShooterCharacter); \
	DEFINE_VTABLE_PTR_HELPER_CTOR_CALLER(AShooterCharacter); \
	DEFINE_ABSTRACT_DEFAULT_CONSTRUCTOR_CALL(AShooterCharacter) \
	NO_API virtual ~AShooterCharacter();


#define FID_Users_octav_Unreal_Projects_App_Source_App_Variant_Shooter_ShooterCharacter_h_22_PROLOG
#define FID_Users_octav_Unreal_Projects_App_Source_App_Variant_Shooter_ShooterCharacter_h_25_GENERATED_BODY \
PRAGMA_DISABLE_DEPRECATION_WARNINGS \
public: \
	FID_Users_octav_Unreal_Projects_App_Source_App_Variant_Shooter_ShooterCharacter_h_25_RPC_WRAPPERS_NO_PURE_DECLS \
	FID_Users_octav_Unreal_Projects_App_Source_App_Variant_Shooter_ShooterCharacter_h_25_INCLASS_NO_PURE_DECLS \
	FID_Users_octav_Unreal_Projects_App_Source_App_Variant_Shooter_ShooterCharacter_h_25_ENHANCED_CONSTRUCTORS \
private: \
PRAGMA_ENABLE_DEPRECATION_WARNINGS


class AShooterCharacter;

// ********** End Class AShooterCharacter **********************************************************

#undef CURRENT_FILE_ID
#define CURRENT_FILE_ID FID_Users_octav_Unreal_Projects_App_Source_App_Variant_Shooter_ShooterCharacter_h

PRAGMA_ENABLE_DEPRECATION_WARNINGS
