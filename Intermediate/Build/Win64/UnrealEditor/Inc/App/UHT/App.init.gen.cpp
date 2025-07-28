// Copyright Epic Games, Inc. All Rights Reserved.
/*===========================================================================
	Generated code exported from UnrealHeaderTool.
	DO NOT modify this manually! Edit the corresponding .h files instead!
===========================================================================*/

#include "UObject/GeneratedCppIncludes.h"
PRAGMA_DISABLE_DEPRECATION_WARNINGS
void EmptyLinkFunctionForGeneratedCodeApp_init() {}
	APP_API UFunction* Z_Construct_UDelegateFunction_App_BulletCountUpdatedDelegate__DelegateSignature();
	APP_API UFunction* Z_Construct_UDelegateFunction_App_PawnDeathDelegate__DelegateSignature();
	APP_API UFunction* Z_Construct_UDelegateFunction_App_SprintStateChangedDelegate__DelegateSignature();
	APP_API UFunction* Z_Construct_UDelegateFunction_App_UpdateSprintMeterDelegate__DelegateSignature();
	static FPackageRegistrationInfo Z_Registration_Info_UPackage__Script_App;
	FORCENOINLINE UPackage* Z_Construct_UPackage__Script_App()
	{
		if (!Z_Registration_Info_UPackage__Script_App.OuterSingleton)
		{
			static UObject* (*const SingletonFuncArray[])() = {
				(UObject* (*)())Z_Construct_UDelegateFunction_App_BulletCountUpdatedDelegate__DelegateSignature,
				(UObject* (*)())Z_Construct_UDelegateFunction_App_PawnDeathDelegate__DelegateSignature,
				(UObject* (*)())Z_Construct_UDelegateFunction_App_SprintStateChangedDelegate__DelegateSignature,
				(UObject* (*)())Z_Construct_UDelegateFunction_App_UpdateSprintMeterDelegate__DelegateSignature,
			};
			static const UECodeGen_Private::FPackageParams PackageParams = {
				"/Script/App",
				SingletonFuncArray,
				UE_ARRAY_COUNT(SingletonFuncArray),
				PKG_CompiledIn | 0x00000000,
				0x61440FA9,
				0xD09440A2,
				METADATA_PARAMS(0, nullptr)
			};
			UECodeGen_Private::ConstructUPackage(Z_Registration_Info_UPackage__Script_App.OuterSingleton, PackageParams);
		}
		return Z_Registration_Info_UPackage__Script_App.OuterSingleton;
	}
	static FRegisterCompiledInInfo Z_CompiledInDeferPackage_UPackage__Script_App(Z_Construct_UPackage__Script_App, TEXT("/Script/App"), Z_Registration_Info_UPackage__Script_App, CONSTRUCT_RELOAD_VERSION_INFO(FPackageReloadVersionInfo, 0x61440FA9, 0xD09440A2));
PRAGMA_ENABLE_DEPRECATION_WARNINGS
