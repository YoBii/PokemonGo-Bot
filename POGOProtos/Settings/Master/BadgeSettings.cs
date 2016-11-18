// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: POGOProtos/Settings/Master/BadgeSettings.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Settings.Master
{

    /// <summary>Holder for reflection information generated from POGOProtos/Settings/Master/BadgeSettings.proto</summary>
    public static partial class BadgeSettingsReflection
    {

        #region Descriptor
        /// <summary>File descriptor for POGOProtos/Settings/Master/BadgeSettings.proto</summary>
        public static pbr::FileDescriptor Descriptor
        {
            get { return descriptor; }
        }
        private static pbr::FileDescriptor descriptor;

        static BadgeSettingsReflection()
        {
            byte[] descriptorData = global::System.Convert.FromBase64String(
                string.Concat(
                  "Ci5QT0dPUHJvdG9zL1NldHRpbmdzL01hc3Rlci9CYWRnZVNldHRpbmdzLnBy",
                  "b3RvEhpQT0dPUHJvdG9zLlNldHRpbmdzLk1hc3RlchogUE9HT1Byb3Rvcy9F",
                  "bnVtcy9CYWRnZVR5cGUucHJvdG8aLlBPR09Qcm90b3MvRGF0YS9CYWRnZS9C",
                  "YWRnZUNhcHR1cmVSZXdhcmQucHJvdG8iqAEKDUJhZGdlU2V0dGluZ3MSLwoK",
                  "YmFkZ2VfdHlwZRgBIAEoDjIbLlBPR09Qcm90b3MuRW51bXMuQmFkZ2VUeXBl",
                  "EhIKCmJhZGdlX3JhbmsYAiABKAUSDwoHdGFyZ2V0cxgDIAMoBRJBCg5jYXB0",
                  "dXJlX3Jld2FyZBgEIAMoCzIpLlBPR09Qcm90b3MuRGF0YS5CYWRnZS5CYWRn",
                  "ZUNhcHR1cmVSZXdhcmRiBnByb3RvMw=="));
            descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
                new pbr::FileDescriptor[] { global::POGOProtos.Enums.BadgeTypeReflection.Descriptor, global::POGOProtos.Data.Badge.BadgeCaptureRewardReflection.Descriptor, },
                new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Settings.Master.BadgeSettings), global::POGOProtos.Settings.Master.BadgeSettings.Parser, new[]{ "BadgeType", "BadgeRank", "Targets", "CaptureReward" }, null, null, null)
                }));
        }
        #endregion

    }
    #region Messages
    public sealed partial class BadgeSettings : pb::IMessage<BadgeSettings>
    {
        private static readonly pb::MessageParser<BadgeSettings> _parser = new pb::MessageParser<BadgeSettings>(() => new BadgeSettings());
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<BadgeSettings> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::POGOProtos.Settings.Master.BadgeSettingsReflection.Descriptor.MessageTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public BadgeSettings()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public BadgeSettings(BadgeSettings other) : this()
        {
            badgeType_ = other.badgeType_;
            badgeRank_ = other.badgeRank_;
            targets_ = other.targets_.Clone();
            captureReward_ = other.captureReward_.Clone();
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public BadgeSettings Clone()
        {
            return new BadgeSettings(this);
        }

        /// <summary>Field number for the "badge_type" field.</summary>
        public const int BadgeTypeFieldNumber = 1;
        private global::POGOProtos.Enums.BadgeType badgeType_ = 0;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public global::POGOProtos.Enums.BadgeType BadgeType
        {
            get { return badgeType_; }
            set
            {
                badgeType_ = value;
            }
        }

        /// <summary>Field number for the "badge_rank" field.</summary>
        public const int BadgeRankFieldNumber = 2;
        private int badgeRank_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int BadgeRank
        {
            get { return badgeRank_; }
            set
            {
                badgeRank_ = value;
            }
        }

        /// <summary>Field number for the "targets" field.</summary>
        public const int TargetsFieldNumber = 3;
        private static readonly pb::FieldCodec<int> _repeated_targets_codec
            = pb::FieldCodec.ForInt32(26);
        private readonly pbc::RepeatedField<int> targets_ = new pbc::RepeatedField<int>();
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public pbc::RepeatedField<int> Targets
        {
            get { return targets_; }
        }

        /// <summary>Field number for the "capture_reward" field.</summary>
        public const int CaptureRewardFieldNumber = 4;
        private static readonly pb::FieldCodec<global::POGOProtos.Data.Badge.BadgeCaptureReward> _repeated_captureReward_codec
            = pb::FieldCodec.ForMessage(34, global::POGOProtos.Data.Badge.BadgeCaptureReward.Parser);
        private readonly pbc::RepeatedField<global::POGOProtos.Data.Badge.BadgeCaptureReward> captureReward_ = new pbc::RepeatedField<global::POGOProtos.Data.Badge.BadgeCaptureReward>();
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public pbc::RepeatedField<global::POGOProtos.Data.Badge.BadgeCaptureReward> CaptureReward
        {
            get { return captureReward_; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other)
        {
            return Equals(other as BadgeSettings);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(BadgeSettings other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (BadgeType != other.BadgeType) return false;
            if (BadgeRank != other.BadgeRank) return false;
            if (!targets_.Equals(other.targets_)) return false;
            if (!captureReward_.Equals(other.captureReward_)) return false;
            return true;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode()
        {
            int hash = 1;
            if (BadgeType != 0) hash ^= BadgeType.GetHashCode();
            if (BadgeRank != 0) hash ^= BadgeRank.GetHashCode();
            hash ^= targets_.GetHashCode();
            hash ^= captureReward_.GetHashCode();
            return hash;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void WriteTo(pb::CodedOutputStream output)
        {
            if (BadgeType != 0)
            {
                output.WriteRawTag(8);
                output.WriteEnum((int)BadgeType);
            }
            if (BadgeRank != 0)
            {
                output.WriteRawTag(16);
                output.WriteInt32(BadgeRank);
            }
            targets_.WriteTo(output, _repeated_targets_codec);
            captureReward_.WriteTo(output, _repeated_captureReward_codec);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize()
        {
            int size = 0;
            if (BadgeType != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeEnumSize((int)BadgeType);
            }
            if (BadgeRank != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(BadgeRank);
            }
            size += targets_.CalculateSize(_repeated_targets_codec);
            size += captureReward_.CalculateSize(_repeated_captureReward_codec);
            return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(BadgeSettings other)
        {
            if (other == null)
            {
                return;
            }
            if (other.BadgeType != 0)
            {
                BadgeType = other.BadgeType;
            }
            if (other.BadgeRank != 0)
            {
                BadgeRank = other.BadgeRank;
            }
            targets_.Add(other.targets_);
            captureReward_.Add(other.captureReward_);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(pb::CodedInputStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        input.SkipLastField();
                        break;
                    case 8:
                        {
                            badgeType_ = (global::POGOProtos.Enums.BadgeType)input.ReadEnum();
                            break;
                        }
                    case 16:
                        {
                            BadgeRank = input.ReadInt32();
                            break;
                        }
                    case 26:
                    case 24:
                        {
                            targets_.AddEntriesFrom(input, _repeated_targets_codec);
                            break;
                        }
                    case 34:
                        {
                            captureReward_.AddEntriesFrom(input, _repeated_captureReward_codec);
                            break;
                        }
                }
            }
        }

    }

    #endregion

}

#endregion Designer generated code