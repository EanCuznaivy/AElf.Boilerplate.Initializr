// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: acs3.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Acs3 {

  /// <summary>Holder for reflection information generated from acs3.proto</summary>
  internal static partial class Acs3Reflection {

    #region Descriptor
    /// <summary>File descriptor for acs3.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static Acs3Reflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CgphY3MzLnByb3RvEgRhY3MzGg9hZWxmL2NvcmUucHJvdG8aEmFlbGYvb3B0",
            "aW9ucy5wcm90bxobZ29vZ2xlL3Byb3RvYnVmL2VtcHR5LnByb3RvGh9nb29n",
            "bGUvcHJvdG9idWYvdGltZXN0YW1wLnByb3RvGh5nb29nbGUvcHJvdG9idWYv",
            "d3JhcHBlcnMucHJvdG8iQQoMQXBwcm92ZUlucHV0Eh8KC3Byb3Bvc2FsX2lk",
            "GAEgASgLMgouYWVsZi5IYXNoEhAKCHF1YW50aXR5GAIgASgSIsUBChNDcmVh",
            "dGVQcm9wb3NhbElucHV0EhwKFGNvbnRyYWN0X21ldGhvZF9uYW1lGAIgASgJ",
            "EiEKCnRvX2FkZHJlc3MYAyABKAsyDS5hZWxmLkFkZHJlc3MSDgoGcGFyYW1z",
            "GAQgASgMEjAKDGV4cGlyZWRfdGltZRgFIAEoCzIaLmdvb2dsZS5wcm90b2J1",
            "Zi5UaW1lc3RhbXASKwoUb3JnYW5pemF0aW9uX2FkZHJlc3MYBiABKAsyDS5h",
            "ZWxmLkFkZHJlc3MimgIKDlByb3Bvc2FsT3V0cHV0Eh8KC3Byb3Bvc2FsX2lk",
            "GAEgASgLMgouYWVsZi5IYXNoEhwKFGNvbnRyYWN0X21ldGhvZF9uYW1lGAIg",
            "ASgJEiEKCnRvX2FkZHJlc3MYAyABKAsyDS5hZWxmLkFkZHJlc3MSDgoGcGFy",
            "YW1zGAQgASgMEjAKDGV4cGlyZWRfdGltZRgFIAEoCzIaLmdvb2dsZS5wcm90",
            "b2J1Zi5UaW1lc3RhbXASKwoUb3JnYW5pemF0aW9uX2FkZHJlc3MYBiABKAsy",
            "DS5hZWxmLkFkZHJlc3MSHwoIcHJvcG9zZXIYByABKAsyDS5hZWxmLkFkZHJl",
            "c3MSFgoOdG9fYmVfcmVsZWFzZWQYCCABKAgy+AEKFUF1dGhvcml6YXRpb25D",
            "b250cmFjdBI5Cg5DcmVhdGVQcm9wb3NhbBIZLmFjczMuQ3JlYXRlUHJvcG9z",
            "YWxJbnB1dBoKLmFlbGYuSGFzaCIAEjsKB0FwcHJvdmUSEi5hY3MzLkFwcHJv",
            "dmVJbnB1dBoaLmdvb2dsZS5wcm90b2J1Zi5Cb29sVmFsdWUiABIvCgdSZWxl",
            "YXNlEgouYWVsZi5IYXNoGhYuZ29vZ2xlLnByb3RvYnVmLkVtcHR5IgASNgoL",
            "R2V0UHJvcG9zYWwSCi5hZWxmLkhhc2gaFC5hY3MzLlByb3Bvc2FsT3V0cHV0",
            "IgWIifcBAUIJipL0AQRhY3MzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::AElf.Types.CoreReflection.Descriptor, global::AElf.OptionsReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Acs3.ApproveInput), global::Acs3.ApproveInput.Parser, new[]{ "ProposalId", "Quantity" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Acs3.CreateProposalInput), global::Acs3.CreateProposalInput.Parser, new[]{ "ContractMethodName", "ToAddress", "Params", "ExpiredTime", "OrganizationAddress" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Acs3.ProposalOutput), global::Acs3.ProposalOutput.Parser, new[]{ "ProposalId", "ContractMethodName", "ToAddress", "Params", "ExpiredTime", "OrganizationAddress", "Proposer", "ToBeReleased" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  internal sealed partial class ApproveInput : pb::IMessage<ApproveInput> {
    private static readonly pb::MessageParser<ApproveInput> _parser = new pb::MessageParser<ApproveInput>(() => new ApproveInput());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ApproveInput> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Acs3.Acs3Reflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ApproveInput() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ApproveInput(ApproveInput other) : this() {
      proposalId_ = other.proposalId_ != null ? other.proposalId_.Clone() : null;
      quantity_ = other.quantity_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ApproveInput Clone() {
      return new ApproveInput(this);
    }

    /// <summary>Field number for the "proposal_id" field.</summary>
    public const int ProposalIdFieldNumber = 1;
    private global::AElf.Types.Hash proposalId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::AElf.Types.Hash ProposalId {
      get { return proposalId_; }
      set {
        proposalId_ = value;
      }
    }

    /// <summary>Field number for the "quantity" field.</summary>
    public const int QuantityFieldNumber = 2;
    private long quantity_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long Quantity {
      get { return quantity_; }
      set {
        quantity_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ApproveInput);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ApproveInput other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(ProposalId, other.ProposalId)) return false;
      if (Quantity != other.Quantity) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (proposalId_ != null) hash ^= ProposalId.GetHashCode();
      if (Quantity != 0L) hash ^= Quantity.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (proposalId_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(ProposalId);
      }
      if (Quantity != 0L) {
        output.WriteRawTag(16);
        output.WriteSInt64(Quantity);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (proposalId_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ProposalId);
      }
      if (Quantity != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeSInt64Size(Quantity);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ApproveInput other) {
      if (other == null) {
        return;
      }
      if (other.proposalId_ != null) {
        if (proposalId_ == null) {
          ProposalId = new global::AElf.Types.Hash();
        }
        ProposalId.MergeFrom(other.ProposalId);
      }
      if (other.Quantity != 0L) {
        Quantity = other.Quantity;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            if (proposalId_ == null) {
              ProposalId = new global::AElf.Types.Hash();
            }
            input.ReadMessage(ProposalId);
            break;
          }
          case 16: {
            Quantity = input.ReadSInt64();
            break;
          }
        }
      }
    }

  }

  internal sealed partial class CreateProposalInput : pb::IMessage<CreateProposalInput> {
    private static readonly pb::MessageParser<CreateProposalInput> _parser = new pb::MessageParser<CreateProposalInput>(() => new CreateProposalInput());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CreateProposalInput> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Acs3.Acs3Reflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CreateProposalInput() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CreateProposalInput(CreateProposalInput other) : this() {
      contractMethodName_ = other.contractMethodName_;
      toAddress_ = other.toAddress_ != null ? other.toAddress_.Clone() : null;
      params_ = other.params_;
      expiredTime_ = other.expiredTime_ != null ? other.expiredTime_.Clone() : null;
      organizationAddress_ = other.organizationAddress_ != null ? other.organizationAddress_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CreateProposalInput Clone() {
      return new CreateProposalInput(this);
    }

    /// <summary>Field number for the "contract_method_name" field.</summary>
    public const int ContractMethodNameFieldNumber = 2;
    private string contractMethodName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ContractMethodName {
      get { return contractMethodName_; }
      set {
        contractMethodName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "to_address" field.</summary>
    public const int ToAddressFieldNumber = 3;
    private global::AElf.Types.Address toAddress_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::AElf.Types.Address ToAddress {
      get { return toAddress_; }
      set {
        toAddress_ = value;
      }
    }

    /// <summary>Field number for the "params" field.</summary>
    public const int ParamsFieldNumber = 4;
    private pb::ByteString params_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString Params {
      get { return params_; }
      set {
        params_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "expired_time" field.</summary>
    public const int ExpiredTimeFieldNumber = 5;
    private global::Google.Protobuf.WellKnownTypes.Timestamp expiredTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp ExpiredTime {
      get { return expiredTime_; }
      set {
        expiredTime_ = value;
      }
    }

    /// <summary>Field number for the "organization_address" field.</summary>
    public const int OrganizationAddressFieldNumber = 6;
    private global::AElf.Types.Address organizationAddress_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::AElf.Types.Address OrganizationAddress {
      get { return organizationAddress_; }
      set {
        organizationAddress_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CreateProposalInput);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CreateProposalInput other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ContractMethodName != other.ContractMethodName) return false;
      if (!object.Equals(ToAddress, other.ToAddress)) return false;
      if (Params != other.Params) return false;
      if (!object.Equals(ExpiredTime, other.ExpiredTime)) return false;
      if (!object.Equals(OrganizationAddress, other.OrganizationAddress)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ContractMethodName.Length != 0) hash ^= ContractMethodName.GetHashCode();
      if (toAddress_ != null) hash ^= ToAddress.GetHashCode();
      if (Params.Length != 0) hash ^= Params.GetHashCode();
      if (expiredTime_ != null) hash ^= ExpiredTime.GetHashCode();
      if (organizationAddress_ != null) hash ^= OrganizationAddress.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (ContractMethodName.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(ContractMethodName);
      }
      if (toAddress_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(ToAddress);
      }
      if (Params.Length != 0) {
        output.WriteRawTag(34);
        output.WriteBytes(Params);
      }
      if (expiredTime_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(ExpiredTime);
      }
      if (organizationAddress_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(OrganizationAddress);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ContractMethodName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ContractMethodName);
      }
      if (toAddress_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ToAddress);
      }
      if (Params.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(Params);
      }
      if (expiredTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ExpiredTime);
      }
      if (organizationAddress_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(OrganizationAddress);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CreateProposalInput other) {
      if (other == null) {
        return;
      }
      if (other.ContractMethodName.Length != 0) {
        ContractMethodName = other.ContractMethodName;
      }
      if (other.toAddress_ != null) {
        if (toAddress_ == null) {
          ToAddress = new global::AElf.Types.Address();
        }
        ToAddress.MergeFrom(other.ToAddress);
      }
      if (other.Params.Length != 0) {
        Params = other.Params;
      }
      if (other.expiredTime_ != null) {
        if (expiredTime_ == null) {
          ExpiredTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        ExpiredTime.MergeFrom(other.ExpiredTime);
      }
      if (other.organizationAddress_ != null) {
        if (organizationAddress_ == null) {
          OrganizationAddress = new global::AElf.Types.Address();
        }
        OrganizationAddress.MergeFrom(other.OrganizationAddress);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 18: {
            ContractMethodName = input.ReadString();
            break;
          }
          case 26: {
            if (toAddress_ == null) {
              ToAddress = new global::AElf.Types.Address();
            }
            input.ReadMessage(ToAddress);
            break;
          }
          case 34: {
            Params = input.ReadBytes();
            break;
          }
          case 42: {
            if (expiredTime_ == null) {
              ExpiredTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(ExpiredTime);
            break;
          }
          case 50: {
            if (organizationAddress_ == null) {
              OrganizationAddress = new global::AElf.Types.Address();
            }
            input.ReadMessage(OrganizationAddress);
            break;
          }
        }
      }
    }

  }

  internal sealed partial class ProposalOutput : pb::IMessage<ProposalOutput> {
    private static readonly pb::MessageParser<ProposalOutput> _parser = new pb::MessageParser<ProposalOutput>(() => new ProposalOutput());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ProposalOutput> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Acs3.Acs3Reflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ProposalOutput() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ProposalOutput(ProposalOutput other) : this() {
      proposalId_ = other.proposalId_ != null ? other.proposalId_.Clone() : null;
      contractMethodName_ = other.contractMethodName_;
      toAddress_ = other.toAddress_ != null ? other.toAddress_.Clone() : null;
      params_ = other.params_;
      expiredTime_ = other.expiredTime_ != null ? other.expiredTime_.Clone() : null;
      organizationAddress_ = other.organizationAddress_ != null ? other.organizationAddress_.Clone() : null;
      proposer_ = other.proposer_ != null ? other.proposer_.Clone() : null;
      toBeReleased_ = other.toBeReleased_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ProposalOutput Clone() {
      return new ProposalOutput(this);
    }

    /// <summary>Field number for the "proposal_id" field.</summary>
    public const int ProposalIdFieldNumber = 1;
    private global::AElf.Types.Hash proposalId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::AElf.Types.Hash ProposalId {
      get { return proposalId_; }
      set {
        proposalId_ = value;
      }
    }

    /// <summary>Field number for the "contract_method_name" field.</summary>
    public const int ContractMethodNameFieldNumber = 2;
    private string contractMethodName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ContractMethodName {
      get { return contractMethodName_; }
      set {
        contractMethodName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "to_address" field.</summary>
    public const int ToAddressFieldNumber = 3;
    private global::AElf.Types.Address toAddress_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::AElf.Types.Address ToAddress {
      get { return toAddress_; }
      set {
        toAddress_ = value;
      }
    }

    /// <summary>Field number for the "params" field.</summary>
    public const int ParamsFieldNumber = 4;
    private pb::ByteString params_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString Params {
      get { return params_; }
      set {
        params_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "expired_time" field.</summary>
    public const int ExpiredTimeFieldNumber = 5;
    private global::Google.Protobuf.WellKnownTypes.Timestamp expiredTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp ExpiredTime {
      get { return expiredTime_; }
      set {
        expiredTime_ = value;
      }
    }

    /// <summary>Field number for the "organization_address" field.</summary>
    public const int OrganizationAddressFieldNumber = 6;
    private global::AElf.Types.Address organizationAddress_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::AElf.Types.Address OrganizationAddress {
      get { return organizationAddress_; }
      set {
        organizationAddress_ = value;
      }
    }

    /// <summary>Field number for the "proposer" field.</summary>
    public const int ProposerFieldNumber = 7;
    private global::AElf.Types.Address proposer_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::AElf.Types.Address Proposer {
      get { return proposer_; }
      set {
        proposer_ = value;
      }
    }

    /// <summary>Field number for the "to_be_released" field.</summary>
    public const int ToBeReleasedFieldNumber = 8;
    private bool toBeReleased_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool ToBeReleased {
      get { return toBeReleased_; }
      set {
        toBeReleased_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ProposalOutput);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ProposalOutput other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(ProposalId, other.ProposalId)) return false;
      if (ContractMethodName != other.ContractMethodName) return false;
      if (!object.Equals(ToAddress, other.ToAddress)) return false;
      if (Params != other.Params) return false;
      if (!object.Equals(ExpiredTime, other.ExpiredTime)) return false;
      if (!object.Equals(OrganizationAddress, other.OrganizationAddress)) return false;
      if (!object.Equals(Proposer, other.Proposer)) return false;
      if (ToBeReleased != other.ToBeReleased) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (proposalId_ != null) hash ^= ProposalId.GetHashCode();
      if (ContractMethodName.Length != 0) hash ^= ContractMethodName.GetHashCode();
      if (toAddress_ != null) hash ^= ToAddress.GetHashCode();
      if (Params.Length != 0) hash ^= Params.GetHashCode();
      if (expiredTime_ != null) hash ^= ExpiredTime.GetHashCode();
      if (organizationAddress_ != null) hash ^= OrganizationAddress.GetHashCode();
      if (proposer_ != null) hash ^= Proposer.GetHashCode();
      if (ToBeReleased != false) hash ^= ToBeReleased.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (proposalId_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(ProposalId);
      }
      if (ContractMethodName.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(ContractMethodName);
      }
      if (toAddress_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(ToAddress);
      }
      if (Params.Length != 0) {
        output.WriteRawTag(34);
        output.WriteBytes(Params);
      }
      if (expiredTime_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(ExpiredTime);
      }
      if (organizationAddress_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(OrganizationAddress);
      }
      if (proposer_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(Proposer);
      }
      if (ToBeReleased != false) {
        output.WriteRawTag(64);
        output.WriteBool(ToBeReleased);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (proposalId_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ProposalId);
      }
      if (ContractMethodName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ContractMethodName);
      }
      if (toAddress_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ToAddress);
      }
      if (Params.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(Params);
      }
      if (expiredTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ExpiredTime);
      }
      if (organizationAddress_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(OrganizationAddress);
      }
      if (proposer_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Proposer);
      }
      if (ToBeReleased != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ProposalOutput other) {
      if (other == null) {
        return;
      }
      if (other.proposalId_ != null) {
        if (proposalId_ == null) {
          ProposalId = new global::AElf.Types.Hash();
        }
        ProposalId.MergeFrom(other.ProposalId);
      }
      if (other.ContractMethodName.Length != 0) {
        ContractMethodName = other.ContractMethodName;
      }
      if (other.toAddress_ != null) {
        if (toAddress_ == null) {
          ToAddress = new global::AElf.Types.Address();
        }
        ToAddress.MergeFrom(other.ToAddress);
      }
      if (other.Params.Length != 0) {
        Params = other.Params;
      }
      if (other.expiredTime_ != null) {
        if (expiredTime_ == null) {
          ExpiredTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        ExpiredTime.MergeFrom(other.ExpiredTime);
      }
      if (other.organizationAddress_ != null) {
        if (organizationAddress_ == null) {
          OrganizationAddress = new global::AElf.Types.Address();
        }
        OrganizationAddress.MergeFrom(other.OrganizationAddress);
      }
      if (other.proposer_ != null) {
        if (proposer_ == null) {
          Proposer = new global::AElf.Types.Address();
        }
        Proposer.MergeFrom(other.Proposer);
      }
      if (other.ToBeReleased != false) {
        ToBeReleased = other.ToBeReleased;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            if (proposalId_ == null) {
              ProposalId = new global::AElf.Types.Hash();
            }
            input.ReadMessage(ProposalId);
            break;
          }
          case 18: {
            ContractMethodName = input.ReadString();
            break;
          }
          case 26: {
            if (toAddress_ == null) {
              ToAddress = new global::AElf.Types.Address();
            }
            input.ReadMessage(ToAddress);
            break;
          }
          case 34: {
            Params = input.ReadBytes();
            break;
          }
          case 42: {
            if (expiredTime_ == null) {
              ExpiredTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(ExpiredTime);
            break;
          }
          case 50: {
            if (organizationAddress_ == null) {
              OrganizationAddress = new global::AElf.Types.Address();
            }
            input.ReadMessage(OrganizationAddress);
            break;
          }
          case 58: {
            if (proposer_ == null) {
              Proposer = new global::AElf.Types.Address();
            }
            input.ReadMessage(Proposer);
            break;
          }
          case 64: {
            ToBeReleased = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code