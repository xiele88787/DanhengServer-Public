// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RogueExhibitionStatus.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from RogueExhibitionStatus.proto</summary>
  public static partial class RogueExhibitionStatusReflection {

    #region Descriptor
    /// <summary>File descriptor for RogueExhibitionStatus.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RogueExhibitionStatusReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtSb2d1ZUV4aGliaXRpb25TdGF0dXMucHJvdG8qbwoVUm9ndWVFeGhpYml0",
            "aW9uU3RhdHVzEhkKFVJPR1VFX0VYSElCSVRJT05fTk9ORRAAEh0KGVJPR1VF",
            "X0VYSElCSVRJT05fVU5MT0NLRUQQARIcChhST0dVRV9FWEhJQklUSU9OX0RJ",
            "U1BMQVkQAkIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90",
            "bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::EggLink.DanhengServer.Proto.RogueExhibitionStatus), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum RogueExhibitionStatus {
    [pbr::OriginalName("ROGUE_EXHIBITION_NONE")] RogueExhibitionNone = 0,
    [pbr::OriginalName("ROGUE_EXHIBITION_UNLOCKED")] RogueExhibitionUnlocked = 1,
    [pbr::OriginalName("ROGUE_EXHIBITION_DISPLAY")] RogueExhibitionDisplay = 2,
  }

  #endregion

}

#endregion Designer generated code