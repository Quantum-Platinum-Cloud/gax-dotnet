/*
 * Copyright 2016 Google Inc. All Rights Reserved.
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE file or at
 * https://developers.google.com/open-source/licenses/bsd
 */

// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/api/config_change.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Api {

  /// <summary>Holder for reflection information generated from google/api/config_change.proto</summary>
  public static partial class ConfigChangeReflection {

    #region Descriptor
    /// <summary>File descriptor for google/api/config_change.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ConfigChangeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch5nb29nbGUvYXBpL2NvbmZpZ19jaGFuZ2UucHJvdG8SCmdvb2dsZS5hcGki",
            "lwEKDENvbmZpZ0NoYW5nZRIPCgdlbGVtZW50GAEgASgJEhEKCW9sZF92YWx1",
            "ZRgCIAEoCRIRCgluZXdfdmFsdWUYAyABKAkSKwoLY2hhbmdlX3R5cGUYBCAB",
            "KA4yFi5nb29nbGUuYXBpLkNoYW5nZVR5cGUSIwoHYWR2aWNlcxgFIAMoCzIS",
            "Lmdvb2dsZS5hcGkuQWR2aWNlIh0KBkFkdmljZRITCgtkZXNjcmlwdGlvbhgC",
            "IAEoCSpPCgpDaGFuZ2VUeXBlEhsKF0NIQU5HRV9UWVBFX1VOU1BFQ0lGSUVE",
            "EAASCQoFQURERUQQARILCgdSRU1PVkVEEAISDAoITU9ESUZJRUQQA0JxCg5j",
            "b20uZ29vZ2xlLmFwaUIRQ29uZmlnQ2hhbmdlUHJvdG9QAVpDZ29vZ2xlLmdv",
            "bGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9hcGkvY29uZmlnY2hhbmdl",
            "O2NvbmZpZ2NoYW5nZaICBEdBUEliBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Google.Api.ChangeType), }, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Api.ConfigChange), global::Google.Api.ConfigChange.Parser, new[]{ "Element", "OldValue", "NewValue", "ChangeType", "Advices" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Api.Advice), global::Google.Api.Advice.Parser, new[]{ "Description" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  /// <summary>
  /// Classifies set of possible modifications to an object in the service
  /// configuration.
  /// </summary>
  public enum ChangeType {
    /// <summary>
    /// No value was provided.
    /// </summary>
    [pbr::OriginalName("CHANGE_TYPE_UNSPECIFIED")] Unspecified = 0,
    /// <summary>
    /// The changed object exists in the 'new' service configuration, but not
    /// in the 'old' service configuration.
    /// </summary>
    [pbr::OriginalName("ADDED")] Added = 1,
    /// <summary>
    /// The changed object exists in the 'old' service configuration, but not
    /// in the 'new' service configuration.
    /// </summary>
    [pbr::OriginalName("REMOVED")] Removed = 2,
    /// <summary>
    /// The changed object exists in both service configurations, but its value
    /// is different.
    /// </summary>
    [pbr::OriginalName("MODIFIED")] Modified = 3,
  }

  #endregion

  #region Messages
  /// <summary>
  /// Output generated from semantically comparing two versions of a service
  /// configuration.
  ///
  /// Includes detailed information about a field that have changed with
  /// applicable advice about potential consequences for the change, such as
  /// backwards-incompatibility.
  /// </summary>
  public sealed partial class ConfigChange : pb::IMessage<ConfigChange> {
    private static readonly pb::MessageParser<ConfigChange> _parser = new pb::MessageParser<ConfigChange>(() => new ConfigChange());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ConfigChange> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Api.ConfigChangeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ConfigChange() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ConfigChange(ConfigChange other) : this() {
      element_ = other.element_;
      oldValue_ = other.oldValue_;
      newValue_ = other.newValue_;
      changeType_ = other.changeType_;
      advices_ = other.advices_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ConfigChange Clone() {
      return new ConfigChange(this);
    }

    /// <summary>Field number for the "element" field.</summary>
    public const int ElementFieldNumber = 1;
    private string element_ = "";
    /// <summary>
    /// Object hierarchy path to the change, with levels separated by a '.'
    /// character. For repeated fields, an applicable unique identifier field is
    /// used for the index (usually selector, name, or id). For maps, the term
    /// 'key' is used. If the field has no unique identifier, the numeric index
    /// is used.
    /// Examples:
    /// - visibility.rules[selector=="google.LibraryService.ListBooks"].restriction
    /// - quota.metric_rules[selector=="google"].metric_costs[key=="reads"].value
    /// - logging.producer_destinations[0]
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Element {
      get { return element_; }
      set {
        element_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "old_value" field.</summary>
    public const int OldValueFieldNumber = 2;
    private string oldValue_ = "";
    /// <summary>
    /// Value of the changed object in the old Service configuration,
    /// in JSON format. This field will not be populated if ChangeType == ADDED.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string OldValue {
      get { return oldValue_; }
      set {
        oldValue_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "new_value" field.</summary>
    public const int NewValueFieldNumber = 3;
    private string newValue_ = "";
    /// <summary>
    /// Value of the changed object in the new Service configuration,
    /// in JSON format. This field will not be populated if ChangeType == REMOVED.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string NewValue {
      get { return newValue_; }
      set {
        newValue_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "change_type" field.</summary>
    public const int ChangeTypeFieldNumber = 4;
    private global::Google.Api.ChangeType changeType_ = 0;
    /// <summary>
    /// The type for this change, either ADDED, REMOVED, or MODIFIED.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Api.ChangeType ChangeType {
      get { return changeType_; }
      set {
        changeType_ = value;
      }
    }

    /// <summary>Field number for the "advices" field.</summary>
    public const int AdvicesFieldNumber = 5;
    private static readonly pb::FieldCodec<global::Google.Api.Advice> _repeated_advices_codec
        = pb::FieldCodec.ForMessage(42, global::Google.Api.Advice.Parser);
    private readonly pbc::RepeatedField<global::Google.Api.Advice> advices_ = new pbc::RepeatedField<global::Google.Api.Advice>();
    /// <summary>
    /// Collection of advice provided for this change, useful for determining the
    /// possible impact of this change.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Google.Api.Advice> Advices {
      get { return advices_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ConfigChange);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ConfigChange other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Element != other.Element) return false;
      if (OldValue != other.OldValue) return false;
      if (NewValue != other.NewValue) return false;
      if (ChangeType != other.ChangeType) return false;
      if(!advices_.Equals(other.advices_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Element.Length != 0) hash ^= Element.GetHashCode();
      if (OldValue.Length != 0) hash ^= OldValue.GetHashCode();
      if (NewValue.Length != 0) hash ^= NewValue.GetHashCode();
      if (ChangeType != 0) hash ^= ChangeType.GetHashCode();
      hash ^= advices_.GetHashCode();
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
      if (Element.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Element);
      }
      if (OldValue.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(OldValue);
      }
      if (NewValue.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(NewValue);
      }
      if (ChangeType != 0) {
        output.WriteRawTag(32);
        output.WriteEnum((int) ChangeType);
      }
      advices_.WriteTo(output, _repeated_advices_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Element.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Element);
      }
      if (OldValue.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(OldValue);
      }
      if (NewValue.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(NewValue);
      }
      if (ChangeType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ChangeType);
      }
      size += advices_.CalculateSize(_repeated_advices_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ConfigChange other) {
      if (other == null) {
        return;
      }
      if (other.Element.Length != 0) {
        Element = other.Element;
      }
      if (other.OldValue.Length != 0) {
        OldValue = other.OldValue;
      }
      if (other.NewValue.Length != 0) {
        NewValue = other.NewValue;
      }
      if (other.ChangeType != 0) {
        ChangeType = other.ChangeType;
      }
      advices_.Add(other.advices_);
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
            Element = input.ReadString();
            break;
          }
          case 18: {
            OldValue = input.ReadString();
            break;
          }
          case 26: {
            NewValue = input.ReadString();
            break;
          }
          case 32: {
            changeType_ = (global::Google.Api.ChangeType) input.ReadEnum();
            break;
          }
          case 42: {
            advices_.AddEntriesFrom(input, _repeated_advices_codec);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// Generated advice about this change, used for providing more
  /// information about how a change will affect the existing service.
  /// </summary>
  public sealed partial class Advice : pb::IMessage<Advice> {
    private static readonly pb::MessageParser<Advice> _parser = new pb::MessageParser<Advice>(() => new Advice());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Advice> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Api.ConfigChangeReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Advice() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Advice(Advice other) : this() {
      description_ = other.description_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Advice Clone() {
      return new Advice(this);
    }

    /// <summary>Field number for the "description" field.</summary>
    public const int DescriptionFieldNumber = 2;
    private string description_ = "";
    /// <summary>
    /// Useful description for why this advice was applied and what actions should
    /// be taken to mitigate any implied risks.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Description {
      get { return description_; }
      set {
        description_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Advice);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Advice other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Description != other.Description) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Description.Length != 0) hash ^= Description.GetHashCode();
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
      if (Description.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Description);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Description.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Description);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Advice other) {
      if (other == null) {
        return;
      }
      if (other.Description.Length != 0) {
        Description = other.Description;
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
            Description = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
