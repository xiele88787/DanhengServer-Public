// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: JBDJBNDPJFN.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from JBDJBNDPJFN.proto</summary>
  public static partial class JBDJBNDPJFNReflection {

    #region Descriptor
    /// <summary>File descriptor for JBDJBNDPJFN.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static JBDJBNDPJFNReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFKQkRKQk5EUEpGTi5wcm90bxoVUm9ndWVDb21tb25CdWZmLnByb3RvIkkK",
            "C0pCREpCTkRQSkZOEiUKC0tESVBIQUlHRExCGAIgAygLMhAuUm9ndWVDb21t",
            "b25CdWZmEhMKC0NHS0hLSkJPRkdLGAYgASgNQh6qAhtFZ2dMaW5rLkRhbmhl",
            "bmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.RogueCommonBuffReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.JBDJBNDPJFN), global::EggLink.DanhengServer.Proto.JBDJBNDPJFN.Parser, new[]{ "KDIPHAIGDLB", "CGKHKJBOFGK" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class JBDJBNDPJFN : pb::IMessage<JBDJBNDPJFN>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<JBDJBNDPJFN> _parser = new pb::MessageParser<JBDJBNDPJFN>(() => new JBDJBNDPJFN());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<JBDJBNDPJFN> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.JBDJBNDPJFNReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public JBDJBNDPJFN() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public JBDJBNDPJFN(JBDJBNDPJFN other) : this() {
      kDIPHAIGDLB_ = other.kDIPHAIGDLB_.Clone();
      cGKHKJBOFGK_ = other.cGKHKJBOFGK_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public JBDJBNDPJFN Clone() {
      return new JBDJBNDPJFN(this);
    }

    /// <summary>Field number for the "KDIPHAIGDLB" field.</summary>
    public const int KDIPHAIGDLBFieldNumber = 2;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.RogueCommonBuff> _repeated_kDIPHAIGDLB_codec
        = pb::FieldCodec.ForMessage(18, global::EggLink.DanhengServer.Proto.RogueCommonBuff.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.RogueCommonBuff> kDIPHAIGDLB_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.RogueCommonBuff>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.RogueCommonBuff> KDIPHAIGDLB {
      get { return kDIPHAIGDLB_; }
    }

    /// <summary>Field number for the "CGKHKJBOFGK" field.</summary>
    public const int CGKHKJBOFGKFieldNumber = 6;
    private uint cGKHKJBOFGK_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CGKHKJBOFGK {
      get { return cGKHKJBOFGK_; }
      set {
        cGKHKJBOFGK_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as JBDJBNDPJFN);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(JBDJBNDPJFN other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!kDIPHAIGDLB_.Equals(other.kDIPHAIGDLB_)) return false;
      if (CGKHKJBOFGK != other.CGKHKJBOFGK) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= kDIPHAIGDLB_.GetHashCode();
      if (CGKHKJBOFGK != 0) hash ^= CGKHKJBOFGK.GetHashCode();
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
      kDIPHAIGDLB_.WriteTo(output, _repeated_kDIPHAIGDLB_codec);
      if (CGKHKJBOFGK != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(CGKHKJBOFGK);
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
      kDIPHAIGDLB_.WriteTo(ref output, _repeated_kDIPHAIGDLB_codec);
      if (CGKHKJBOFGK != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(CGKHKJBOFGK);
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
      size += kDIPHAIGDLB_.CalculateSize(_repeated_kDIPHAIGDLB_codec);
      if (CGKHKJBOFGK != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CGKHKJBOFGK);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(JBDJBNDPJFN other) {
      if (other == null) {
        return;
      }
      kDIPHAIGDLB_.Add(other.kDIPHAIGDLB_);
      if (other.CGKHKJBOFGK != 0) {
        CGKHKJBOFGK = other.CGKHKJBOFGK;
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
          case 18: {
            kDIPHAIGDLB_.AddEntriesFrom(input, _repeated_kDIPHAIGDLB_codec);
            break;
          }
          case 48: {
            CGKHKJBOFGK = input.ReadUInt32();
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
          case 18: {
            kDIPHAIGDLB_.AddEntriesFrom(ref input, _repeated_kDIPHAIGDLB_codec);
            break;
          }
          case 48: {
            CGKHKJBOFGK = input.ReadUInt32();
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