// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v3/enums/user_list_type.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V3.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v3/enums/user_list_type.proto</summary>
  public static partial class UserListTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v3/enums/user_list_type.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static UserListTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjJnb29nbGUvYWRzL2dvb2dsZWFkcy92My9lbnVtcy91c2VyX2xpc3RfdHlw",
            "ZS5wcm90bxIdZ29vZ2xlLmFkcy5nb29nbGVhZHMudjMuZW51bXMaHGdvb2ds",
            "ZS9hcGkvYW5ub3RhdGlvbnMucHJvdG8ipQEKEFVzZXJMaXN0VHlwZUVudW0i",
            "kAEKDFVzZXJMaXN0VHlwZRIPCgtVTlNQRUNJRklFRBAAEgsKB1VOS05PV04Q",
            "ARIPCgtSRU1BUktFVElORxACEgsKB0xPR0lDQUwQAxIYChRFWFRFUk5BTF9S",
            "RU1BUktFVElORxAEEg4KClJVTEVfQkFTRUQQBRILCgdTSU1JTEFSEAYSDQoJ",
            "Q1JNX0JBU0VEEAdC5gEKIWNvbS5nb29nbGUuYWRzLmdvb2dsZWFkcy52My5l",
            "bnVtc0IRVXNlckxpc3RUeXBlUHJvdG9QAVpCZ29vZ2xlLmdvbGFuZy5vcmcv",
            "Z2VucHJvdG8vZ29vZ2xlYXBpcy9hZHMvZ29vZ2xlYWRzL3YzL2VudW1zO2Vu",
            "dW1zogIDR0FBqgIdR29vZ2xlLkFkcy5Hb29nbGVBZHMuVjMuRW51bXPKAh1H",
            "b29nbGVcQWRzXEdvb2dsZUFkc1xWM1xFbnVtc+oCIUdvb2dsZTo6QWRzOjpH",
            "b29nbGVBZHM6OlYzOjpFbnVtc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V3.Enums.UserListTypeEnum), global::Google.Ads.GoogleAds.V3.Enums.UserListTypeEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V3.Enums.UserListTypeEnum.Types.UserListType) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// The user list types.
  /// </summary>
  public sealed partial class UserListTypeEnum : pb::IMessage<UserListTypeEnum> {
    private static readonly pb::MessageParser<UserListTypeEnum> _parser = new pb::MessageParser<UserListTypeEnum>(() => new UserListTypeEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<UserListTypeEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V3.Enums.UserListTypeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UserListTypeEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UserListTypeEnum(UserListTypeEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UserListTypeEnum Clone() {
      return new UserListTypeEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as UserListTypeEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(UserListTypeEnum other) {
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
    public void MergeFrom(UserListTypeEnum other) {
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
    /// <summary>Container for nested types declared in the UserListTypeEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Enum containing possible user list types.
      /// </summary>
      public enum UserListType {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// UserList represented as a collection of conversion types.
        /// </summary>
        [pbr::OriginalName("REMARKETING")] Remarketing = 2,
        /// <summary>
        /// UserList represented as a combination of other user lists/interests.
        /// </summary>
        [pbr::OriginalName("LOGICAL")] Logical = 3,
        /// <summary>
        /// UserList created in the Google Ad Manager platform.
        /// </summary>
        [pbr::OriginalName("EXTERNAL_REMARKETING")] ExternalRemarketing = 4,
        /// <summary>
        /// UserList associated with a rule.
        /// </summary>
        [pbr::OriginalName("RULE_BASED")] RuleBased = 5,
        /// <summary>
        /// UserList with users similar to users of another UserList.
        /// </summary>
        [pbr::OriginalName("SIMILAR")] Similar = 6,
        /// <summary>
        /// UserList of first-party CRM data provided by advertiser in the form of
        /// emails or other formats.
        /// </summary>
        [pbr::OriginalName("CRM_BASED")] CrmBased = 7,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
