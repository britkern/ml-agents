// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: mlagentsenvs/envs/communicator_objects/brain_parameters.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MLAgents.CommunicatorObjects {

  /// <summary>Holder for reflection information generated from mlagentsenvs/envs/communicator_objects/brain_parameters.proto</summary>
  public static partial class BrainParametersReflection {

    #region Descriptor
    /// <summary>File descriptor for mlagentsenvs/envs/communicator_objects/brain_parameters.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BrainParametersReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj1tbGFnZW50c2VudnMvZW52cy9jb21tdW5pY2F0b3Jfb2JqZWN0cy9icmFp",
            "bl9wYXJhbWV0ZXJzLnByb3RvEhRjb21tdW5pY2F0b3Jfb2JqZWN0cxo3bWxh",
            "Z2VudHNlbnZzL2VudnMvY29tbXVuaWNhdG9yX29iamVjdHMvc3BhY2VfdHlw",
            "ZS5wcm90byLZAQoUQnJhaW5QYXJhbWV0ZXJzUHJvdG8SGgoSdmVjdG9yX2Fj",
            "dGlvbl9zaXplGAMgAygFEiIKGnZlY3Rvcl9hY3Rpb25fZGVzY3JpcHRpb25z",
            "GAUgAygJEkYKGHZlY3Rvcl9hY3Rpb25fc3BhY2VfdHlwZRgGIAEoDjIkLmNv",
            "bW11bmljYXRvcl9vYmplY3RzLlNwYWNlVHlwZVByb3RvEhIKCmJyYWluX25h",
            "bWUYByABKAkSEwoLaXNfdHJhaW5pbmcYCCABKAhKBAgBEAJKBAgCEANKBAgE",
            "EAVCH6oCHE1MQWdlbnRzLkNvbW11bmljYXRvck9iamVjdHNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::MLAgents.CommunicatorObjects.SpaceTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MLAgents.CommunicatorObjects.BrainParametersProto), global::MLAgents.CommunicatorObjects.BrainParametersProto.Parser, new[]{ "VectorActionSize", "VectorActionDescriptions", "VectorActionSpaceType", "BrainName", "IsTraining" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class BrainParametersProto : pb::IMessage<BrainParametersProto> {
    private static readonly pb::MessageParser<BrainParametersProto> _parser = new pb::MessageParser<BrainParametersProto>(() => new BrainParametersProto());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<BrainParametersProto> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MLAgents.CommunicatorObjects.BrainParametersReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BrainParametersProto() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BrainParametersProto(BrainParametersProto other) : this() {
      vectorActionSize_ = other.vectorActionSize_.Clone();
      vectorActionDescriptions_ = other.vectorActionDescriptions_.Clone();
      vectorActionSpaceType_ = other.vectorActionSpaceType_;
      brainName_ = other.brainName_;
      isTraining_ = other.isTraining_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BrainParametersProto Clone() {
      return new BrainParametersProto(this);
    }

    /// <summary>Field number for the "vector_action_size" field.</summary>
    public const int VectorActionSizeFieldNumber = 3;
    private static readonly pb::FieldCodec<int> _repeated_vectorActionSize_codec
        = pb::FieldCodec.ForInt32(26);
    private readonly pbc::RepeatedField<int> vectorActionSize_ = new pbc::RepeatedField<int>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<int> VectorActionSize {
      get { return vectorActionSize_; }
    }

    /// <summary>Field number for the "vector_action_descriptions" field.</summary>
    public const int VectorActionDescriptionsFieldNumber = 5;
    private static readonly pb::FieldCodec<string> _repeated_vectorActionDescriptions_codec
        = pb::FieldCodec.ForString(42);
    private readonly pbc::RepeatedField<string> vectorActionDescriptions_ = new pbc::RepeatedField<string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> VectorActionDescriptions {
      get { return vectorActionDescriptions_; }
    }

    /// <summary>Field number for the "vector_action_space_type" field.</summary>
    public const int VectorActionSpaceTypeFieldNumber = 6;
    private global::MLAgents.CommunicatorObjects.SpaceTypeProto vectorActionSpaceType_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::MLAgents.CommunicatorObjects.SpaceTypeProto VectorActionSpaceType {
      get { return vectorActionSpaceType_; }
      set {
        vectorActionSpaceType_ = value;
      }
    }

    /// <summary>Field number for the "brain_name" field.</summary>
    public const int BrainNameFieldNumber = 7;
    private string brainName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string BrainName {
      get { return brainName_; }
      set {
        brainName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "is_training" field.</summary>
    public const int IsTrainingFieldNumber = 8;
    private bool isTraining_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool IsTraining {
      get { return isTraining_; }
      set {
        isTraining_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as BrainParametersProto);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(BrainParametersProto other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!vectorActionSize_.Equals(other.vectorActionSize_)) return false;
      if(!vectorActionDescriptions_.Equals(other.vectorActionDescriptions_)) return false;
      if (VectorActionSpaceType != other.VectorActionSpaceType) return false;
      if (BrainName != other.BrainName) return false;
      if (IsTraining != other.IsTraining) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= vectorActionSize_.GetHashCode();
      hash ^= vectorActionDescriptions_.GetHashCode();
      if (VectorActionSpaceType != 0) hash ^= VectorActionSpaceType.GetHashCode();
      if (BrainName.Length != 0) hash ^= BrainName.GetHashCode();
      if (IsTraining != false) hash ^= IsTraining.GetHashCode();
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
      vectorActionSize_.WriteTo(output, _repeated_vectorActionSize_codec);
      vectorActionDescriptions_.WriteTo(output, _repeated_vectorActionDescriptions_codec);
      if (VectorActionSpaceType != 0) {
        output.WriteRawTag(48);
        output.WriteEnum((int) VectorActionSpaceType);
      }
      if (BrainName.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(BrainName);
      }
      if (IsTraining != false) {
        output.WriteRawTag(64);
        output.WriteBool(IsTraining);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += vectorActionSize_.CalculateSize(_repeated_vectorActionSize_codec);
      size += vectorActionDescriptions_.CalculateSize(_repeated_vectorActionDescriptions_codec);
      if (VectorActionSpaceType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) VectorActionSpaceType);
      }
      if (BrainName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(BrainName);
      }
      if (IsTraining != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(BrainParametersProto other) {
      if (other == null) {
        return;
      }
      vectorActionSize_.Add(other.vectorActionSize_);
      vectorActionDescriptions_.Add(other.vectorActionDescriptions_);
      if (other.VectorActionSpaceType != 0) {
        VectorActionSpaceType = other.VectorActionSpaceType;
      }
      if (other.BrainName.Length != 0) {
        BrainName = other.BrainName;
      }
      if (other.IsTraining != false) {
        IsTraining = other.IsTraining;
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
          case 26:
          case 24: {
            vectorActionSize_.AddEntriesFrom(input, _repeated_vectorActionSize_codec);
            break;
          }
          case 42: {
            vectorActionDescriptions_.AddEntriesFrom(input, _repeated_vectorActionDescriptions_codec);
            break;
          }
          case 48: {
            vectorActionSpaceType_ = (global::MLAgents.CommunicatorObjects.SpaceTypeProto) input.ReadEnum();
            break;
          }
          case 58: {
            BrainName = input.ReadString();
            break;
          }
          case 64: {
            IsTraining = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
