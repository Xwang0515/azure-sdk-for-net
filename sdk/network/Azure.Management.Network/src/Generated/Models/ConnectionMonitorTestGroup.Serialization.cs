// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class ConnectionMonitorTestGroup : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            if (Disable != null)
            {
                writer.WritePropertyName("disable");
                writer.WriteBooleanValue(Disable.Value);
            }
            writer.WritePropertyName("testConfigurations");
            writer.WriteStartArray();
            foreach (var item in TestConfigurations)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("sources");
            writer.WriteStartArray();
            foreach (var item in Sources)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("destinations");
            writer.WriteStartArray();
            foreach (var item in Destinations)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            writer.WriteEndObject();
        }

        internal static ConnectionMonitorTestGroup DeserializeConnectionMonitorTestGroup(JsonElement element)
        {
            string name = default;
            bool? disable = default;
            IList<string> testConfigurations = default;
            IList<string> sources = default;
            IList<string> destinations = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("disable"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    disable = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("testConfigurations"))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(item.GetString());
                        }
                    }
                    testConfigurations = array;
                    continue;
                }
                if (property.NameEquals("sources"))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(item.GetString());
                        }
                    }
                    sources = array;
                    continue;
                }
                if (property.NameEquals("destinations"))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(item.GetString());
                        }
                    }
                    destinations = array;
                    continue;
                }
            }
            return new ConnectionMonitorTestGroup(name, disable, testConfigurations, sources, destinations);
        }
    }
}