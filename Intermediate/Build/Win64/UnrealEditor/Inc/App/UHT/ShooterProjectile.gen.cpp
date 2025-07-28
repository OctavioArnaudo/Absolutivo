// Copyright Epic Games, Inc. All Rights Reserved.
/*===========================================================================
	Generated code exported from UnrealHeaderTool.
	DO NOT modify this manually! Edit the corresponding .h files instead!
===========================================================================*/

#include "UObject/GeneratedCppIncludes.h"
#include "App/Variant_Shooter/ShooterProjectile.h"
#include "Engine/HitResult.h"

PRAGMA_DISABLE_DEPRECATION_WARNINGS

void EmptyLinkFunctionForGeneratedCodeShooterProjectile() {}

// ********** Begin Cross Module References ********************************************************
APP_API UClass* Z_Construct_UClass_AShooterProjectile();
APP_API UClass* Z_Construct_UClass_AShooterProjectile_NoRegister();
COREUOBJECT_API UClass* Z_Construct_UClass_UClass();
ENGINE_API UClass* Z_Construct_UClass_AActor();
ENGINE_API UClass* Z_Construct_UClass_ACharacter_NoRegister();
ENGINE_API UClass* Z_Construct_UClass_UDamageType_NoRegister();
ENGINE_API UClass* Z_Construct_UClass_UProjectileMovementComponent_NoRegister();
ENGINE_API UClass* Z_Construct_UClass_USphereComponent_NoRegister();
ENGINE_API UScriptStruct* Z_Construct_UScriptStruct_FHitResult();
UPackage* Z_Construct_UPackage__Script_App();
// ********** End Cross Module References **********************************************************

// ********** Begin Class AShooterProjectile Function BP_OnProjectileHit ***************************
struct ShooterProjectile_eventBP_OnProjectileHit_Parms
{
	FHitResult Hit;
};
static FName NAME_AShooterProjectile_BP_OnProjectileHit = FName(TEXT("BP_OnProjectileHit"));
void AShooterProjectile::BP_OnProjectileHit(FHitResult const& Hit)
{
	ShooterProjectile_eventBP_OnProjectileHit_Parms Parms;
	Parms.Hit=Hit;
	UFunction* Func = FindFunctionChecked(NAME_AShooterProjectile_BP_OnProjectileHit);
	ProcessEvent(Func,&Parms);
}
struct Z_Construct_UFunction_AShooterProjectile_BP_OnProjectileHit_Statics
{
#if WITH_METADATA
	static constexpr UECodeGen_Private::FMetaDataPairParam Function_MetaDataParams[] = {
		{ "Category", "Projectile" },
#if !UE_BUILD_SHIPPING
		{ "Comment", "/** Passes control to Blueprint to implement any effects on hit */" },
#endif
		{ "DisplayName", "On Projectile Hit" },
		{ "ModuleRelativePath", "Variant_Shooter/ShooterProjectile.h" },
#if !UE_BUILD_SHIPPING
		{ "ToolTip", "Passes control to Blueprint to implement any effects on hit" },
#endif
	};
	static constexpr UECodeGen_Private::FMetaDataPairParam NewProp_Hit_MetaData[] = {
		{ "NativeConst", "" },
	};
#endif // WITH_METADATA
	static const UECodeGen_Private::FStructPropertyParams NewProp_Hit;
	static const UECodeGen_Private::FPropertyParamsBase* const PropPointers[];
	static const UECodeGen_Private::FFunctionParams FuncParams;
};
const UECodeGen_Private::FStructPropertyParams Z_Construct_UFunction_AShooterProjectile_BP_OnProjectileHit_Statics::NewProp_Hit = { "Hit", nullptr, (EPropertyFlags)0x0010008008000182, UECodeGen_Private::EPropertyGenFlags::Struct, RF_Public|RF_Transient|RF_MarkAsNative, nullptr, nullptr, 1, STRUCT_OFFSET(ShooterProjectile_eventBP_OnProjectileHit_Parms, Hit), Z_Construct_UScriptStruct_FHitResult, METADATA_PARAMS(UE_ARRAY_COUNT(NewProp_Hit_MetaData), NewProp_Hit_MetaData) }; // 267591329
const UECodeGen_Private::FPropertyParamsBase* const Z_Construct_UFunction_AShooterProjectile_BP_OnProjectileHit_Statics::PropPointers[] = {
	(const UECodeGen_Private::FPropertyParamsBase*)&Z_Construct_UFunction_AShooterProjectile_BP_OnProjectileHit_Statics::NewProp_Hit,
};
static_assert(UE_ARRAY_COUNT(Z_Construct_UFunction_AShooterProjectile_BP_OnProjectileHit_Statics::PropPointers) < 2048);
const UECodeGen_Private::FFunctionParams Z_Construct_UFunction_AShooterProjectile_BP_OnProjectileHit_Statics::FuncParams = { { (UObject*(*)())Z_Construct_UClass_AShooterProjectile, nullptr, "BP_OnProjectileHit", Z_Construct_UFunction_AShooterProjectile_BP_OnProjectileHit_Statics::PropPointers, UE_ARRAY_COUNT(Z_Construct_UFunction_AShooterProjectile_BP_OnProjectileHit_Statics::PropPointers), sizeof(ShooterProjectile_eventBP_OnProjectileHit_Parms), RF_Public|RF_Transient|RF_MarkAsNative, (EFunctionFlags)0x08480800, 0, 0, METADATA_PARAMS(UE_ARRAY_COUNT(Z_Construct_UFunction_AShooterProjectile_BP_OnProjectileHit_Statics::Function_MetaDataParams), Z_Construct_UFunction_AShooterProjectile_BP_OnProjectileHit_Statics::Function_MetaDataParams)},  };
static_assert(sizeof(ShooterProjectile_eventBP_OnProjectileHit_Parms) < MAX_uint16);
UFunction* Z_Construct_UFunction_AShooterProjectile_BP_OnProjectileHit()
{
	static UFunction* ReturnFunction = nullptr;
	if (!ReturnFunction)
	{
		UECodeGen_Private::ConstructUFunction(&ReturnFunction, Z_Construct_UFunction_AShooterProjectile_BP_OnProjectileHit_Statics::FuncParams);
	}
	return ReturnFunction;
}
// ********** End Class AShooterProjectile Function BP_OnProjectileHit *****************************

