// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Iot.DeviceUpdate.Models
{
    internal partial class PageableListOfDevices
    {
        internal static PageableListOfDevices DeserializePageableListOfDevices(JsonElement element)
        {
            Optional<IReadOnlyList<Device>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<Device> array = new List<Device>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Device.DeserializeDevice(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new PageableListOfDevices(Optional.ToList(value), nextLink.Value);
        }
    }
}
