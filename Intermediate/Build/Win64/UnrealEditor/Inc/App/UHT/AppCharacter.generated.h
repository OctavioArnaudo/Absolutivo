// Copyright Epic Games, Inc. All Rights Reserved.
/*===========================================================================
	Generated code exported from UnrealHeaderTool.
	DO NOT modify this manually! Edit the corresponding .h files instead!
===========================================================================*/

// IWYU pragma: private, include "AppCharacter.h"

#ifdef APP_AppCharacter_generated_h
#error "AppCharacter.generated.h already included, missing '#pragma once' in AppCharacter.h"
#endif
#define APP_AppCharacter_generated_h

#include "UObject/ObjectMacros.h"
#include "UObject/ScriptMacros.h"

PRAGMA_DISABLE_DEPRECATION_WARNINGS

// ********** Begin Class AAppCharacter ************************************************************
#define FID_Users_octav_Unreal_Projects_App_Source_App_AppCharacter_h_24_RPC_WRAPPERS_NO_PURE_DECLS \
	DECLARE_FUNCTION(execDoJumpEnd); \
	DECLARE_FUNCTION(execDoJumpStart); \
	DECLARE_FUNCTION(execDoMove); \
	DECLARE_FUNCTION(execDoAim);


APP_API UClass* Z_Construct_UClass_AAppCharacter_NoRegister();

#define FID_Users_octav_Unreal_Projects_App_Source_App_AppCharacter_h_24_INCLASS_NO_PURE_DECLS \
private: \
	static void StaticRegisterNativesAAppCharacter(); \
	friend struct Z_Construct_UClass_AAppCharacter_Statics; \
	static UClass* GetPrivateStaticClass(); \
	friend APP_API UClass* Z_Construct_UClass_AAppCharacter_NoRegister(); \
public: \
	DECLARE_CLASS2(AAppCharacter, ACharacter, COMPILED_IN_FLAGS(CLASS_Abstract | CLASS_Config), CASTCLASS_None, TEXT("/Script/App"), Z_Construct_UClass_AAppCharacter_NoRegister) \
	DECLARE_SERIALIZER(AAppCharacter)


#define FID_Users_octav_Unreal_Projects_App_Source_App_AppCharacter_h_24_ENHANCED_CONSTRUCTORS \
	/** Deleted move- and copy-constructors, should never be used */ \
	AAppCharacter(AAppCharacter&&) = delete; \
	AAppCharacter(const AAppCharacter&) = delete; \
	DECLARE_VTABLE_PTR_HELPER_CTOR(NO_API, AAppCharacter); \
	DEFINE_VTABLE_PTR_HELPER_CTOR_CALLER(AAppCharacter); \
	DEFINE_ABSTRACT_DEFAULT_CONSTRUCTOR_CALL(AAppCharacter) \
	NO_API virtual ~AAppCharacter();


#define FID_Users_octav_Unreal_Projects_App_Source_App_AppCharacter_h_21_PROLOG
#define FID_Users_octav_Unreal_Projects_App_Source_App_AppCharacter_h_24_GENERATED_BODY \
PRAGMA_DISABLE_DEPRECATION_WARNINGS \
public: \
	FID_Users_octav_Unreal_Projects_App_Source_App_AppCharacter_h_24_RPC_WRAPPERS_NO_PURE_DECLS \
	FID_Users_octav_Unreal_Projects_App_Source_App_AppCharacter_h_24_INCLASS_NO_PURE_DECLS \
	FID_Users_octav_Unreal_Projects_App_Source_App_AppCharacter_h_24_ENHANCED_CONSTRUCTORS \
private: \
PRAGMA_ENABLE_DEPRECATION_WARNINGS


class AAppCharacter;

// ********** End Class AAppCharacter **************************************************************

#undef CURRENT_FILE_ID
#define CURRENT_FILE_ID FID_Users_octav_Unreal_Projects_App_Source_App_AppCharacter_h

PRAGMA_ENABLE_DEPRECATION_WARNINGS
