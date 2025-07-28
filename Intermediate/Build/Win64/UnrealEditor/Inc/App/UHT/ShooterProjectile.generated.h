// Copyright Epic Games, Inc. All Rights Reserved.
/*===========================================================================
	Generated code exported from UnrealHeaderTool.
	DO NOT modify this manually! Edit the corresponding .h files instead!
===========================================================================*/

// IWYU pragma: private, include "Variant_Shooter/ShooterProjectile.h"

#ifdef APP_ShooterProjectile_generated_h
#error "ShooterProjectile.generated.h already included, missing '#pragma once' in ShooterProjectile.h"
#endif
#define APP_ShooterProjectile_generated_h

#include "UObject/ObjectMacros.h"
#include "UObject/ScriptMacros.h"

PRAGMA_DISABLE_DEPRECATION_WARNINGS

class ACharacter;
struct FHitResult;

// ********** Begin Class AShooterProjectile *******************************************************
#define FID_Users_octav_Unreal_Projects_App_Source_App_Variant_Shooter_ShooterProjectile_h_19_RPC_WRAPPERS_NO_PURE_DECLS \
	DECLARE_FUNCTION(execDamageCharacter);


#define FID_Users_octav_Unreal_Projects_App_Source_App_Variant_Shooter_ShooterProjectile_h_19_CALLBACK_WRAPPERS
APP_API UClass* Z_Construct_UClass_AShooterProjectile_NoRegister();

#define FID_Users_octav_Unreal_Projects_App_Source_App_Variant_Shooter_ShooterProjectile_h_19_INCLASS_NO_PURE_DECLS \
private: \
	static void StaticRegisterNativesAShooterProjectile(); \
	friend struct Z_Construct_UClass_AShooterProjectile_Statics; \
	static UClass* GetPrivateStaticClass(); \
	friend APP_API UClass* Z_Construct_UClass_AShooterProjectile_NoRegister(); \
public: \
	DECLARE_CLASS2(AShooterProjectile, AActor, COMPILED_IN_FLAGS(CLASS_Abstract | CLASS_Config), CASTCLASS_None, TEXT("/Script/App"), Z_Construct_UClass_AShooterProjectile_NoRegister) \
	DECLARE_SERIALIZER(AShooterProjectile)


#define FID_Users_octav_Unreal_Projects_App_Source_App_Variant_Shooter_ShooterProjectile_h_19_ENHANCED_CONSTRUCTORS \
	/** Deleted move- and copy-constructors, should never be used */ \
	AShooterProjectile(AShooterProjectile&&) = delete; \
	AShooterProjectile(const AShooterProjectile&) = delete; \
	DECLARE_VTABLE_PTR_HELPER_CTOR(NO_API, AShooterProjectile); \
	DEFINE_VTABLE_PTR_HELPER_CTOR_CALLER(AShooterProjectile); \
	DEFINE_ABSTRACT_DEFAULT_CONSTRUCTOR_CALL(AShooterProjectile) \
	NO_API virtual ~AShooterProjectile();


#define FID_Users_octav_Unreal_Projects_App_Source_App_Variant_Shooter_ShooterProjectile_h_16_PROLOG
#define FID_Users_octav_Unreal_Projects_App_Source_App_Variant_Shooter_ShooterProjectile_h_19_GENERATED_BODY \
PRAGMA_DISABLE_DEPRECATION_WARNINGS \
public: \
	FID_Users_octav_Unreal_Projects_App_Source_App_Variant_Shooter_ShooterProjectile_h_19_RPC_WRAPPERS_NO_PURE_DECLS \
	FID_Users_octav_Unreal_Projects_App_Source_App_Variant_Shooter_ShooterProjectile_h_19_CALLBACK_WRAPPERS \
	FID_Users_octav_Unreal_Projects_App_Source_App_Variant_Shooter_ShooterProjectile_h_19_INCLASS_NO_PURE_DECLS \
	FID_Users_octav_Unreal_Projects_App_Source_App_Variant_Shooter_ShooterProjectile_h_19_ENHANCED_CONSTRUCTORS \
private: \
PRAGMA_ENABLE_DEPRECATION_WARNINGS


class AShooterProjectile;

// ********** End Class AShooterProjectile *********************************************************

#undef CURRENT_FILE_ID
#define CURRENT_FILE_ID FID_Users_octav_Unreal_Projects_App_Source_App_Variant_Shooter_ShooterProjectile_h

PRAGMA_ENABLE_DEPRECATION_WARNINGS
