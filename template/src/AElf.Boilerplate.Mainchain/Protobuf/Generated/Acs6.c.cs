// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: acs6.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using aelf = global::AElf.CSharp.Core;

namespace Acs6 {

  #region Events
  internal partial class RandomNumberRequestHandled : aelf::IEvent<RandomNumberRequestHandled>
  {
    public global::System.Collections.Generic.IEnumerable<RandomNumberRequestHandled> GetIndexed()
    {
      yield break;
    }

    public RandomNumberRequestHandled GetNonIndexed()
    {
      return new RandomNumberRequestHandled
      {
        Requester = Requester,
        TokenHash = TokenHash,
        BlockHeight = BlockHeight,
      };
    }
  }

  internal partial class RandomNumberGenerated : aelf::IEvent<RandomNumberGenerated>
  {
    public global::System.Collections.Generic.IEnumerable<RandomNumberGenerated> GetIndexed()
    {
      yield break;
    }

    public RandomNumberGenerated GetNonIndexed()
    {
      return new RandomNumberGenerated
      {
        TokenHash = TokenHash,
        RandomHash = RandomHash,
      };
    }
  }

  #endregion
  internal static partial class RandomNumberProviderContractContainer
  {
    static readonly string __ServiceName = "acs6.RandomNumberProviderContract";

    #region Marshallers
    static readonly aelf::Marshaller<global::Acs6.RequestRandomNumberInput> __Marshaller_acs6_RequestRandomNumberInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Acs6.RequestRandomNumberInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::Acs6.RandomNumberOrder> __Marshaller_acs6_RandomNumberOrder = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Acs6.RandomNumberOrder.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Types.Hash> __Marshaller_aelf_Hash = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Types.Hash.Parser.ParseFrom);
    #endregion

    #region Methods
    static readonly aelf::Method<global::Acs6.RequestRandomNumberInput, global::Acs6.RandomNumberOrder> __Method_RequestRandomNumber = new aelf::Method<global::Acs6.RequestRandomNumberInput, global::Acs6.RandomNumberOrder>(
        aelf::MethodType.Action,
        __ServiceName,
        "RequestRandomNumber",
        __Marshaller_acs6_RequestRandomNumberInput,
        __Marshaller_acs6_RandomNumberOrder);

    static readonly aelf::Method<global::AElf.Types.Hash, global::AElf.Types.Hash> __Method_GetRandomNumber = new aelf::Method<global::AElf.Types.Hash, global::AElf.Types.Hash>(
        aelf::MethodType.Action,
        __ServiceName,
        "GetRandomNumber",
        __Marshaller_aelf_Hash,
        __Marshaller_aelf_Hash);

    #endregion

    #region Descriptors
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Acs6.Acs6Reflection.Descriptor.Services[0]; }
    }

    public static global::System.Collections.Generic.IReadOnlyList<global::Google.Protobuf.Reflection.ServiceDescriptor> Descriptors
    {
      get
      {
        return new global::System.Collections.Generic.List<global::Google.Protobuf.Reflection.ServiceDescriptor>()
        {
          global::Acs6.Acs6Reflection.Descriptor.Services[0],
        };
      }
    }
    #endregion

    public class RandomNumberProviderContractStub : aelf::ContractStubBase
    {
      public aelf::IMethodStub<global::Acs6.RequestRandomNumberInput, global::Acs6.RandomNumberOrder> RequestRandomNumber
      {
        get { return __factory.Create(__Method_RequestRandomNumber); }
      }

      public aelf::IMethodStub<global::AElf.Types.Hash, global::AElf.Types.Hash> GetRandomNumber
      {
        get { return __factory.Create(__Method_GetRandomNumber); }
      }

    }
  }
}
#endregion

