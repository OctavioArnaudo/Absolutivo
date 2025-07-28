// Copyright Epic Games, Inc. All Rights Reserved.
/*===========================================================================
	Generated code exported from UnrealHeaderTool.
	DO NOT modify this manually! Edit the corresponding .h files instead!
===========================================================================*/

// IWYU pragma: private, include "AppPlayerController.h"

#ifdef APP_AppPlayerController_generated_h
#error "AppPlayerController.generated.h already included, missing '#pragma once' in AppPlayerController.h"
#endif
#define APP_AppPlayerController_generated_h

#include "UObject/ObjectMacros.h"
#include "UObject/ScriptMacros.h"

PRAGMA_DISABLE_DEPRECATION_WARNINGS

// ********** Begin Class AAppPlayerController *****************************************************
APP_API UClass* Z_Construct_UClass_AAppPlayerController_NoRegister();

#define FID_Users_octav_Unreal_Projects_App_Source_App_AppPlayerController_h_19_INCLASS_NO_PURE_DECLS \
private: \
	static void StaticRegisterNativesAAppPlayerController(); \
	friend struct Z_Construct_UClass_AAppPlayerController_Statics; \
	static UClass* GetPrivateStaticClass(); \
	friend APP_API UClass* Z_Construct_UClass_AAppPlayerController_NoRegister(); \
public: \
	DECLARE_CLASS2(AAppPlayerController, APlayerController, COMPILED_IN_FLAGS(CLASS_Abstract | CLASS_Config), CASTCLASS_None, TEXT("/Script/App"), Z_Construct_UClass_AAppPlayerController_NoRegister) \
	DECLARE_SERIALIZER(AAppPlayerController)


#define FID_Users_octav_Unreal_Projects_App_Source_App_AppPlayerController_h_19_ENHANCED_CONSTRUCTORS \
	/** Deleted move- and copy-constructors, should never be used */ \
	AAppPlayerController(AAppPlayerController&&) = delete; \
	AAppPlayerController(const AAppPlayerController&) = delete; \
	DECLARE_VTABLE_PTR_HELPER_CTOR(NO_API, AAppPlayerController); \
	DEFINE_VTABLE_PTR_HELPER_CTOR_CALLER(AAppPlayerController); \
	DEFINE_ABSTRACT_DEFAULT_CONSTRUCTOR_CALL(AAppPlayerController) \
	NO_API virtual ~AAppPlayerController();


#define FID_Users_octav_Unreal_Projects_App_Source_App_AppPlayerController_h_16_PROLOG
#define FID_Users_octav_Unreal_Projects_App_Source_App_AppPlayerController_h_19_GENERATED_BODY \
PRAGMA_DISABLE_DEPRECATION_WARNINGS \
public: \
	FID_Users_octav_Unreal_Projects_App_Source_App_AppPlayerController_h_19_INCLASS_NO_PURE_DECLS \
	FID_Users_octav_Unreal_Projects_App_Source_App_AppPlayerController_h_19_ENHANCED_CONSTRUCTORS \
private: \
PRAGMA_ENABLE_DEPRECATION_WARNINGS


class AAppPlayerController;

// ********** End Class AAppPlayerController *******************************************************

#undef CURRENT_FILE_ID
#define CURRENT_FILE_ID FID_Users_octav_Unreal_Projects_App_Source_App_AppPlayerController_h

PRAGMA_ENABLE_DEPRECATION_WARNINGS
