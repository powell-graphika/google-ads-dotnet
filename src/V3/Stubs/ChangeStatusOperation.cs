// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v3/enums/change_status_operation.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V3.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v3/enums/change_status_operation.proto</summary>
  public static partial class ChangeStatusOperationReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v3/enums/change_status_operation.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ChangeStatusOperationReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjtnb29nbGUvYWRzL2dvb2dsZWFkcy92My9lbnVtcy9jaGFuZ2Vfc3RhdHVz",
            "X29wZXJhdGlvbi5wcm90bxIdZ29vZ2xlLmFkcy5nb29nbGVhZHMudjMuZW51",
            "bXMaHGdvb2dsZS9hcGkvYW5ub3RhdGlvbnMucHJvdG8idwoZQ2hhbmdlU3Rh",
            "dHVzT3BlcmF0aW9uRW51bSJaChVDaGFuZ2VTdGF0dXNPcGVyYXRpb24SDwoL",
            "VU5TUEVDSUZJRUQQABILCgdVTktOT1dOEAESCQoFQURERUQQAhILCgdDSEFO",
            "R0VEEAMSCwoHUkVNT1ZFRBAEQu8BCiFjb20uZ29vZ2xlLmFkcy5nb29nbGVh",
            "ZHMudjMuZW51bXNCGkNoYW5nZVN0YXR1c09wZXJhdGlvblByb3RvUAFaQmdv",
            "b2dsZS5nb2xhbmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvYWRzL2dvb2ds",
            "ZWFkcy92My9lbnVtcztlbnVtc6ICA0dBQaoCHUdvb2dsZS5BZHMuR29vZ2xl",
            "QWRzLlYzLkVudW1zygIdR29vZ2xlXEFkc1xHb29nbGVBZHNcVjNcRW51bXPq",
            "AiFHb29nbGU6OkFkczo6R29vZ2xlQWRzOjpWMzo6RW51bXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V3.Enums.ChangeStatusOperationEnum), global::Google.Ads.GoogleAds.V3.Enums.ChangeStatusOperationEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V3.Enums.ChangeStatusOperationEnum.Types.ChangeStatusOperation) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing operations for the ChangeStatus resource.
  /// </summary>
  public sealed partial class ChangeStatusOperationEnum : pb::IMessage<ChangeStatusOperationEnum> {
    private static readonly pb::MessageParser<ChangeStatusOperationEnum> _parser = new pb::MessageParser<ChangeStatusOperationEnum>(() => new ChangeStatusOperationEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ChangeStatusOperationEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V3.Enums.ChangeStatusOperationReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ChangeStatusOperationEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ChangeStatusOperationEnum(ChangeStatusOperationEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ChangeStatusOperationEnum Clone() {
      return new ChangeStatusOperationEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ChangeStatusOperationEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ChangeStatusOperationEnum other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
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
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ChangeStatusOperationEnum other) {
      if (other == null) {
        return;
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
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the ChangeStatusOperationEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Status of the changed resource
      /// </summary>
      public enum ChangeStatusOperation {
        /// <summary>
        /// No value has been specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents an unclassified resource unknown
        /// in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// The resource was created.
        /// </summary>
        [pbr::OriginalName("ADDED")] Added = 2,
        /// <summary>
        /// The resource was modified.
        /// </summary>
        [pbr::OriginalName("CHANGED")] Changed = 3,
        /// <summary>
        /// The resource was removed.
        /// </summary>
        [pbr::OriginalName("REMOVED")] Removed = 4,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
