// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: profit_contract.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using aelf = global::AElf.CSharp.Core;

namespace AElf.Contracts.Profit {

  #region Events
  internal partial class SchemeCreated : aelf::IEvent<SchemeCreated>
  {
    public global::System.Collections.Generic.IEnumerable<SchemeCreated> GetIndexed()
    {
      yield break;
    }

    public SchemeCreated GetNonIndexed()
    {
      return new SchemeCreated
      {
        VirtualAddress = VirtualAddress,
        Manager = Manager,
        ProfitReceivingDuePeriodCount = ProfitReceivingDuePeriodCount,
        IsReleaseAllBalanceEveryTimeByDefault = IsReleaseAllBalanceEveryTimeByDefault,
        SchemeId = SchemeId,
      };
    }
  }

  #endregion
  internal static partial class ProfitContractContainer
  {
    static readonly string __ServiceName = "profit.ProfitContract";

    #region Marshallers
    static readonly aelf::Marshaller<global::Acs1.TokenAmounts> __Marshaller_acs1_TokenAmounts = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Acs1.TokenAmounts.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Empty.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::Acs1.MethodName> __Marshaller_acs1_MethodName = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Acs1.MethodName.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.Profit.CreateSchemeInput> __Marshaller_profit_CreateSchemeInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.Profit.CreateSchemeInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Types.Hash> __Marshaller_aelf_Hash = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Types.Hash.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.Profit.AddBeneficiaryInput> __Marshaller_profit_AddBeneficiaryInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.Profit.AddBeneficiaryInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.Profit.RemoveBeneficiaryInput> __Marshaller_profit_RemoveBeneficiaryInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.Profit.RemoveBeneficiaryInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.Profit.AddBeneficiariesInput> __Marshaller_profit_AddBeneficiariesInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.Profit.AddBeneficiariesInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.Profit.RemoveBeneficiariesInput> __Marshaller_profit_RemoveBeneficiariesInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.Profit.RemoveBeneficiariesInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.Profit.ContributeProfitsInput> __Marshaller_profit_ContributeProfitsInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.Profit.ContributeProfitsInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.Profit.ClaimProfitsInput> __Marshaller_profit_ClaimProfitsInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.Profit.ClaimProfitsInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.Profit.DistributeProfitsInput> __Marshaller_profit_DistributeProfitsInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.Profit.DistributeProfitsInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.Profit.AddSubSchemeInput> __Marshaller_profit_AddSubSchemeInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.Profit.AddSubSchemeInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.Profit.RemoveSubSchemeInput> __Marshaller_profit_RemoveSubSchemeInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.Profit.RemoveSubSchemeInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.Profit.ResetManagerInput> __Marshaller_profit_ResetManagerInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.Profit.ResetManagerInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.Profit.GetManagingSchemeIdsInput> __Marshaller_profit_GetManagingSchemeIdsInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.Profit.GetManagingSchemeIdsInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.Profit.CreatedSchemeIds> __Marshaller_profit_CreatedSchemeIds = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.Profit.CreatedSchemeIds.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.Profit.Scheme> __Marshaller_profit_Scheme = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.Profit.Scheme.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.Profit.SchemePeriod> __Marshaller_profit_SchemePeriod = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.Profit.SchemePeriod.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Types.Address> __Marshaller_aelf_Address = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Types.Address.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.Profit.DistributedProfitsInfo> __Marshaller_profit_DistributedProfitsInfo = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.Profit.DistributedProfitsInfo.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.Profit.GetProfitDetailsInput> __Marshaller_profit_GetProfitDetailsInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.Profit.GetProfitDetailsInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.Profit.ProfitDetails> __Marshaller_profit_ProfitDetails = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.Profit.ProfitDetails.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Types.SInt64Value> __Marshaller_aelf_SInt64Value = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Types.SInt64Value.Parser.ParseFrom);
    #endregion

