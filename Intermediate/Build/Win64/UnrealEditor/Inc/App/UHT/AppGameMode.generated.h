// Copyright Epic Games, Inc. All Rights Reserved.
/*===========================================================================
	Generated code exported from UnrealHeaderTool.
	DO NOT modify this manually! Edit the corresponding .h files instead!
===========================================================================*/

// IWYU pragma: private, include "AppGameMode.h"

#ifdef APP_AppGameMode_generated_h
#error "AppGameMode.generated.h already included, missing '#pragma once' in AppGameMode.h"
#endif
#define APP_AppGameMode_generated_h

#include "UObject/ObjectMacros.h"
#include "UObject/ScriptMacros.h"

PRAGMA_DISABLE_DEPRECATION_WARNINGS

// ********** Begin Class AAppGameMode *************************************************************
APP_API UClass* Z_Construct_UClass_AAppGameMode_NoRegister();

#define FID_Users_octav_Unreal_Projects_App_Source_App_AppGameMode_h_15_INCLASS_NO_PURE_DECLS \
private: \
	static void StaticRegisterNativesAAppGameMode(); \
	friend struct Z_Construct_UClass_AAppGameMode_Statics; \
	static UClass* GetPrivateStaticClass(); \
	friend APP_API UClass* Z_Construct_UClass_AAppGameMode_NoRegister(); \
public: \
	DECLARE_CLASS2(AAppGameMode, AGameModeBase, COMPILED_IN_FLAGS(CLASS_Abstract | CLASS_Transient | CLASS_Config), CASTCLASS_None, TEXT("/Script/App"), Z_Construct_UClass_AAppGameMode_NoRegister) \
	DECLARE_SERIALIZER(AAppGameMode)


#define FID_Users_octav_Unreal_Projects_App_Source_App_AppGameMode_h_15_ENHANCED_CONSTRUCTORS \
	/** Deleted move- and copy-constructors, should never be used */ \
	AAppGameMode(AAppGameMode&&) = delete; \
	AAppGameMode(const AAppGameMode&) = delete; \
	DECLARE_VTABLE_PTR_HELPER_CTOR(NO_API, AAppGameMode); \
	DEFINE_VTABLE_PTR_HELPER_CTOR_CALLER(AAppGameMode); \
	DEFINE_ABSTRACT_DEFAULT_CONSTRUCTOR_CALL(AAppGameMode) \
	NO_API virtual ~AAppGameMode();


#define FID_Users_octav_Unreal_Projects_App_Source_App_AppGameMode_h_12_PROLOG
#define FID_Users_octav_Unreal_Projects_App_Source_App_AppGameMode_h_15_GENERATED_BODY \
PRAGMA_DISABLE_DEPRECATION_WARNINGS \
public: \
	FID_Users_octav_Unreal_Projects_App_Source_App_AppGameMode_h_15_INCLASS_NO_PURE_DECLS \
	FID_Users_octav_Unreal_Projects_App_Source_App_AppGameMode_h_15_ENHANCED_CONSTRUCTORS \
private: \
PRAGMA_ENABLE_DEPRECATION_WARNINGS


class AAppGameMode;

// ********** End Class AAppGameMode ***************************************************************

#undef CURRENT_FILE_ID
#define CURRENT_FILE_ID FID_Users_octav_Unreal_Projects_App_Source_App_AppGameMode_h

PRAGMA_ENABLE_DEPRECATION_WARNINGS
