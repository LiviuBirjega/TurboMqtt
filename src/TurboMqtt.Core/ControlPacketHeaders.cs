// -----------------------------------------------------------------------
// <copyright file="ControlPacketHeaders.cs" company="Petabridge, LLC">
//      Copyright (C) 2024 - 2024 Petabridge, LLC <https://petabridge.com>
// </copyright>
// -----------------------------------------------------------------------

namespace TurboMqtt.Core;

/// <summary>
/// The type of MQTT packet.
/// </summary>
/// <remarks>
/// Aligns to the MQTT 3.1.1 specification: https://docs.oasis-open.org/mqtt/mqtt/v3.1.1/os/mqtt-v3.1.1-os.html
///
/// Also supports MQTT 5.0.
/// </remarks>
public enum MqttPacketType : byte
{
    Connect = 0x10,
    ConnAck = 0x20,
    Publish = 0x30,
    PubAck = 0x40,
    PubRec = 0x50,
    PubRel = 0x60,
    PubComp = 0x70,
    Subscribe = 0x80,
    SubAck = 0x90,
    Unsubscribe = 0xA0,
    UnsubAck = 0xB0,
    PingReq = 0xC0,
    PingResp = 0xD0,
    Disconnect = 0xE0,
    Auth = 0xF0
}