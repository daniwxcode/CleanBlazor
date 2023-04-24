﻿using System.Text.Json;

namespace Application.Contracts.Serialization.Options;

public interface IJsonSerializerOptions
{
    /// <summary>
    /// Options for <see cref="System.Text.Json"/>.
    /// </summary>
    public JsonSerializerOptions JsonSerializerOptions { get; }
}