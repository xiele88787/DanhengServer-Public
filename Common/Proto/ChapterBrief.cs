// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ChapterBrief.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from ChapterBrief.proto</summary>
  public static partial class ChapterBriefReflection {

    #region Descriptor
    /// <summary>File descriptor for ChapterBrief.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ChapterBriefReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChJDaGFwdGVyQnJpZWYucHJvdG8iVAoMQ2hhcHRlckJyaWVmEhMKC0VKRUhB",
            "QUdQRUlOGAQgAygNEhMKC0xLTEhORkFLR0JMGA4gASgNEg4KBmlzX25ldxgJ",
            "IAEoCBIKCgJpZBgCIAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlBy",
            "b3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.ChapterBrief), global::EggLink.DanhengServer.Proto.ChapterBrief.Parser, new[]{ "EJEHAAGPEIN", "LKLHNFAKGBL", "IsNew", "Id" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class ChapterBrief : pb::IMessage<ChapterBrief>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ChapterBrief> _parser = new pb::MessageParser<ChapterBrief>(() => new ChapterBrief());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ChapterBrief> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.ChapterBriefReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChapterBrief() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChapterBrief(ChapterBrief other) : this() {
      eJEHAAGPEIN_ = other.eJEHAAGPEIN_.Clone();
      lKLHNFAKGBL_ = other.lKLHNFAKGBL_;
      isNew_ = other.isNew_;
      id_ = other.id_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChapterBrief Clone() {
      return new ChapterBrief(this);
    }

    /// <summary>Field number for the "EJEHAAGPEIN" field.</summary>
    public const int EJEHAAGPEINFieldNumber = 4;
    private static readonly pb::FieldCodec<uint> _repeated_eJEHAAGPEIN_codec
        = pb::FieldCodec.ForUInt32(34);
    private readonly pbc::RepeatedField<uint> eJEHAAGPEIN_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> EJEHAAGPEIN {
      get { return eJEHAAGPEIN_; }
    }

    /// <summary>Field number for the "LKLHNFAKGBL" field.</summary>
    public const int LKLHNFAKGBLFieldNumber = 14;
    private uint lKLHNFAKGBL_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint LKLHNFAKGBL {
      get { return lKLHNFAKGBL_; }
      set {
        lKLHNFAKGBL_ = value;
      }
    }

    /// <summary>Field number for the "is_new" field.</summary>
    public const int IsNewFieldNumber = 9;
    private bool isNew_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsNew {
      get { return isNew_; }
      set {
        isNew_ = value;
      }
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 2;
    private uint id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ChapterBrief);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ChapterBrief other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!eJEHAAGPEIN_.Equals(other.eJEHAAGPEIN_)) return false;
      if (LKLHNFAKGBL != other.LKLHNFAKGBL) return false;
      if (IsNew != other.IsNew) return false;
      if (Id != other.Id) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= eJEHAAGPEIN_.GetHashCode();
      if (LKLHNFAKGBL != 0) hash ^= LKLHNFAKGBL.GetHashCode();
      if (IsNew != false) hash ^= IsNew.GetHashCode();
      if (Id != 0) hash ^= Id.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Id != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Id);
      }
      eJEHAAGPEIN_.WriteTo(output, _repeated_eJEHAAGPEIN_codec);
      if (IsNew != false) {
        output.WriteRawTag(72);
        output.WriteBool(IsNew);
      }
      if (LKLHNFAKGBL != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(LKLHNFAKGBL);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Id != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Id);
      }
      eJEHAAGPEIN_.WriteTo(ref output, _repeated_eJEHAAGPEIN_codec);
      if (IsNew != false) {
        output.WriteRawTag(72);
        output.WriteBool(IsNew);
      }
      if (LKLHNFAKGBL != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(LKLHNFAKGBL);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += eJEHAAGPEIN_.CalculateSize(_repeated_eJEHAAGPEIN_codec);
      if (LKLHNFAKGBL != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LKLHNFAKGBL);
      }
      if (IsNew != false) {
        size += 1 + 1;
      }
      if (Id != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Id);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ChapterBrief other) {
      if (other == null) {
        return;
      }
      eJEHAAGPEIN_.Add(other.eJEHAAGPEIN_);
      if (other.LKLHNFAKGBL != 0) {
        LKLHNFAKGBL = other.LKLHNFAKGBL;
      }
      if (other.IsNew != false) {
        IsNew = other.IsNew;
      }
      if (other.Id != 0) {
        Id = other.Id;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 16: {
            Id = input.ReadUInt32();
            break;
          }
          case 34:
          case 32: {
            eJEHAAGPEIN_.AddEntriesFrom(input, _repeated_eJEHAAGPEIN_codec);
            break;
          }
          case 72: {
            IsNew = input.ReadBool();
            break;
          }
          case 112: {
            LKLHNFAKGBL = input.ReadUInt32();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 16: {
            Id = input.ReadUInt32();
            break;
          }
          case 34:
          case 32: {
            eJEHAAGPEIN_.AddEntriesFrom(ref input, _repeated_eJEHAAGPEIN_codec);
            break;
          }
          case 72: {
            IsNew = input.ReadBool();
            break;
          }
          case 112: {
            LKLHNFAKGBL = input.ReadUInt32();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code