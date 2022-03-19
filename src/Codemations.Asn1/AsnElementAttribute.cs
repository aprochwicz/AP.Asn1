using System;
using System.Formats.Asn1;

namespace Codemations.Asn1
{
    [AttributeUsage(AttributeTargets.Property)]
    public class AsnElementAttribute : Attribute
    {
        public Asn1Tag Tag { get; }

        public IAsnConverter Converter { get; set; } = new AsnDefaultConverter();

        public AsnElementAttribute(byte tag)
        {
            this.Tag = tag.ToAsn1Tag();
        }

        public AsnElementAttribute(TagClass tagClass, int tagValue, bool isConstructed = false)
        {
            this.Tag = new Asn1Tag(tagClass, tagValue, isConstructed);
        }

        public AsnElementAttribute(UniversalTagNumber universalTagNumber, bool isConstructed = false)
        {
            this.Tag = new Asn1Tag(universalTagNumber, isConstructed);
        }
    }
}

