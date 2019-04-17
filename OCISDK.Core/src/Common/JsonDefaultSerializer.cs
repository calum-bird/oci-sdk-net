﻿using Jil;

namespace OCISDK.Core.src.Common
{
    /// <summary>
    /// Default JsonSerializer(Jil)
    /// </summary>
    public class JsonDefaultSerializer : IJsonSerializer
    {
        static readonly Options Options = new Options(
            serializationNameFormat: SerializationNameFormat.CamelCase,
            excludeNulls: true
        );

        public string Serialize<T>(T data)
        {
            if (data == null) {
                return null;
            }
            return JSON.Serialize(data, Options);
        }

        public T Deserialize<T>(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return JSON.Deserialize<T>("", Options);
            }
            return JSON.Deserialize<T>(text, Options);
        }
    }
}