// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v3/resources/currency_constant.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V3.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v3/resources/currency_constant.proto</summary>
  public static partial class CurrencyConstantReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v3/resources/currency_constant.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CurrencyConstantReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjlnb29nbGUvYWRzL2dvb2dsZWFkcy92My9yZXNvdXJjZXMvY3VycmVuY3lf",
            "Y29uc3RhbnQucHJvdG8SIWdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYzLnJlc291",
            "cmNlcxofZ29vZ2xlL2FwaS9maWVsZF9iZWhhdmlvci5wcm90bxoZZ29vZ2xl",
            "L2FwaS9yZXNvdXJjZS5wcm90bxoeZ29vZ2xlL3Byb3RvYnVmL3dyYXBwZXJz",
            "LnByb3RvGhxnb29nbGUvYXBpL2Fubm90YXRpb25zLnByb3RvIogDChBDdXJy",
            "ZW5jeUNvbnN0YW50EkgKDXJlc291cmNlX25hbWUYASABKAlCMeBBBfpBKwop",
            "Z29vZ2xlYWRzLmdvb2dsZWFwaXMuY29tL0N1cnJlbmN5Q29uc3RhbnQSLwoE",
            "Y29kZRgCIAEoCzIcLmdvb2dsZS5wcm90b2J1Zi5TdHJpbmdWYWx1ZUID4EED",
            "Ei8KBG5hbWUYAyABKAsyHC5nb29nbGUucHJvdG9idWYuU3RyaW5nVmFsdWVC",
            "A+BBAxIxCgZzeW1ib2wYBCABKAsyHC5nb29nbGUucHJvdG9idWYuU3RyaW5n",
            "VmFsdWVCA+BBAxI+ChRiaWxsYWJsZV91bml0X21pY3JvcxgFIAEoCzIbLmdv",
            "b2dsZS5wcm90b2J1Zi5JbnQ2NFZhbHVlQgPgQQM6VepBUgopZ29vZ2xlYWRz",
            "Lmdvb2dsZWFwaXMuY29tL0N1cnJlbmN5Q29uc3RhbnQSJWN1cnJlbmN5Q29u",
            "c3RhbnRzL3tjdXJyZW5jeV9jb25zdGFudH1CggIKJWNvbS5nb29nbGUuYWRz",
            "Lmdvb2dsZWFkcy52My5yZXNvdXJjZXNCFUN1cnJlbmN5Q29uc3RhbnRQcm90",
            "b1ABWkpnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVhcGlzL2Fk",
            "cy9nb29nbGVhZHMvdjMvcmVzb3VyY2VzO3Jlc291cmNlc6ICA0dBQaoCIUdv",
            "b2dsZS5BZHMuR29vZ2xlQWRzLlYzLlJlc291cmNlc8oCIUdvb2dsZVxBZHNc",
            "R29vZ2xlQWRzXFYzXFJlc291cmNlc+oCJUdvb2dsZTo6QWRzOjpHb29nbGVB",
            "ZHM6OlYzOjpSZXNvdXJjZXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V3.Resources.CurrencyConstant), global::Google.Ads.GoogleAds.V3.Resources.CurrencyConstant.Parser, new[]{ "ResourceName", "Code", "Name", "Symbol", "BillableUnitMicros" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A currency constant.
  /// </summary>
  public sealed partial class CurrencyConstant : pb::IMessage<CurrencyConstant> {
    private static readonly pb::MessageParser<CurrencyConstant> _parser = new pb::MessageParser<CurrencyConstant>(() => new CurrencyConstant());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CurrencyConstant> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V3.Resources.CurrencyConstantReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CurrencyConstant() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CurrencyConstant(CurrencyConstant other) : this() {
      resourceName_ = other.resourceName_;
      Code = other.Code;
      Name = other.Name;
      Symbol = other.Symbol;
      BillableUnitMicros = other.BillableUnitMicros;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CurrencyConstant Clone() {
      return new CurrencyConstant(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Immutable. The resource name of the currency constant.
    /// Currency constant resource names have the form:
    ///
    /// `currencyConstants/{currency_code}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "code" field.</summary>
    public const int CodeFieldNumber = 2;
    private static readonly pb::FieldCodec<string> _single_code_codec = pb::FieldCodec.ForClassWrapper<string>(18);
    private string code_;
    /// <summary>
    /// Output only. ISO 4217 three-letter currency code, e.g. "USD"
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Code {
      get { return code_; }
      set {
        code_ = value;
      }
    }


    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 3;
    private static readonly pb::FieldCodec<string> _single_name_codec = pb::FieldCodec.ForClassWrapper<string>(26);
    private string name_;
    /// <summary>
    /// Output only. Full English name of the currency.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = value;
      }
    }


    /// <summary>Field number for the "symbol" field.</summary>
    public const int SymbolFieldNumber = 4;
    private static readonly pb::FieldCodec<string> _single_symbol_codec = pb::FieldCodec.ForClassWrapper<string>(34);
    private string symbol_;
    /// <summary>
    /// Output only. Standard symbol for describing this currency, e.g. '$' for US Dollars.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Symbol {
      get { return symbol_; }
      set {
        symbol_ = value;
      }
    }


    /// <summary>Field number for the "billable_unit_micros" field.</summary>
    public const int BillableUnitMicrosFieldNumber = 5;
    private static readonly pb::FieldCodec<long?> _single_billableUnitMicros_codec = pb::FieldCodec.ForStructWrapper<long>(42);
    private long? billableUnitMicros_;
    /// <summary>
    /// Output only. The billable unit for this currency. Billed amounts should be multiples of
    /// this value.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long? BillableUnitMicros {
      get { return billableUnitMicros_; }
      set {
        billableUnitMicros_ = value;
      }
    }


    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CurrencyConstant);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CurrencyConstant other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (Code != other.Code) return false;
      if (Name != other.Name) return false;
      if (Symbol != other.Symbol) return false;
      if (BillableUnitMicros != other.BillableUnitMicros) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (code_ != null) hash ^= Code.GetHashCode();
      if (name_ != null) hash ^= Name.GetHashCode();
      if (symbol_ != null) hash ^= Symbol.GetHashCode();
      if (billableUnitMicros_ != null) hash ^= BillableUnitMicros.GetHashCode();
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
      if (ResourceName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ResourceName);
      }
      if (code_ != null) {
        _single_code_codec.WriteTagAndValue(output, Code);
      }
      if (name_ != null) {
        _single_name_codec.WriteTagAndValue(output, Name);
      }
      if (symbol_ != null) {
        _single_symbol_codec.WriteTagAndValue(output, Symbol);
      }
      if (billableUnitMicros_ != null) {
        _single_billableUnitMicros_codec.WriteTagAndValue(output, BillableUnitMicros);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ResourceName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ResourceName);
      }
      if (code_ != null) {
        size += _single_code_codec.CalculateSizeWithTag(Code);
      }
      if (name_ != null) {
        size += _single_name_codec.CalculateSizeWithTag(Name);
      }
      if (symbol_ != null) {
        size += _single_symbol_codec.CalculateSizeWithTag(Symbol);
      }
      if (billableUnitMicros_ != null) {
        size += _single_billableUnitMicros_codec.CalculateSizeWithTag(BillableUnitMicros);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CurrencyConstant other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.code_ != null) {
        if (code_ == null || other.Code != "") {
          Code = other.Code;
        }
      }
      if (other.name_ != null) {
        if (name_ == null || other.Name != "") {
          Name = other.Name;
        }
      }
      if (other.symbol_ != null) {
        if (symbol_ == null || other.Symbol != "") {
          Symbol = other.Symbol;
        }
      }
      if (other.billableUnitMicros_ != null) {
        if (billableUnitMicros_ == null || other.BillableUnitMicros != 0L) {
          BillableUnitMicros = other.BillableUnitMicros;
        }
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
            ResourceName = input.ReadString();
            break;
          }
          case 18: {
            string value = _single_code_codec.Read(input);
            if (code_ == null || value != "") {
              Code = value;
            }
            break;
          }
          case 26: {
            string value = _single_name_codec.Read(input);
            if (name_ == null || value != "") {
              Name = value;
            }
            break;
          }
          case 34: {
            string value = _single_symbol_codec.Read(input);
            if (symbol_ == null || value != "") {
              Symbol = value;
            }
            break;
          }
          case 42: {
            long? value = _single_billableUnitMicros_codec.Read(input);
            if (billableUnitMicros_ == null || value != 0L) {
              BillableUnitMicros = value;
            }
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code