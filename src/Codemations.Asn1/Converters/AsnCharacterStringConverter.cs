﻿using System;
using System.Formats.Asn1;

namespace Codemations.Asn1.Converters
{
    internal class AsnCharacterStringConverter : IAsnConverter
    {
        public bool CanConvert(Type type)
        {
            return typeof(string) == type;
        }

        public object Read(AsnReader reader, Asn1Tag? tag, Type type, AsnSerializer serializer)
        {
            return reader.ReadCharacterString(UniversalTagNumber.IA5String, tag);
        }

        public void Write(AsnWriter writer, Asn1Tag? tag, object value, AsnSerializer serializer)
        {
            writer.WriteCharacterString(UniversalTagNumber.IA5String, (string)value, tag);
        }
    }
}