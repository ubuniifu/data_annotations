using System;
namespace Ubunifu.Attributes;

[AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
public class PropertyAttribute: Attribute {
    public PropertyTarget PropertyTarget { get; }

    public PropertyAttribute(PropertyTarget target) => PropertyTarget = target;
}