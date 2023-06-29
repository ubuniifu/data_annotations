using System;
namespace Ubunifu.DataAnnotations;

[Flags]
public enum PropertyTarget {
    Create = 2,
    Update = 4,
    DTO = 8,
    All = Create | Update | DTO
}