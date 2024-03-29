// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: acs4.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using aelf = global::AElf.CSharp.Core;

namespace Acs4 {

  #region Events
  #endregion
  internal static partial class ConsensusContractContainer
  {
    static readonly string __ServiceName = "acs4.ConsensusContract";

    #region Marshallers
    static readonly aelf::Marshaller<global::Google.Protobuf.WellKnownTypes.BytesValue> __Marshaller_google_protobuf_BytesValue = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.BytesValue.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::Acs4.ConsensusCommand> __Marshaller_acs4_ConsensusCommand = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Acs4.ConsensusCommand.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::Acs4.TransactionList> __Marshaller_acs4_TransactionList = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Acs4.TransactionList.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::Acs4.ValidationResult> __Marshaller_acs4_ValidationResult = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Acs4.ValidationResult.Parser.ParseFrom);
    #endregion

    #region Methods
    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.BytesValue, global::Acs4.ConsensusCommand> __Method_GetConsensusCommand = new aelf::Method<global::Google.Protobuf.WellKnownTypes.BytesValue, global::Acs4.ConsensusCommand>(
        aelf::MethodType.View,
        __ServiceName,
        "GetConsensusCommand",
        __Marshaller_google_protobuf_BytesValue,
        __Marshaller_acs4_ConsensusCommand);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.BytesValue, global::Google.Protobuf.WellKnownTypes.BytesValue> __Method_GetInformationToUpdateConsensus = new aelf::Method<global::Google.Protobuf.WellKnownTypes.BytesValue, global::Google.Protobuf.WellKnownTypes.BytesValue>(
        aelf::MethodType.View,
        __ServiceName,
        "GetInformationToUpdateConsensus",
        __Marshaller_google_protobuf_BytesValue,
        __Marshaller_google_protobuf_BytesValue);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.BytesValue, global::Acs4.TransactionList> __Method_GenerateConsensusTransactions = new aelf::Method<global::Google.Protobuf.WellKnownTypes.BytesValue, global::Acs4.TransactionList>(
        aelf::MethodType.View,
        __ServiceName,
        "GenerateConsensusTransactions",
        __Marshaller_google_protobuf_BytesValue,
        __Marshaller_acs4_TransactionList);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.BytesValue, global::Acs4.ValidationResult> __Method_ValidateConsensusBeforeExecution = new aelf::Method<global::Google.Protobuf.WellKnownTypes.BytesValue, global::Acs4.ValidationResult>(
        aelf::MethodType.View,
        __ServiceName,
        "ValidateConsensusBeforeExecution",
        __Marshaller_google_protobuf_BytesValue,
        __Marshaller_acs4_ValidationResult);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.BytesValue, global::Acs4.ValidationResult> __Method_ValidateConsensusAfterExecution = new aelf::Method<global::Google.Protobuf.WellKnownTypes.BytesValue, global::Acs4.ValidationResult>(
        aelf::MethodType.View,
        __ServiceName,
        "ValidateConsensusAfterExecution",
        __Marshaller_google_protobuf_BytesValue,
        __Marshaller_acs4_ValidationResult);

    #endregion

    #region Descriptors
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Acs4.Acs4Reflection.Descriptor.Services[0]; }
    }

    public static global::System.Collections.Generic.IReadOnlyList<global::Google.Protobuf.Reflection.ServiceDescriptor> Descriptors
    {
      get
      {
        return new global::System.Collections.Generic.List<global::Google.Protobuf.Reflection.ServiceDescriptor>()
        {
          global::Acs4.Acs4Reflection.Descriptor.Services[0],
        };
      }
    }
    #endregion

    public class ConsensusContractStub : aelf::ContractStubBase
    {
      public aelf::IMethodStub<global::Google.Protobuf.WellKnownTypes.BytesValue, global::Acs4.ConsensusCommand> GetConsensusCommand
      {
        get { return __factory.Create(__Method_GetConsensusCommand); }
      }

      public aelf::IMethodStub<global::Google.Protobuf.WellKnownTypes.BytesValue, global::Google.Protobuf.WellKnownTypes.BytesValue> GetInformationToUpdateConsensus
      {
        get { return __factory.Create(__Method_GetInformationToUpdateConsensus); }
      }

      public aelf::IMethodStub<global::Google.Protobuf.WellKnownTypes.BytesValue, global::Acs4.TransactionList> GenerateConsensusTransactions
      {
        get { return __factory.Create(__Method_GenerateConsensusTransactions); }
      }

      public aelf::IMethodStub<global::Google.Protobuf.WellKnownTypes.BytesValue, global::Acs4.ValidationResult> ValidateConsensusBeforeExecution
      {
        get { return __factory.Create(__Method_ValidateConsensusBeforeExecution); }
      }

      public aelf::IMethodStub<global::Google.Protobuf.WellKnownTypes.BytesValue, global::Acs4.ValidationResult> ValidateConsensusAfterExecution
      {
        get { return __factory.Create(__Method_ValidateConsensusAfterExecution); }
      }

    }
  }
}
#endregion