    #region Methods
    static readonly aelf::Method<global::Acs1.TokenAmounts, global::Google.Protobuf.WellKnownTypes.Empty> __Method_SetMethodFee = new aelf::Method<global::Acs1.TokenAmounts, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "SetMethodFee",
        __Marshaller_acs1_TokenAmounts,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::Acs1.MethodName, global::Acs1.TokenAmounts> __Method_GetMethodFee = new aelf::Method<global::Acs1.MethodName, global::Acs1.TokenAmounts>(
        aelf::MethodType.View,
        __ServiceName,
        "GetMethodFee",
        __Marshaller_acs1_MethodName,
        __Marshaller_acs1_TokenAmounts);

    static readonly aelf::Method<global::AElf.Contracts.Profit.CreateSchemeInput, global::AElf.Types.Hash> __Method_CreateScheme = new aelf::Method<global::AElf.Contracts.Profit.CreateSchemeInput, global::AElf.Types.Hash>(
        aelf::MethodType.Action,
        __ServiceName,
        "CreateScheme",
        __Marshaller_profit_CreateSchemeInput,
        __Marshaller_aelf_Hash);

    static readonly aelf::Method<global::AElf.Contracts.Profit.AddBeneficiaryInput, global::Google.Protobuf.WellKnownTypes.Empty> __Method_AddBeneficiary = new aelf::Method<global::AElf.Contracts.Profit.AddBeneficiaryInput, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "AddBeneficiary",
        __Marshaller_profit_AddBeneficiaryInput,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::AElf.Contracts.Profit.RemoveBeneficiaryInput, global::Google.Protobuf.WellKnownTypes.Empty> __Method_RemoveBeneficiary = new aelf::Method<global::AElf.Contracts.Profit.RemoveBeneficiaryInput, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "RemoveBeneficiary",
        __Marshaller_profit_RemoveBeneficiaryInput,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::AElf.Contracts.Profit.AddBeneficiariesInput, global::Google.Protobuf.WellKnownTypes.Empty> __Method_AddBeneficiaries = new aelf::Method<global::AElf.Contracts.Profit.AddBeneficiariesInput, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "AddBeneficiaries",
        __Marshaller_profit_AddBeneficiariesInput,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::AElf.Contracts.Profit.RemoveBeneficiariesInput, global::Google.Protobuf.WellKnownTypes.Empty> __Method_RemoveBeneficiaries = new aelf::Method<global::AElf.Contracts.Profit.RemoveBeneficiariesInput, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "RemoveBeneficiaries",
        __Marshaller_profit_RemoveBeneficiariesInput,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::AElf.Contracts.Profit.ContributeProfitsInput, global::Google.Protobuf.WellKnownTypes.Empty> __Method_ContributeProfits = new aelf::Method<global::AElf.Contracts.Profit.ContributeProfitsInput, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "ContributeProfits",
        __Marshaller_profit_ContributeProfitsInput,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::AElf.Contracts.Profit.ClaimProfitsInput, global::Google.Protobuf.WellKnownTypes.Empty> __Method_ClaimProfits = new aelf::Method<global::AElf.Contracts.Profit.ClaimProfitsInput, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "ClaimProfits",
        __Marshaller_profit_ClaimProfitsInput,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::AElf.Contracts.Profit.DistributeProfitsInput, global::Google.Protobuf.WellKnownTypes.Empty> __Method_DistributeProfits = new aelf::Method<global::AElf.Contracts.Profit.DistributeProfitsInput, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "DistributeProfits",
        __Marshaller_profit_DistributeProfitsInput,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::AElf.Contracts.Profit.AddSubSchemeInput, global::Google.Protobuf.WellKnownTypes.Empty> __Method_AddSubScheme = new aelf::Method<global::AElf.Contracts.Profit.AddSubSchemeInput, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "AddSubScheme",
        __Marshaller_profit_AddSubSchemeInput,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::AElf.Contracts.Profit.RemoveSubSchemeInput, global::Google.Protobuf.WellKnownTypes.Empty> __Method_RemoveSubScheme = new aelf::Method<global::AElf.Contracts.Profit.RemoveSubSchemeInput, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "RemoveSubScheme",
        __Marshaller_profit_RemoveSubSchemeInput,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::AElf.Contracts.Profit.ResetManagerInput, global::Google.Protobuf.WellKnownTypes.Empty> __Method_ResetManager = new aelf::Method<global::AElf.Contracts.Profit.ResetManagerInput, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "ResetManager",
        __Marshaller_profit_ResetManagerInput,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::AElf.Contracts.Profit.GetManagingSchemeIdsInput, global::AElf.Contracts.Profit.CreatedSchemeIds> __Method_GetManagingSchemeIds = new aelf::Method<global::AElf.Contracts.Profit.GetManagingSchemeIdsInput, global::AElf.Contracts.Profit.CreatedSchemeIds>(
        aelf::MethodType.View,
        __ServiceName,
        "GetManagingSchemeIds",
        __Marshaller_profit_GetManagingSchemeIdsInput,
        __Marshaller_profit_CreatedSchemeIds);

