// Copyright Epic Games, Inc. All Rights Reserved.
/*===========================================================================
	Generated code exported from UnrealHeaderTool.
	DO NOT modify this manually! Edit the corresponding .h files instead!
===========================================================================*/

#include "UObject/GeneratedCppIncludes.h"
#include "App/AppGameMode.h"

PRAGMA_DISABLE_DEPRECATION_WARNINGS

void EmptyLinkFunctionForGeneratedCodeAppGameMode() {}

// ********** Begin Cross Module References ********************************************************
APP_API UClass* Z_Construct_UClass_AAppGameMode();
APP_API UClass* Z_Construct_UClass_AAppGameMode_NoRegister();
ENGINE_API UClass* Z_Construct_UClass_AGameModeBase();
UPackage* Z_Construct_UPackage__Script_App();
// ********** End Cross Module References **********************************************************

// ********** Begin Class AAppGameMode *************************************************************
void AAppGameMode::StaticRegisterNativesAAppGameMode()
{
}
FClassRegistrationInfo Z_Registration_Info_UClass_AAppGameMode;
UClass* AAppGameMode::GetPrivateStaticClass()
{
	using TClass = AAppGameMode;
	if (!Z_Registration_Info_UClass_AAppGameMode.InnerSingleton)
	{
		GetPrivateStaticClassBody(
			StaticPackage(),
			TEXT("AppGameMode"),
			Z_Registration_Info_UClass_AAppGameMode.InnerSingleton,
			StaticRegisterNativesAAppGameMode,
			sizeof(TClass),
			alignof(TClass),
			TClass::StaticClassFlags,
			TClass::StaticClassCastFlags(),
			TClass::StaticConfigName(),
			(UClass::ClassConstructorType)InternalConstructor<TClass>,
			(UClass::ClassVTableHelperCtorCallerType)InternalVTableHelperCtorCaller<TClass>,
			UOBJECT_CPPCLASS_STATICFUNCTIONS_FORCLASS(TClass),
			&TClass::Super::StaticClass,
			&TClass::WithinClass::StaticClass
		);
	}
	return Z_Registration_Info_UClass_AAppGameMode.InnerSingleton;
}
UClass* Z_Construct_UClass_AAppGameMode_NoRegister()
{
	return AAppGameMode::GetPrivateStaticClass();
}
struct Z_Construct_UClass_AAppGameMode_Statics
{
#if WITH_METADATA
	static constexpr UECodeGen_Private::FMetaDataPairParam Class_MetaDataParams[] = {
#if !UE_BUILD_SHIPPING
		{ "Comment", "/**\n *  Simple GameMode for a first person game\n */" },
#endif
		{ "HideCategories", "Info Rendering MovementReplication Replication Actor Input Movement Collision Rendering HLOD WorldPartition DataLayers Transformation" },
		{ "IncludePath", "AppGameMode.h" },
		{ "ModuleRelativePath", "AppGameMode.h" },
		{ "ShowCategories", "Input|MouseInput Input|TouchInput" },
#if !UE_BUILD_SHIPPING
		{ "ToolTip", "Simple GameMode for a first person game" },
#endif
	};
#endif // WITH_METADATA
	static UObject* (*const DependentSingletons[])();
	static constexpr FCppClassTypeInfoStatic StaticCppClassTypeInfo = {
		TCppClassTypeTraits<AAppGameMode>::IsAbstract,
	};
	static const UECodeGen_Private::FClassParams ClassParams;
};
UObject* (*const Z_Construct_UClass_AAppGameMode_Statics::DependentSingletons[])() = {
	(UObject* (*)())Z_Construct_UClass_AGameModeBase,
	(UObject* (*)())Z_Construct_UPackage__Script_App,
};
static_assert(UE_ARRAY_COUNT(Z_Construct_UClass_AAppGameMode_Statics::DependentSingletons) < 16);
const UECodeGen_Private::FClassParams Z_Construct_UClass_AAppGameMode_Statics::ClassParams = {
	&AAppGameMode::StaticClass,
	"Game",
	&StaticCppClassTypeInfo,
	DependentSingletons,
	nullptr,
	nullptr,
	nullptr,
	UE_ARRAY_COUNT(DependentSingletons),
	0,
	0,
	0,
	0x008003ADu,
	METADATA_PARAMS(UE_ARRAY_COUNT(Z_Construct_UClass_AAppGameMode_Statics::Class_MetaDataParams), Z_Construct_UClass_AAppGameMode_Statics::Class_MetaDataParams)
};
UClass* Z_Construct_UClass_AAppGameMode()
{
	if (!Z_Registration_Info_UClass_AAppGameMode.OuterSingleton)
	{
		UECodeGen_Private::ConstructUClass(Z_Registration_Info_UClass_AAppGameMode.OuterSingleton, Z_Construct_UClass_AAppGameMode_Statics::ClassParams);
	}
	return Z_Registration_Info_UClass_AAppGameMode.OuterSingleton;
}
DEFINE_VTABLE_PTR_HELPER_CTOR(AAppGameMode);
AAppGameMode::~AAppGameMode() {}
// ********** End Class AAppGameMode ***************************************************************

// ********** Begin Registration *******************************************************************
struct Z_CompiledInDeferFile_FID_Users_octav_Unreal_Projects_App_Source_App_AppGameMode_h__Script_App_Statics
{
	static constexpr FClassRegisterCompiledInInfo ClassInfo[] = {
		{ Z_Construct_UClass_AAppGameMode, AAppGameMode::StaticClass, TEXT("AAppGameMode"), &Z_Registration_Info_UClass_AAppGameMode, CONSTRUCT_RELOAD_VERSION_INFO(FClassReloadVersionInfo, sizeof(AAppGameMode), 2353628832U) },
	};
};
static FRegisterCompiledInInfo Z_CompiledInDeferFile_FID_Users_octav_Unreal_Projects_App_Source_App_AppGameMode_h__Script_App_728030894(TEXT("/Script/App"),
	Z_CompiledInDeferFile_FID_Users_octav_Unreal_Projects_App_Source_App_AppGameMode_h__Script_App_Statics::ClassInfo, UE_ARRAY_COUNT(Z_CompiledInDeferFile_FID_Users_octav_Unreal_Projects_App_Source_App_AppGameMode_h__Script_App_Statics::ClassInfo),
	nullptr, 0,
	nullptr, 0);
// ********** End Registration *********************************************************************

PRAGMA_ENABLE_DEPRECATION_WARNINGS