// ********** Begin Class AShooterProjectile Function DamageCharacter ******************************
struct Z_Construct_UFunction_AShooterProjectile_DamageCharacter_Statics
{
	struct ShooterProjectile_eventDamageCharacter_Parms
	{
		ACharacter* HitCharacter;
		FHitResult Hit;
	};
#if WITH_METADATA
	static constexpr UECodeGen_Private::FMetaDataPairParam Function_MetaDataParams[] = {
		{ "Category", "Projectile" },
#if !UE_BUILD_SHIPPING
		{ "Comment", "/** Apply damage to a hit character */" },
#endif
		{ "ModuleRelativePath", "Variant_Shooter/ShooterProjectile.h" },
#if !UE_BUILD_SHIPPING
		{ "ToolTip", "Apply damage to a hit character" },
#endif
	};
	static constexpr UECodeGen_Private::FMetaDataPairParam NewProp_Hit_MetaData[] = {
		{ "NativeConst", "" },
	};
#endif // WITH_METADATA
	static const UECodeGen_Private::FObjectPropertyParams NewProp_HitCharacter;
	static const UECodeGen_Private::FStructPropertyParams NewProp_Hit;
	static const UECodeGen_Private::FPropertyParamsBase* const PropPointers[];
	static const UECodeGen_Private::FFunctionParams FuncParams;
};
const UECodeGen_Private::FObjectPropertyParams Z_Construct_UFunction_AShooterProjectile_DamageCharacter_Statics::NewProp_HitCharacter = { "HitCharacter", nullptr, (EPropertyFlags)0x0010000000000080, UECodeGen_Private::EPropertyGenFlags::Object, RF_Public|RF_Transient|RF_MarkAsNative, nullptr, nullptr, 1, STRUCT_OFFSET(ShooterProjectile_eventDamageCharacter_Parms, HitCharacter), Z_Construct_UClass_ACharacter_NoRegister, METADATA_PARAMS(0, nullptr) };
const UECodeGen_Private::FStructPropertyParams Z_Construct_UFunction_AShooterProjectile_DamageCharacter_Statics::NewProp_Hit = { "Hit", nullptr, (EPropertyFlags)0x0010008008000182, UECodeGen_Private::EPropertyGenFlags::Struct, RF_Public|RF_Transient|RF_MarkAsNative, nullptr, nullptr, 1, STRUCT_OFFSET(ShooterProjectile_eventDamageCharacter_Parms, Hit), Z_Construct_UScriptStruct_FHitResult, METADATA_PARAMS(UE_ARRAY_COUNT(NewProp_Hit_MetaData), NewProp_Hit_MetaData) }; // 267591329
const UECodeGen_Private::FPropertyParamsBase* const Z_Construct_UFunction_AShooterProjectile_DamageCharacter_Statics::PropPointers[] = {
	(const UECodeGen_Private::FPropertyParamsBase*)&Z_Construct_UFunction_AShooterProjectile_DamageCharacter_Statics::NewProp_HitCharacter,
	(const UECodeGen_Private::FPropertyParamsBase*)&Z_Construct_UFunction_AShooterProjectile_DamageCharacter_Statics::NewProp_Hit,
};
static_assert(UE_ARRAY_COUNT(Z_Construct_UFunction_AShooterProjectile_DamageCharacter_Statics::PropPointers) < 2048);
const UECodeGen_Private::FFunctionParams Z_Construct_UFunction_AShooterProjectile_DamageCharacter_Statics::FuncParams = { { (UObject*(*)())Z_Construct_UClass_AShooterProjectile, nullptr, "DamageCharacter", Z_Construct_UFunction_AShooterProjectile_DamageCharacter_Statics::PropPointers, UE_ARRAY_COUNT(Z_Construct_UFunction_AShooterProjectile_DamageCharacter_Statics::PropPointers), sizeof(Z_Construct_UFunction_AShooterProjectile_DamageCharacter_Statics::ShooterProjectile_eventDamageCharacter_Parms), RF_Public|RF_Transient|RF_MarkAsNative, (EFunctionFlags)0x04480400, 0, 0, METADATA_PARAMS(UE_ARRAY_COUNT(Z_Construct_UFunction_AShooterProjectile_DamageCharacter_Statics::Function_MetaDataParams), Z_Construct_UFunction_AShooterProjectile_DamageCharacter_Statics::Function_MetaDataParams)},  };
static_assert(sizeof(Z_Construct_UFunction_AShooterProjectile_DamageCharacter_Statics::ShooterProjectile_eventDamageCharacter_Parms) < MAX_uint16);
UFunction* Z_Construct_UFunction_AShooterProjectile_DamageCharacter()
{
	static UFunction* ReturnFunction = nullptr;
	if (!ReturnFunction)
	{
		UECodeGen_Private::ConstructUFunction(&ReturnFunction, Z_Construct_UFunction_AShooterProjectile_DamageCharacter_Statics::FuncParams);
	}
	return ReturnFunction;
}
DEFINE_FUNCTION(AShooterProjectile::execDamageCharacter)
{
	P_GET_OBJECT(ACharacter,Z_Param_HitCharacter);
	P_GET_STRUCT_REF(FHitResult,Z_Param_Out_Hit);
	P_FINISH;
	P_NATIVE_BEGIN;
	P_THIS->DamageCharacter(Z_Param_HitCharacter,Z_Param_Out_Hit);
	P_NATIVE_END;
}
// ********** End Class AShooterProjectile Function DamageCharacter ********************************