    static readonly aelf::Method<global::AElf.Types.Hash, global::AElf.Contracts.Profit.Scheme> __Method_GetScheme = new aelf::Method<global::AElf.Types.Hash, global::AElf.Contracts.Profit.Scheme>(
        aelf::MethodType.View,
        __ServiceName,
        "GetScheme",
        __Marshaller_aelf_Hash,
        __Marshaller_profit_Scheme);

    static readonly aelf::Method<global::AElf.Contracts.Profit.SchemePeriod, global::AElf.Types.Address> __Method_GetSchemeAddress = new aelf::Method<global::AElf.Contracts.Profit.SchemePeriod, global::AElf.Types.Address>(
        aelf::MethodType.View,
        __ServiceName,
        "GetSchemeAddress",
        __Marshaller_profit_SchemePeriod,
        __Marshaller_aelf_Address);

    static readonly aelf::Method<global::AElf.Contracts.Profit.SchemePeriod, global::AElf.Contracts.Profit.DistributedProfitsInfo> __Method_GetDistributedProfitsInfo = new aelf::Method<global::AElf.Contracts.Profit.SchemePeriod, global::AElf.Contracts.Profit.DistributedProfitsInfo>(
        aelf::MethodType.View,
        __ServiceName,
        "GetDistributedProfitsInfo",
        __Marshaller_profit_SchemePeriod,
        __Marshaller_profit_DistributedProfitsInfo);

    static readonly aelf::Method<global::AElf.Contracts.Profit.GetProfitDetailsInput, global::AElf.Contracts.Profit.ProfitDetails> __Method_GetProfitDetails = new aelf::Method<global::AElf.Contracts.Profit.GetProfitDetailsInput, global::AElf.Contracts.Profit.ProfitDetails>(
        aelf::MethodType.View,
        __ServiceName,
        "GetProfitDetails",
        __Marshaller_profit_GetProfitDetailsInput,
        __Marshaller_profit_ProfitDetails);

    static readonly aelf::Method<global::AElf.Contracts.Profit.ClaimProfitsInput, global::AElf.Types.SInt64Value> __Method_GetProfitAmount = new aelf::Method<global::AElf.Contracts.Profit.ClaimProfitsInput, global::AElf.Types.SInt64Value>(
        aelf::MethodType.View,
        __ServiceName,
        "GetProfitAmount",
        __Marshaller_profit_ClaimProfitsInput,
        __Marshaller_aelf_SInt64Value);

    #endregion

