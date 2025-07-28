// Copyright Epic Games, Inc. All Rights Reserved.
/*===========================================================================
	Generated code exported from UnrealHeaderTool.
	DO NOT modify this manually! Edit the corresponding .h files instead!
===========================================================================*/

// IWYU pragma: private, include "AppCameraManager.h"

#ifdef APP_AppCameraManager_generated_h
#error "AppCameraManager.generated.h already included, missing '#pragma once' in AppCameraManager.h"
#endif
#define APP_AppCameraManager_generated_h

#include "UObject/ObjectMacros.h"
#include "UObject/ScriptMacros.h"

PRAGMA_DISABLE_DEPRECATION_WARNINGS

// ********** Begin Class AAppCameraManager ********************************************************
APP_API UClass* Z_Construct_UClass_AAppCameraManager_NoRegister();

#define FID_Users_octav_Unreal_Projects_App_Source_App_AppCameraManager_h_16_INCLASS_NO_PURE_DECLS \
private: \
	static void StaticRegisterNativesAAppCameraManager(); \
	friend struct Z_Construct_UClass_AAppCameraManager_Statics; \
	static UClass* GetPrivateStaticClass(); \
	friend APP_API UClass* Z_Construct_UClass_AAppCameraManager_NoRegister(); \
public: \
	DECLARE_CLASS2(AAppCameraManager, APlayerCameraManager, COMPILED_IN_FLAGS(0 | CLASS_Transient | CLASS_Config), CASTCLASS_None, TEXT("/Script/App"), Z_Construct_UClass_AAppCameraManager_NoRegister) \
	DECLARE_SERIALIZER(AAppCameraManager)


#define FID_Users_octav_Unreal_Projects_App_Source_App_AppCameraManager_h_16_ENHANCED_CONSTRUCTORS \
	/** Deleted move- and copy-constructors, should never be used */ \
	AAppCameraManager(AAppCameraManager&&) = delete; \
	AAppCameraManager(const AAppCameraManager&) = delete; \
	DECLARE_VTABLE_PTR_HELPER_CTOR(NO_API, AAppCameraManager); \
	DEFINE_VTABLE_PTR_HELPER_CTOR_CALLER(AAppCameraManager); \
	DEFINE_DEFAULT_CONSTRUCTOR_CALL(AAppCameraManager) \
	NO_API virtual ~AAppCameraManager();


#define FID_Users_octav_Unreal_Projects_App_Source_App_AppCameraManager_h_13_PROLOG
#define FID_Users_octav_Unreal_Projects_App_Source_App_AppCameraManager_h_16_GENERATED_BODY \
PRAGMA_DISABLE_DEPRECATION_WARNINGS \
public: \
	FID_Users_octav_Unreal_Projects_App_Source_App_AppCameraManager_h_16_INCLASS_NO_PURE_DECLS \
	FID_Users_octav_Unreal_Projects_App_Source_App_AppCameraManager_h_16_ENHANCED_CONSTRUCTORS \
private: \
PRAGMA_ENABLE_DEPRECATION_WARNINGS


class AAppCameraManager;

// ********** End Class AAppCameraManager **********************************************************

#undef CURRENT_FILE_ID
#define CURRENT_FILE_ID FID_Users_octav_Unreal_Projects_App_Source_App_AppCameraManager_h

PRAGMA_ENABLE_DEPRECATION_WARNINGS