// ********** Begin Class AShooterProjectile *******************************************************
void AShooterProjectile::StaticRegisterNativesAShooterProjectile()
{
	UClass* Class = AShooterProjectile::StaticClass();
	static const FNameNativePtrPair Funcs[] = {
		{ "DamageCharacter", &AShooterProjectile::execDamageCharacter },
	};
	FNativeFunctionRegistrar::RegisterFunctions(Class, Funcs, UE_ARRAY_COUNT(Funcs));
}
FClassRegistrationInfo Z_Registration_Info_UClass_AShooterProjectile;
UClass* AShooterProjectile::GetPrivateStaticClass()
{
	using TClass = AShooterProjectile;
	if (!Z_Registration_Info_UClass_AShooterProjectile.InnerSingleton)
	{
		GetPrivateStaticClassBody(
			StaticPackage(),
			TEXT("ShooterProjectile"),
			Z_Registration_Info_UClass_AShooterProjectile.InnerSingleton,
			StaticRegisterNativesAShooterProjectile,
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
	return Z_Registration_Info_UClass_AShooterProjectile.InnerSingleton;
}
UClass* Z_Construct_UClass_AShooterProjectile_NoRegister()
{
	return AShooterProjectile::GetPrivateStaticClass();
}
struct Z_Construct_UClass_AShooterProjectile_Statics
{
#if WITH_METADATA
	static constexpr UECodeGen_Private::FMetaDataPairParam Class_MetaDataParams[] = {
#if !UE_BUILD_SHIPPING
		{ "Comment", "/**\n *  Simple projectile class for a first person shooter game\n */" },
#endif
		{ "IncludePath", "Variant_Shooter/ShooterProjectile.h" },
		{ "ModuleRelativePath", "Variant_Shooter/ShooterProjectile.h" },
#if !UE_BUILD_SHIPPING
		{ "ToolTip", "Simple projectile class for a first person shooter game" },
#endif
	};
	static constexpr UECodeGen_Private::FMetaDataPairParam NewProp_CollisionComponent_MetaData[] = {
		{ "AllowPrivateAccess", "true" },
		{ "Category", "Components" },
#if !UE_BUILD_SHIPPING
		{ "Comment", "/** Provides collision detection for the projectile */" },
#endif
		{ "EditInline", "true" },
		{ "ModuleRelativePath", "Variant_Shooter/ShooterProjectile.h" },
#if !UE_BUILD_SHIPPING
		{ "ToolTip", "Provides collision detection for the projectile" },
#endif
	};
	static constexpr UECodeGen_Private::FMetaDataPairParam NewProp_ProjectileMovement_MetaData[] = {
		{ "AllowPrivateAccess", "true" },
		{ "Category", "Components" },
#if !UE_BUILD_SHIPPING
		{ "Comment", "/** Handles movement for the projectile */" },
#endif
		{ "EditInline", "true" },
		{ "ModuleRelativePath", "Variant_Shooter/ShooterProjectile.h" },
#if !UE_BUILD_SHIPPING
		{ "ToolTip", "Handles movement for the projectile" },
#endif
	};
	static constexpr UECodeGen_Private::FMetaDataPairParam NewProp_NoiseLoudness_MetaData[] = {
		{ "Category", "Noise" },
#if !UE_BUILD_SHIPPING
		{ "Comment", "/** Loudness of the AI perception noise done by this projectile on hit */" },
#endif
		{ "ModuleRelativePath", "Variant_Shooter/ShooterProjectile.h" },
#if !UE_BUILD_SHIPPING
		{ "ToolTip", "Loudness of the AI perception noise done by this projectile on hit" },
#endif
	};
	static constexpr UECodeGen_Private::FMetaDataPairParam NewProp_NoiseRange_MetaData[] = {
		{ "Category", "Noise" },
#if !UE_BUILD_SHIPPING
		{ "Comment", "/** Range of the AI perception noise done by this projectile on hit */" },
#endif
		{ "ModuleRelativePath", "Variant_Shooter/ShooterProjectile.h" },
#if !UE_BUILD_SHIPPING
		{ "ToolTip", "Range of the AI perception noise done by this projectile on hit" },
#endif
	};
	static constexpr UECodeGen_Private::FMetaDataPairParam NewProp_NoiseTag_MetaData[] = {
		{ "Category", "Noise" },
#if !UE_BUILD_SHIPPING
		{ "Comment", "/** Tag of the AI perception noise done by this projectile on hit */" },
#endif
		{ "ModuleRelativePath", "Variant_Shooter/ShooterProjectile.h" },
#if !UE_BUILD_SHIPPING
		{ "ToolTip", "Tag of the AI perception noise done by this projectile on hit" },
#endif
	};
	static constexpr UECodeGen_Private::FMetaDataPairParam NewProp_PhysicsForce_MetaData[] = {
		{ "Category", "Hit" },
#if !UE_BUILD_SHIPPING
		{ "Comment", "/** Physics force to apply on hit */" },
#endif
		{ "ModuleRelativePath", "Variant_Shooter/ShooterProjectile.h" },
#if !UE_BUILD_SHIPPING
		{ "ToolTip", "Physics force to apply on hit" },
#endif
	};
	static constexpr UECodeGen_Private::FMetaDataPairParam NewProp_HitDamage_MetaData[] = {
		{ "Category", "Hit" },
#if !UE_BUILD_SHIPPING
		{ "Comment", "/** Damage to apply on hit */" },
#endif
		{ "ModuleRelativePath", "Variant_Shooter/ShooterProjectile.h" },
#if !UE_BUILD_SHIPPING
		{ "ToolTip", "Damage to apply on hit" },
#endif
	};
	static constexpr UECodeGen_Private::FMetaDataPairParam NewProp_HitDamageType_MetaData[] = {
		{ "Category", "Hit" },
#if !UE_BUILD_SHIPPING
		{ "Comment", "/** Type of damage to apply. Can be used to represent specific types of damage such as fire, explosion, etc. */" },
#endif
		{ "ModuleRelativePath", "Variant_Shooter/ShooterProjectile.h" },
#if !UE_BUILD_SHIPPING
		{ "ToolTip", "Type of damage to apply. Can be used to represent specific types of damage such as fire, explosion, etc." },
#endif
	};
#endif // WITH_METADATA
	static const UECodeGen_Private::FObjectPropertyParams NewProp_CollisionComponent;
	static const UECodeGen_Private::FObjectPropertyParams NewProp_ProjectileMovement;
	static const UECodeGen_Private::FFloatPropertyParams NewProp_NoiseLoudness;
	static const UECodeGen_Private::FFloatPropertyParams NewProp_NoiseRange;
	static const UECodeGen_Private::FNamePropertyParams NewProp_NoiseTag;
	static const UECodeGen_Private::FFloatPropertyParams NewProp_PhysicsForce;
	static const UECodeGen_Private::FFloatPropertyParams NewProp_HitDamage;
	static const UECodeGen_Private::FClassPropertyParams NewProp_HitDamageType;
	static const UECodeGen_Private::FPropertyParamsBase* const PropPointers[];
	static UObject* (*const DependentSingletons[])();
	static constexpr FClassFunctionLinkInfo FuncInfo[] = {
		{ &Z_Construct_UFunction_AShooterProjectile_BP_OnProjectileHit, "BP_OnProjectileHit" }, // 1988364157
		{ &Z_Construct_UFunction_AShooterProjectile_DamageCharacter, "DamageCharacter" }, // 1344446770
	};
	static_assert(UE_ARRAY_COUNT(FuncInfo) < 2048);
	static constexpr FCppClassTypeInfoStatic StaticCppClassTypeInfo = {
		TCppClassTypeTraits<AShooterProjectile>::IsAbstract,
	};
	static const UECodeGen_Private::FClassParams ClassParams;
};
const UECodeGen_Private::FObjectPropertyParams Z_Construct_UClass_AShooterProjectile_Statics::NewProp_CollisionComponent = { "CollisionComponent", nullptr, (EPropertyFlags)0x00400000000a001d, UECodeGen_Private::EPropertyGenFlags::Object, RF_Public|RF_Transient|RF_MarkAsNative, nullptr, nullptr, 1, STRUCT_OFFSET(AShooterProjectile, CollisionComponent), Z_Construct_UClass_USphereComponent_NoRegister, METADATA_PARAMS(UE_ARRAY_COUNT(NewProp_CollisionComponent_MetaData), NewProp_CollisionComponent_MetaData) };
const UECodeGen_Private::FObjectPropertyParams Z_Construct_UClass_AShooterProjectile_Statics::NewProp_ProjectileMovement = { "ProjectileMovement", nullptr, (EPropertyFlags)0x00400000000a001d, UECodeGen_Private::EPropertyGenFlags::Object, RF_Public|RF_Transient|RF_MarkAsNative, nullptr, nullptr, 1, STRUCT_OFFSET(AShooterProjectile, ProjectileMovement), Z_Construct_UClass_UProjectileMovementComponent_NoRegister, METADATA_PARAMS(UE_ARRAY_COUNT(NewProp_ProjectileMovement_MetaData), NewProp_ProjectileMovement_MetaData) };
const UECodeGen_Private::FFloatPropertyParams Z_Construct_UClass_AShooterProjectile_Statics::NewProp_NoiseLoudness = { "NoiseLoudness", nullptr, (EPropertyFlags)0x0020080000000001, UECodeGen_Private::EPropertyGenFlags::Float, RF_Public|RF_Transient|RF_MarkAsNative, nullptr, nullptr, 1, STRUCT_OFFSET(AShooterProjectile, NoiseLoudness), METADATA_PARAMS(UE_ARRAY_COUNT(NewProp_NoiseLoudness_MetaData), NewProp_NoiseLoudness_MetaData) };
const UECodeGen_Private::FFloatPropertyParams Z_Construct_UClass_AShooterProjectile_Statics::NewProp_NoiseRange = { "NoiseRange", nullptr, (EPropertyFlags)0x0020080000000001, UECodeGen_Private::EPropertyGenFlags::Float, RF_Public|RF_Transient|RF_MarkAsNative, nullptr, nullptr, 1, STRUCT_OFFSET(AShooterProjectile, NoiseRange), METADATA_PARAMS(UE_ARRAY_COUNT(NewProp_NoiseRange_MetaData), NewProp_NoiseRange_MetaData) };
const UECodeGen_Private::FNamePropertyParams Z_Construct_UClass_AShooterProjectile_Statics::NewProp_NoiseTag = { "NoiseTag", nullptr, (EPropertyFlags)0x0020080000000001, UECodeGen_Private::EPropertyGenFlags::Name, RF_Public|RF_Transient|RF_MarkAsNative, nullptr, nullptr, 1, STRUCT_OFFSET(AShooterProjectile, NoiseTag), METADATA_PARAMS(UE_ARRAY_COUNT(NewProp_NoiseTag_MetaData), NewProp_NoiseTag_MetaData) };
const UECodeGen_Private::FFloatPropertyParams Z_Construct_UClass_AShooterProjectile_Statics::NewProp_PhysicsForce = { "PhysicsForce", nullptr, (EPropertyFlags)0x0020080000000001, UECodeGen_Private::EPropertyGenFlags::Float, RF_Public|RF_Transient|RF_MarkAsNative, nullptr, nullptr, 1, STRUCT_OFFSET(AShooterProjectile, PhysicsForce), METADATA_PARAMS(UE_ARRAY_COUNT(NewProp_PhysicsForce_MetaData), NewProp_PhysicsForce_MetaData) };
const UECodeGen_Private::FFloatPropertyParams Z_Construct_UClass_AShooterProjectile_Statics::NewProp_HitDamage = { "HitDamage", nullptr, (EPropertyFlags)0x0020080000000001, UECodeGen_Private::EPropertyGenFlags::Float, RF_Public|RF_Transient|RF_MarkAsNative, nullptr, nullptr, 1, STRUCT_OFFSET(AShooterProjectile, HitDamage), METADATA_PARAMS(UE_ARRAY_COUNT(NewProp_HitDamage_MetaData), NewProp_HitDamage_MetaData) };
const UECodeGen_Private::FClassPropertyParams Z_Construct_UClass_AShooterProjectile_Statics::NewProp_HitDamageType = { "HitDamageType", nullptr, (EPropertyFlags)0x0024080000000001, UECodeGen_Private::EPropertyGenFlags::Class, RF_Public|RF_Transient|RF_MarkAsNative, nullptr, nullptr, 1, STRUCT_OFFSET(AShooterProjectile, HitDamageType), Z_Construct_UClass_UClass, Z_Construct_UClass_UDamageType_NoRegister, METADATA_PARAMS(UE_ARRAY_COUNT(NewProp_HitDamageType_MetaData), NewProp_HitDamageType_MetaData) };
const UECodeGen_Private::FPropertyParamsBase* const Z_Construct_UClass_AShooterProjectile_Statics::PropPointers[] = {
	(const UECodeGen_Private::FPropertyParamsBase*)&Z_Construct_UClass_AShooterProjectile_Statics::NewProp_CollisionComponent,
	(const UECodeGen_Private::FPropertyParamsBase*)&Z_Construct_UClass_AShooterProjectile_Statics::NewProp_ProjectileMovement,
	(const UECodeGen_Private::FPropertyParamsBase*)&Z_Construct_UClass_AShooterProjectile_Statics::NewProp_NoiseLoudness,
	(const UECodeGen_Private::FPropertyParamsBase*)&Z_Construct_UClass_AShooterProjectile_Statics::NewProp_NoiseRange,
	(const UECodeGen_Private::FPropertyParamsBase*)&Z_Construct_UClass_AShooterProjectile_Statics::NewProp_NoiseTag,
	(const UECodeGen_Private::FPropertyParamsBase*)&Z_Construct_UClass_AShooterProjectile_Statics::NewProp_PhysicsForce,
	(const UECodeGen_Private::FPropertyParamsBase*)&Z_Construct_UClass_AShooterProjectile_Statics::NewProp_HitDamage,
	(const UECodeGen_Private::FPropertyParamsBase*)&Z_Construct_UClass_AShooterProjectile_Statics::NewProp_HitDamageType,
};
static_assert(UE_ARRAY_COUNT(Z_Construct_UClass_AShooterProjectile_Statics::PropPointers) < 2048);
UObject* (*const Z_Construct_UClass_AShooterProjectile_Statics::DependentSingletons[])() = {
	(UObject* (*)())Z_Construct_UClass_AActor,
	(UObject* (*)())Z_Construct_UPackage__Script_App,
};
static_assert(UE_ARRAY_COUNT(Z_Construct_UClass_AShooterProjectile_Statics::DependentSingletons) < 16);
const UECodeGen_Private::FClassParams Z_Construct_UClass_AShooterProjectile_Statics::ClassParams = {
	&AShooterProjectile::StaticClass,
	"Engine",
	&StaticCppClassTypeInfo,
	DependentSingletons,
	FuncInfo,
	Z_Construct_UClass_AShooterProjectile_Statics::PropPointers,
	nullptr,
	UE_ARRAY_COUNT(DependentSingletons),
	UE_ARRAY_COUNT(FuncInfo),
	UE_ARRAY_COUNT(Z_Construct_UClass_AShooterProjectile_Statics::PropPointers),
	0,
	0x009001A5u,
	METADATA_PARAMS(UE_ARRAY_COUNT(Z_Construct_UClass_AShooterProjectile_Statics::Class_MetaDataParams), Z_Construct_UClass_AShooterProjectile_Statics::Class_MetaDataParams)
};
UClass* Z_Construct_UClass_AShooterProjectile()
{
	if (!Z_Registration_Info_UClass_AShooterProjectile.OuterSingleton)
	{
		UECodeGen_Private::ConstructUClass(Z_Registration_Info_UClass_AShooterProjectile.OuterSingleton, Z_Construct_UClass_AShooterProjectile_Statics::ClassParams);
	}
	return Z_Registration_Info_UClass_AShooterProjectile.OuterSingleton;
}
DEFINE_VTABLE_PTR_HELPER_CTOR(AShooterProjectile);
AShooterProjectile::~AShooterProjectile() {}
// ********** End Class AShooterProjectile *********************************************************

// ********** Begin Registration *******************************************************************
struct Z_CompiledInDeferFile_FID_Users_octav_Unreal_Projects_App_Source_App_Variant_Shooter_ShooterProjectile_h__Script_App_Statics
{
	static constexpr FClassRegisterCompiledInInfo ClassInfo[] = {
		{ Z_Construct_UClass_AShooterProjectile, AShooterProjectile::StaticClass, TEXT("AShooterProjectile"), &Z_Registration_Info_UClass_AShooterProjectile, CONSTRUCT_RELOAD_VERSION_INFO(FClassReloadVersionInfo, sizeof(AShooterProjectile), 3386293416U) },
	};
};
static FRegisterCompiledInInfo Z_CompiledInDeferFile_FID_Users_octav_Unreal_Projects_App_Source_App_Variant_Shooter_ShooterProjectile_h__Script_App_335040733(TEXT("/Script/App"),
	Z_CompiledInDeferFile_FID_Users_octav_Unreal_Projects_App_Source_App_Variant_Shooter_ShooterProjectile_h__Script_App_Statics::ClassInfo, UE_ARRAY_COUNT(Z_CompiledInDeferFile_FID_Users_octav_Unreal_Projects_App_Source_App_Variant_Shooter_ShooterProjectile_h__Script_App_Statics::ClassInfo),
	nullptr, 0,
	nullptr, 0);
// ********** End Registration *********************************************************************

PRAGMA_ENABLE_DEPRECATION_WARNINGS