    #region Descriptors
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::AElf.Contracts.Profit.ProfitContractReflection.Descriptor.Services[0]; }
    }

    public static global::System.Collections.Generic.IReadOnlyList<global::Google.Protobuf.Reflection.ServiceDescriptor> Descriptors
    {
      get
      {
        return new global::System.Collections.Generic.List<global::Google.Protobuf.Reflection.ServiceDescriptor>()
        {
          global::Acs1.Acs1Reflection.Descriptor.Services[0],
          global::AElf.Contracts.Profit.ProfitContractReflection.Descriptor.Services[0],
        };
      }
    }
    #endregion

    public class ProfitContractStub : aelf::ContractStubBase
    {
      public aelf::IMethodStub<global::Acs1.TokenAmounts, global::Google.Protobuf.WellKnownTypes.Empty> SetMethodFee
      {
        get { return __factory.Create(__Method_SetMethodFee); }
      }

      public aelf::IMethodStub<global::Acs1.MethodName, global::Acs1.TokenAmounts> GetMethodFee
      {
        get { return __factory.Create(__Method_GetMethodFee); }
      }

      public aelf::IMethodStub<global::AElf.Contracts.Profit.CreateSchemeInput, global::AElf.Types.Hash> CreateScheme
      {
        get { return __factory.Create(__Method_CreateScheme); }
      }

      public aelf::IMethodStub<global::AElf.Contracts.Profit.AddBeneficiaryInput, global::Google.Protobuf.WellKnownTypes.Empty> AddBeneficiary
      {
        get { return __factory.Create(__Method_AddBeneficiary); }
      }

      public aelf::IMethodStub<global::AElf.Contracts.Profit.RemoveBeneficiaryInput, global::Google.Protobuf.WellKnownTypes.Empty> RemoveBeneficiary
      {
        get { return __factory.Create(__Method_RemoveBeneficiary); }
      }

      public aelf::IMethodStub<global::AElf.Contracts.Profit.AddBeneficiariesInput, global::Google.Protobuf.WellKnownTypes.Empty> AddBeneficiaries
      {
        get { return __factory.Create(__Method_AddBeneficiaries); }
      }

      public aelf::IMethodStub<global::AElf.Contracts.Profit.RemoveBeneficiariesInput, global::Google.Protobuf.WellKnownTypes.Empty> RemoveBeneficiaries
      {
        get { return __factory.Create(__Method_RemoveBeneficiaries); }
      }

      public aelf::IMethodStub<global::AElf.Contracts.Profit.ContributeProfitsInput, global::Google.Protobuf.WellKnownTypes.Empty> ContributeProfits
      {
        get { return __factory.Create(__Method_ContributeProfits); }
      }

      public aelf::IMethodStub<global::AElf.Contracts.Profit.ClaimProfitsInput, global::Google.Protobuf.WellKnownTypes.Empty> ClaimProfits
      {
        get { return __factory.Create(__Method_ClaimProfits); }
      }

      public aelf::IMethodStub<global::AElf.Contracts.Profit.DistributeProfitsInput, global::Google.Protobuf.WellKnownTypes.Empty> DistributeProfits
      {
        get { return __factory.Create(__Method_DistributeProfits); }
      }

      public aelf::IMethodStub<global::AElf.Contracts.Profit.AddSubSchemeInput, global::Google.Protobuf.WellKnownTypes.Empty> AddSubScheme
      {
        get { return __factory.Create(__Method_AddSubScheme); }
      }

      public aelf::IMethodStub<global::AElf.Contracts.Profit.RemoveSubSchemeInput, global::Google.Protobuf.WellKnownTypes.Empty> RemoveSubScheme
      {
        get { return __factory.Create(__Method_RemoveSubScheme); }
      }

      public aelf::IMethodStub<global::AElf.Contracts.Profit.ResetManagerInput, global::Google.Protobuf.WellKnownTypes.Empty> ResetManager
      {
        get { return __factory.Create(__Method_ResetManager); }
      }

      public aelf::IMethodStub<global::AElf.Contracts.Profit.GetManagingSchemeIdsInput, global::AElf.Contracts.Profit.CreatedSchemeIds> GetManagingSchemeIds
      {
        get { return __factory.Create(__Method_GetManagingSchemeIds); }
      }

      public aelf::IMethodStub<global::AElf.Types.Hash, global::AElf.Contracts.Profit.Scheme> GetScheme
      {
        get { return __factory.Create(__Method_GetScheme); }
      }

      public aelf::IMethodStub<global::AElf.Contracts.Profit.SchemePeriod, global::AElf.Types.Address> GetSchemeAddress
      {
        get { return __factory.Create(__Method_GetSchemeAddress); }
      }

      public aelf::IMethodStub<global::AElf.Contracts.Profit.SchemePeriod, global::AElf.Contracts.Profit.DistributedProfitsInfo> GetDistributedProfitsInfo
      {
        get { return __factory.Create(__Method_GetDistributedProfitsInfo); }
      }

      public aelf::IMethodStub<global::AElf.Contracts.Profit.GetProfitDetailsInput, global::AElf.Contracts.Profit.ProfitDetails> GetProfitDetails
      {
        get { return __factory.Create(__Method_GetProfitDetails); }
      }

      public aelf::IMethodStub<global::AElf.Contracts.Profit.ClaimProfitsInput, global::AElf.Types.SInt64Value> GetProfitAmount
      {
        get { return __factory.Create(__Method_GetProfitAmount); }
      }

    }
  }
}
#endregion
