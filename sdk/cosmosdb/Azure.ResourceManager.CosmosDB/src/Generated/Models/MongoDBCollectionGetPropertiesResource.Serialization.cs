// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class MongoDBCollectionGetPropertiesResource : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("id");
            writer.WriteStringValue(Id);
            if (Optional.IsCollectionDefined(ShardKey))
            {
                writer.WritePropertyName("shardKey");
                writer.WriteStartObject();
                foreach (var item in ShardKey)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(Indexes))
            {
                writer.WritePropertyName("indexes");
                writer.WriteStartArray();
                foreach (var item in Indexes)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(AnalyticalStorageTtl))
            {
                writer.WritePropertyName("analyticalStorageTtl");
                writer.WriteNumberValue(AnalyticalStorageTtl.Value);
            }
            writer.WriteEndObject();
        }

        internal static MongoDBCollectionGetPropertiesResource DeserializeMongoDBCollectionGetPropertiesResource(JsonElement element)
        {
            Optional<string> Rid = default;
            Optional<object> Ts = default;
            Optional<string> Etag = default;
            string id = default;
            Optional<IDictionary<string, string>> shardKey = default;
            Optional<IList<MongoIndex>> indexes = default;
            Optional<int> analyticalStorageTtl = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("_rid"))
                {
                    Rid = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("_ts"))
                {
                    Ts = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("_etag"))
                {
                    Etag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("shardKey"))
                {
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    shardKey = dictionary;
                    continue;
                }
                if (property.NameEquals("indexes"))
                {
                    List<MongoIndex> array = new List<MongoIndex>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MongoIndex.DeserializeMongoIndex(item));
                    }
                    indexes = array;
                    continue;
                }
                if (property.NameEquals("analyticalStorageTtl"))
                {
                    analyticalStorageTtl = property.Value.GetInt32();
                    continue;
                }
            }
            return new MongoDBCollectionGetPropertiesResource(id, Optional.ToDictionary(shardKey), Optional.ToList(indexes), Optional.ToNullable(analyticalStorageTtl), Rid.Value, Ts.Value, Etag.Value);
        }
    }
}
